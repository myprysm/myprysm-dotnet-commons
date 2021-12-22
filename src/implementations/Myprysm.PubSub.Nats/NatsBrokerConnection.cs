namespace Myprysm.PubSub.Nats;

using System;
using System.Collections.Concurrent;
using System.Globalization;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Myprysm.Converter.Abstractions;
using Myprysm.PubSub.Abstractions;
using Myprysm.Tracing.Abstractions;
using NATS.Client;
using ISubscription = Myprysm.PubSub.Abstractions.ISubscription;

/// <summary>
/// <see cref="IBrokerConnection"/> with <see href="https://nats.io/">NATS</see> for a volatile but crazy quick PubSub. 
/// </summary>
public class NatsBrokerConnection : IBrokerConnection
{
    private static readonly BrokerCapabilities CapabilitiesInstance = new(Transport.Transient, Replay: false, SubscriptionGroups: true);

    internal readonly IConnection Connection;
    private readonly IConverter converter;
    private readonly ITracer tracer;
    private readonly ConcurrentDictionary<IAsyncSubscription, NatsSubscription> subscriptions;
    private readonly ILogger<NatsBrokerConnection> logger;
    private readonly ILogger<NatsSubscription> subscriptionLogger;
    private readonly SubscriptionExceptionHandler globalExceptionHandler;
    private readonly bool tracingEnabled;
    private bool disposed;

    /// <summary>
    /// Creates a new <see cref="NatsBrokerConnection"/> with the given dependencies.
    /// </summary>
    /// <param name="converter">The converter used to send the publications over the wire.</param>
    /// <param name="tracerFactory">The tracer factory to trace the publications.</param>
    /// <param name="options">The options.</param>
    /// <param name="logger">The logger.</param>
    /// <param name="subscriptionLogger">The logger for subscriptions.</param>
    public NatsBrokerConnection(
        IConverter converter,
        ITracerFactory tracerFactory,
        IOptions<NatsPubSubOptions> options,
        ILogger<NatsBrokerConnection> logger,
        ILogger<NatsSubscription> subscriptionLogger)
    {
        this.logger = logger;
        this.subscriptionLogger = subscriptionLogger;
        this.tracer = tracerFactory.GetTracer(PubSubNatsConstants.TracerIdentity);
        this.converter = converter;
        this.Connection = this.CreateConnection(options.Value);
        this.subscriptions = new ConcurrentDictionary<IAsyncSubscription, NatsSubscription>();
        this.globalExceptionHandler = options.Value.GlobalSubscriptionExceptionHandler;
        this.tracingEnabled = options.Value.WithTracing;
    }

    /// <inheritdoc />
    /// <remarks>
    /// This implementation only supports <see cref="Transport.Transient"/> transport.
    /// </remarks>
    public BrokerCapabilities Capabilities => CapabilitiesInstance;

    /// <inheritdoc />
    public Task Publish(Publication publication, CancellationToken cancellation = default)
    {
        using var trace = this.tracingEnabled
            ? this.tracer.StartTrace(nameof(this.Publish), TraceKind.Producer, publication.Trace)
            : null;
        trace?.AddTag("broker_connection.topic", publication.Topic.Value);
        trace?.AddTag("broker_connection.size", publication.Message.LongLength.ToString(CultureInfo.InvariantCulture));
        trace?.AddTag("broker_connection.is_volatile", publication.IsVolatile.ToString());

        try
        {
            var header = this.CreateHeader(publication, trace);

            var message = new Msg
            {
                Subject = publication.Topic.Value,
                Data = publication.Message,
                Header = header,
            };

            this.Connection.Publish(message);
            return Task.CompletedTask;
        }
        catch (Exception exception)
        {
            this.logger.LogError(exception, "An error occured during the publication: {Message}", exception.Message);
            trace?.AddTag("otel.status_code", "ERROR");
            trace?.AddTag("otel.status_description", $"Unhandled exception: {exception.Message}");
            throw;
        }
    }

