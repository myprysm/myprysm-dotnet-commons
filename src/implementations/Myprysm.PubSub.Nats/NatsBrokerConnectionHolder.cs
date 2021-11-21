namespace Myprysm.PubSub.Nats;

using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Myprysm.Converter.Abstractions;
using Myprysm.PubSub.Abstractions;
using Myprysm.PubSub.Abstractions.Exceptions;
using NATS.Client;
using ISubscription = Myprysm.PubSub.Abstractions.ISubscription;

public class NatsBrokerConnectionHolder : IBrokerConnection, IDisposable
{
    private static readonly BrokerCapabilities CapabilitiesInstance = new(Transport.Transient, Replay: false, SubscriptionGroups: true);

    private readonly IConverter converter;
    private readonly IConnection connection;
    private readonly ConcurrentDictionary<IAsyncSubscription, NatsSubscription> subscriptions;
    private readonly ILogger<NatsBrokerConnectionHolder> logger;
    private bool disposed;

    public NatsBrokerConnectionHolder(
        IOptions<NatsBrokerOptions> options,
        ILogger<NatsBrokerConnectionHolder> logger,
        IConverter converter)
    {
        this.logger = logger;
        this.converter = converter;
        this.connection = this.CreateConnection(options.Value);
        this.subscriptions = new ConcurrentDictionary<IAsyncSubscription, NatsSubscription>();
    }

    public BrokerCapabilities Capabilities => CapabilitiesInstance;

    public Task Publish(Publication publication, CancellationToken cancellation = default)
    {
        var trace = SerializedTrace.GetSerializedTrace(publication.Trace);

        var envelope = new Envelope(publication.Message, trace);
        var payload = this.converter.WriteBytes(envelope);
        this.connection.Publish(publication.Topic.Value, payload);
        return Task.CompletedTask;
    }

    public Task<ISubscription> Subscribe(
        Topic topic,
        Func<Publication, Task> handler,
        SubscriptionGroup? group = null,
        CancellationToken cancellation = default)
    {
        var subscription = this.connection.SubscribeAsync(topic.Value, group?.Value, this.HandleMessage(handler));
        var mappedSubscription = new NatsSubscription(subscription, () => this.subscriptions.TryRemove(subscription, out _));
        this.subscriptions.TryAdd(subscription, mappedSubscription);

        return Task.FromResult<ISubscription>(mappedSubscription);
    }

    private EventHandler<MsgHandlerEventArgs> HandleMessage(Func<Publication, Task> handler)
    {
        return async delegate(object? _, MsgHandlerEventArgs args)
        {
            var subject = args.Message.Subject;
            var topic = new Topic(subject);
            var envelope = this.converter.Read<Envelope>(args.Message.Data);

            if (envelope is null)
            {
                this.logger.LogError("Envelope is null in handler for subject {Subject}", args.Message.Subject);
                throw new SubscriptionHandlerException($"Envelope is null in handler for subject {args.Message.Subject}");
            }

            var message = new Publication(
                topic,
                envelope.Payload,
                Trace: envelope.Trace);

            try
            {
                await handler.Invoke(message).ConfigureAwait(false);
            }
            catch (Exception exc)
            {
                this.logger.LogError("Envelope is null in handler for subject {Subject}", args.Message.Subject);
                throw new SubscriptionHandlerException($"Unable to handle message for subject {args.Message.Subject}", exc);
            }
        };
    }


    private IConnection CreateConnection(NatsBrokerOptions configuration)
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

                this.connection.Dispose();
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
