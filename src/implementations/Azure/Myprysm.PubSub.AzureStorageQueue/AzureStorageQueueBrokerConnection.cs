namespace Myprysm.PubSub.AzureStorageQueue;

using System.Collections.Concurrent;
using System.Globalization;
using Azure.Storage.Queues;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Myprysm.Converter.Abstractions;
using Myprysm.PubSub.Abstractions;
using Myprysm.SharedKernel.Exceptions;
using Myprysm.Tracing.Abstractions;
using Polly;
using Polly.Retry;

/// <summary>
/// <see cref="IBrokerConnection"/> with Azure Storage Queues. 
/// </summary>
public class AzureStorageQueueBrokerConnection : IBrokerConnection
{
    private const string PoisonQueueSuffix = "-poison";
    private const int MaxTriesPerStep = 4;
    private static readonly TimeSpan IntervalStep = TimeSpan.FromMilliseconds(100);
    private static readonly TimeSpan MinimumPollingInterval = TimeSpan.FromMilliseconds(100);
    private static readonly TimeSpan MaximumPollingInterval = TimeSpan.FromMinutes(1);
    private static readonly BrokerCapabilities CapabilitiesInstance = new(Transport.Persistent, false, false);
    private readonly QueueServiceClient queueService;
    private readonly IConverter converter;
    private readonly ITracer tracer;
    private readonly ILogger<AzureStorageQueueBrokerConnection> logger;
    private readonly ILogger<AzureStorageQueueSubscription> subscriptionLogger;
    private readonly ConcurrentDictionary<string, QueueClient> queueClients;
    private readonly ConcurrentDictionary<string, AzureStorageQueueSubscription> subscriptions;
    private readonly TimeSpan pollingInterval;
    private readonly int batchSize;
    private readonly int maxRetriesBeforeMax;
    private readonly int maxDequeueCount;
    private readonly AsyncRetryPolicy retryPolicy;
    private bool disposed;
    private readonly SubscriptionExceptionHandler globalExceptionHandler;

    /// <summary>
    /// Creates a new <see cref="AzureStorageQueueBrokerConnection"/> with the given dependencies.
    /// </summary>
    /// <param name="converter">The converter used to send the publications over the wire.</param>
    /// <param name="tracerFactory">The tracer factory to trace the publications.</param>
    /// <param name="options">The options.</param>
    /// <param name="logger">The logger.</param>
    /// <param name="subscriptionLogger">The logger for subscriptions.</param>
    public AzureStorageQueueBrokerConnection(
        IConverter converter,
        ITracerFactory tracerFactory,
        IOptions<AzureStorageQueuePubSubOptions> options,
        ILogger<AzureStorageQueueBrokerConnection> logger,
        ILogger<AzureStorageQueueSubscription> subscriptionLogger)
    {
        this.pollingInterval = options.Value.MaxPollingInterval;
        if (this.pollingInterval < MinimumPollingInterval)
        {
            this.pollingInterval = MinimumPollingInterval;
        }

        if (this.pollingInterval > MaximumPollingInterval)
        {
            this.pollingInterval = MaximumPollingInterval;
        }

        this.maxRetriesBeforeMax = (int)this.pollingInterval.TotalMilliseconds / MaxTriesPerStep;

        this.batchSize = options.Value.MaxBatchSize;
        if (this.batchSize < 1)
        {
            this.batchSize = 1;
        }

        if (this.batchSize > 32)
        {
            this.batchSize = 32;
        }

        this.maxDequeueCount = options.Value.MaxDequeueCount;
        if (this.maxDequeueCount < 1)
        {
            this.maxDequeueCount = 1;
        }

        if (this.maxDequeueCount > 10)
        {
            this.maxDequeueCount = 10;
        }

        this.tracer = tracerFactory.GetTracer(PubSubAzureStorageQueueConstants.TracerIdentity);
        this.queueService = new QueueServiceClient(options.Value.ConnectionString);
        this.converter = converter;
        this.logger = logger;
        this.subscriptionLogger = subscriptionLogger;
        this.queueClients = new ConcurrentDictionary<string, QueueClient>();
        this.subscriptions = new ConcurrentDictionary<string, AzureStorageQueueSubscription>();
        this.retryPolicy = Policy
            .Handle<EmptyQueueException>()
            .WaitAndRetryForeverAsync(this.CalculateWaitIntervalForAttempt);
        this.globalExceptionHandler = options.Value.GlobalSubscriptionExceptionHandler;
    }

