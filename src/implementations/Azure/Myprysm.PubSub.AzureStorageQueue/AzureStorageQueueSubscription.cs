namespace Myprysm.PubSub.AzureStorageQueue;

using Azure.Storage.Queues;
using Azure.Storage.Queues.Models;
using Microsoft.Extensions.Logging;
using Myprysm.Converter.Abstractions;
using Myprysm.PubSub.Abstractions;
using Myprysm.PubSub.Abstractions.Exceptions;
using Myprysm.Tracing.Abstractions;
using Polly.Retry;

/// <summary>
/// <see cref="ISubscription"/> that receives <see cref="Publication"/> sent by an Azure Storage Queue.
/// </summary>
public sealed class AzureStorageQueueSubscription : ISubscription
{
    private readonly QueueClient queueClient;
    private readonly QueueClient poisonQueueClient;
    private readonly PublicationHandler handler;
    private readonly SubscriptionExceptionHandler exceptionHandler;
    private readonly AsyncRetryPolicy retryPolicy;
    private readonly int batchSize;
    private readonly int maxDequeueCount;
    private readonly IConverter converter;
    private readonly ITracer tracer;
    private readonly ILogger<AzureStorageQueueSubscription> logger;
    private readonly Action onDispose;
    private readonly Topic topic;
    private readonly CancellationTokenSource cancellationTokenSource;
    private bool disposed;

    internal AzureStorageQueueSubscription(
        QueueClient queueClient,
        QueueClient poisonQueueClient,
        PublicationHandler handler,
        SubscriptionExceptionHandler exceptionHandler,
        AsyncRetryPolicy retryPolicy,
        int batchSize,
        int maxDequeueCount,
        IConverter converter,
        ITracer tracer,
        ILogger<AzureStorageQueueSubscription> logger,
        Action onDispose)
    {
        this.queueClient = queueClient;
        this.poisonQueueClient = poisonQueueClient;
        this.handler = handler;
        this.exceptionHandler = exceptionHandler;
        this.retryPolicy = retryPolicy;
        this.batchSize = batchSize;
        this.maxDequeueCount = maxDequeueCount;
        this.converter = converter;
        this.tracer = tracer;
        this.logger = logger;
        this.onDispose = onDispose;
        this.topic = new Topic(this.queueClient.Name);
        this.cancellationTokenSource = new CancellationTokenSource();
    }

    internal void StartPolling()
    {
        // ReSharper disable once MethodSupportsCancellation cancellation is handled in the loop.
        Task.Run(async () =>
            {
                while (!this.cancellationTokenSource.IsCancellationRequested)
                {
                    try
                    {
                        await this.retryPolicy.ExecuteAsync(() => this.PollAndHandleMessages(this.cancellationTokenSource.Token)).ConfigureAwait(false);
                    }
                    catch (OperationCanceledException)
                    {
                        return;
                    }
                }
            })
            .ConfigureAwait(false);
    }

    private async Task PollAndHandleMessages(CancellationToken cancellation)
    {
        var messages = await this.PollMessages(cancellation).ConfigureAwait(false);

        await Task.WhenAll(messages.Select(m => this.HandleMessage(m, cancellation))).ConfigureAwait(false);
    }

    private async Task HandleMessage(QueueMessage message, CancellationToken cancellation)
    {
        using var trace = this.tracer.StartTrace(nameof(this.HandleMessage), TraceKind.Consumer);
        trace?.AddTag("azure_queue_subscription.topic", this.topic.Value);
        trace?.AddTag("azure_queue_subscription.dequeue_count", message.DequeueCount.ToString());

        try
        {
            // Check max dequeue count
            if (message.DequeueCount > this.maxDequeueCount)
            {
                await this.MoveToPoisonQueue(message, cancellation);
                return;
            }

            using var _ = new AzureStorageQueueMessageLockHolder(message, this.queueClient);

            var envelope = this.converter.Read<Envelope>(message.Body.ToStream());

            if (envelope is null)
            {
                this.logger.LogError("Envelope is null in handler for subject {Subject}", this.topic.Value);
                throw new SubscriptionHandlerException($"Envelope is null in handler for subject {this.topic}");
            }

            if (envelope.Trace is not null && trace is not null)
            {
                trace.SetParentId(envelope.Trace.Id);
                foreach (var (key, value) in envelope.Trace.Baggage)
                {
                    trace.AddBaggage(key, value);
                }
            }

            var publication = new Publication(
                this.topic,
                envelope.Payload,
                false,
                trace);
            await this.handler(publication).ConfigureAwait(false);
            await this.DeleteMessageAsync(message, cancellation).ConfigureAwait(false);
        }
        catch (SubscriptionHandlerException exception)
        {
            trace?.AddTag("otel.status_code", "ERROR");
            trace?.AddTag("otel.status_description", exception.Message);

            await this.MoveToPoisonQueue(message, cancellation);

            this.exceptionHandler(exception);
        }
        catch (Exception exception)
        {
            this.logger.LogError(
                exception,
                "Error while processing publication {PublicationId} on topic {Topic}",
                message.MessageId,
                this.topic.Value);
            trace?.AddTag("otel.status_code", "ERROR");
            trace?.AddTag("otel.status_description", $"Unhandled exception: {exception.Message}");

            // Check max dequeue count
            if (message.DequeueCount + 1 > this.maxDequeueCount)
            {
                await this.MoveToPoisonQueue(message, cancellation);
                return;
            }

            await this.queueClient
                .UpdateMessageAsync(message.MessageId, message.PopReceipt, visibilityTimeout: TimeSpan.Zero, cancellationToken: cancellation)
                .ConfigureAwait(false);

            this.exceptionHandler(exception);
        }
    }

    private async Task MoveToPoisonQueue(QueueMessage message, CancellationToken cancellation)
    {
        this.logger.LogWarning(
            "Message has reached MaxDequeueCount of {MaxDequeueCount}. Moving message to queue '{PoisonQueue}'",
            this.maxDequeueCount,
            this.poisonQueueClient.Name);

        await this.poisonQueueClient.SendMessageAsync(message.Body, cancellationToken: cancellation).ConfigureAwait(false);

        await this.DeleteMessageAsync(message, cancellation).ConfigureAwait(false);
    }

    private async Task DeleteMessageAsync(QueueMessage message, CancellationToken cancellationToken)
    {
        await this.queueClient.DeleteMessageAsync(message.MessageId, message.PopReceipt, cancellationToken);
    }

    private async Task<QueueMessage[]> PollMessages(CancellationToken cancellation)
    {
        var messages = await this.queueClient.ReceiveMessagesAsync(this.batchSize, cancellationToken: cancellation).ConfigureAwait(false);

        if (!messages.Value.Any())
        {
            throw new EmptyQueueException();
        }

        return messages.Value;
    }

    /// <inheritdoc />
    public void Dispose()
    {
        if (this.disposed)
        {
            return;
        }

        this.disposed = true;
        this.cancellationTokenSource.Cancel();
        this.cancellationTokenSource.Dispose();
        this.onDispose();
    }
}
