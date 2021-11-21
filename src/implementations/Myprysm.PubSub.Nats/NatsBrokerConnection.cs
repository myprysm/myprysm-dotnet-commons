namespace Myprysm.PubSub.Nats;

using System;
using System.Threading;
using System.Threading.Tasks;
using Myprysm.PubSub.Abstractions;
using Myprysm.Tracing.Abstractions;

public class NatsBrokerConnection : IBrokerConnection
{
    private readonly ITracer tracer;
    private readonly NatsBrokerConnectionHolder connectionHolder;

    public NatsBrokerConnection(
        ITracerFactory tracerFactory,
        NatsBrokerConnectionHolder connectionHolder)
    {
        this.tracer = tracerFactory.GetTracer(PubSubNatsConstants.TracerIdentity);
        this.connectionHolder = connectionHolder;
    }

    public BrokerCapabilities Capabilities => this.connectionHolder.Capabilities;

    public Task Publish(Publication publication, CancellationToken cancellationToken)
    {
        var tracedPublication = this.WrapTraceIfNotProvided(publication);

        return this.connectionHolder.Publish(tracedPublication, cancellationToken);
    }

    private Publication WrapTraceIfNotProvided(Publication publication)
    {
        if (publication.Trace is not null || this.tracer.CurrentTrace is null)
        {
            return publication;
        }

        return new Publication(
            publication.Topic,
            publication.Message,
            publication.IsVolatile,
            this.tracer.CurrentTrace);
    }

    public Task<ISubscription> Subscribe(
        Topic topic,
        Func<Publication, Task> handler,
        SubscriptionGroup? group = null,
        CancellationToken cancellation = default)
    {
        return this.connectionHolder.Subscribe(topic, this.HandleMessage(handler), group, cancellation);
    }

    private Func<Publication, Task> HandleMessage(Func<Publication, Task> handler)
    {
        return async publication =>
        {
            using var trace = this.tracer.StartTrace(nameof(this.HandleMessage), TraceKind.Consumer, publication.Trace);
            var tracedPublication = new Publication(
                publication.Topic,
                publication.Message,
                publication.IsVolatile,
                trace);

            await handler(tracedPublication).ConfigureAwait(false);
        };
    }

    public void Dispose()
    {
        // Do Nothing
    }
}