    private TimeSpan CalculateWaitIntervalForAttempt(int attempt)
    {
        if (this.pollingInterval == MinimumPollingInterval)
        {
            return MinimumPollingInterval;
        }

        if (attempt > this.maxRetriesBeforeMax)
        {
            return this.pollingInterval;
        }

        var factor = (attempt / MaxTriesPerStep) * 2;
        return IntervalStep * (factor < 1 ? 1 : factor);
    }

    /// <inheritdoc />
    public BrokerCapabilities Capabilities => CapabilitiesInstance;

    /// <inheritdoc />
    public async Task Publish(Publication publication, CancellationToken cancellation = default)
    {
        using var trace = this.tracer.StartTrace(nameof(this.Publish), TraceKind.Producer, publication.Trace);
        trace?.AddTag("broker_connection.topic", publication.Topic.Value);
        trace?.AddTag("broker_connection.size", publication.Message.LongLength.ToString(CultureInfo.InvariantCulture));
        trace?.AddTag("broker_connection.is_volatile", publication.IsVolatile.ToString());

        try
        {
            if (this.disposed)
            {
                throw new ObjectDisposedException(nameof(AzureStorageQueueBrokerConnection));
            }

            var client = await this.GetClient(publication.Topic.Value, cancellation).ConfigureAwait(false);

            var serializedTrace = SerializedTrace.GetSerializedTrace(trace);
            var envelope = new Envelope(publication.Message, serializedTrace);
            var payload = this.converter.WriteBytes(envelope);

            _ = await client.SendMessageAsync(new BinaryData(payload), cancellationToken: cancellation).ConfigureAwait(false);
        }
        catch (Exception exception)
        {
            this.logger.LogError(exception, "An error occured during the publication: {Message}", exception.Message);
            trace?.AddTag("otel.status_code", "ERROR");
            trace?.AddTag("otel.status_description", $"Unhandled exception: {exception.Message}");
            throw;
        }
    }

    internal async ValueTask<QueueClient> GetClient(string queue, CancellationToken cancellation)
    {
        if (this.queueClients.ContainsKey(queue))
        {
            return this.queueClients[queue];
        }

        var client = this.queueService.GetQueueClient(queue);
        _ = await client.CreateIfNotExistsAsync(cancellationToken: cancellation).ConfigureAwait(false);

        return this.queueClients.GetOrAdd(queue, client);
    }

    /// <inheritdoc />
    public async Task<ISubscription> Subscribe(
        Topic topic,
        PublicationHandler handler,
        SubscriptionGroup? group = null,
        SubscriptionExceptionHandler? exceptionHandler = null,
        CancellationToken cancellation = default)
    {
        if (this.disposed)
        {
            throw new ObjectDisposedException(nameof(AzureStorageQueueBrokerConnection));
        }

        if (group != null)
        {
            throw new IllegalOperationException("Subscription groups are not supported with Azure Storage Queue broker.");
        }

        if (this.subscriptions.ContainsKey(topic.Value))
        {
            throw new IllegalOperationException("Multiple subscriptions on the same topic are not supported with Azure Storage Queue broker.");
        }

        var poisonQueue = $"{topic.Value}{PoisonQueueSuffix}";
        var queueClient = await this.GetClient(topic.Value, cancellation).ConfigureAwait(false);
        var poisonQueueClient = await this.GetClient(poisonQueue, cancellation).ConfigureAwait(false);

        var subscription = new AzureStorageQueueSubscription(
            queueClient,
            poisonQueueClient,
            handler,
            exceptionHandler ?? this.globalExceptionHandler,
            this.retryPolicy,
            this.batchSize,
            this.maxDequeueCount,
            this.converter,
            this.tracer,
            this.subscriptionLogger,
            () => this.subscriptions.TryRemove(topic.Value, out _));
        this.subscriptions[topic.Value] = subscription;

        subscription.StartPolling();

        return subscription;
    }

    /// <inheritdoc />
    public void Dispose()
    {
        if (this.disposed)
        {
            return;
        }

        this.disposed = true;
        foreach (var subscription in this.subscriptions.Values.ToList())
        {
            subscription.Dispose();
        }
    }
}