    private MsgHeader? CreateHeader(
        Publication publication,
        ITrace? trace)
    {
        var messageHeader = new MsgHeader();

        if (publication.Headers is null && trace is null)
        {
            return messageHeader;
        }


        if (publication.Headers is not null)
        {
            foreach (var (key, value) in publication.Headers)
            {
                if (PubSubNatsConstants.ProtectedHeaders.Contains(key))
                {
                    this.logger.LogWarning(
                        "Publication {@Publication} contains the protected header {ProtectedHeader}. Please update your code not to use this header name",
                        publication,
                        key);
                    continue;
                }

                messageHeader.Add(key, value ?? string.Empty);
            }
        }

        if (trace is not null)
        {
            messageHeader[PubSubNatsConstants.TraceIdHeader] = trace.Id;
            messageHeader[PubSubNatsConstants.TraceBaggageHeader] = this.converter.WriteString(trace.Baggage);
        }

        return messageHeader;
    }

    /// <inheritdoc />
    public Task<ISubscription> Subscribe(
        Topic topic,
        PublicationHandler handler,
        SubscriptionGroup? group = null,
        SubscriptionExceptionHandler? exceptionHandler = null,
        CancellationToken cancellation = default)
    {
        var subscription = this.Connection.SubscribeAsync(topic.Value, group?.Value);
        var mappedSubscription = new NatsSubscription(
            handler,
            exceptionHandler ?? this.globalExceptionHandler,
            subscription,
            this.tracingEnabled,
            this.converter,
            this.tracer,
            this.subscriptionLogger,
            () => this.subscriptions.TryRemove(subscription, out _));

        this.subscriptions.TryAdd(subscription, mappedSubscription);

        return Task.FromResult<ISubscription>(mappedSubscription);
    }


    private IConnection CreateConnection(NatsPubSubOptions configuration)
    {
        var options = ConnectionFactory.GetDefaultOptions();

        options.Url = configuration.Url;

        if (configuration.WithSsl)
        {
            this.logger.LogInformation("Enabling SSL on NATS broker");
            options.Secure = true;
            var certificate = new X509Certificate2(configuration.KeyStorePath, configuration.KeyStorePassword);
            options.AddCertificate(certificate);

            if (configuration.TrustAllCertificates)
            {
                options.TLSRemoteCertificationValidationCallback = (_, _, _, _) => true;
                this.logger.LogWarning("Server certificate validation disabled. Avoid this setting in PRODUCTION");
            }
            else if (!string.IsNullOrWhiteSpace(configuration.TrustStorePath) && !string.IsNullOrWhiteSpace(configuration.TrustStorePassword))
            {
                var ca = new X509Certificate2(configuration.TrustStorePath, configuration.TrustStorePassword);
                options.TLSRemoteCertificationValidationCallback = (_, _, chain, policyErrors) =>
                {
                    return policyErrors switch
                    {
                        SslPolicyErrors.None => true,
                        SslPolicyErrors.RemoteCertificateChainErrors => chain?.ChainElements
                            .Any(element => element.Certificate.Issuer.Equals(ca.Subject, StringComparison.InvariantCulture)) ?? false,
                        _ => false,
                    };
                };

                this.logger.LogWarning("Server certificate validation configured with the provided trust store");
            }
        }

        if (!(string.IsNullOrWhiteSpace(configuration.User) || string.IsNullOrWhiteSpace(configuration.Password)))
        {
            this.logger.LogInformation("Enabling password authentication on NATS broker");
            options.User = configuration.User;
            options.Password = configuration.Password;
        }

        try
        {
            return new ConnectionFactory().CreateConnection(options);
        }
        catch (Exception exception)
        {
            this.logger.LogError(exception, "Unable to connect to NATS");
            throw;
        }
    }

    /// <summary>
    /// Disposes managed resources of <see cref="NatsSubscription"/>.
    /// </summary>
    /// <param name="disposing">If disposing equals true, the method has been called directly
    /// or indirectly by a user's code. Managed and unmanaged resources can be disposed.
    /// If disposing equals false, the method has been called by the
    /// runtime from inside the finalizer and you should not reference
    /// other objects. Only unmanaged resources can be disposed.</param>
    protected virtual void Dispose(bool disposing)
    {
        if (!this.disposed)
        {
            if (disposing)
            {
                foreach (var subscription in this.subscriptions.Values.ToList())
                {
                    subscription.Dispose();
                }

                this.Connection.Dispose();
            }

            this.disposed = true;
        }
    }

    /// <summary>
    /// Disposes managed resources of <see cref="NatsSubscription"/>.
    /// </summary>
    public void Dispose()
    {
        // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        this.Dispose(true);
    }
}
