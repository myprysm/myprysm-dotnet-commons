namespace Myprysm.PubSub.Abstractions;

public interface IBrokerConnection : IDisposable
{
    BrokerCapabilities Capabilities { get; }

    Task Publish(Publication publication, CancellationToken cancellation = default);

    Task<ISubscription> Subscribe(
        Topic topic,
        IPublicationHandler handler,
        SubscriptionGroup? group = null,
        CancellationToken cancellation = default)
    {
        return this.Subscribe(topic, handler.HandleAsync, group, cancellation);
    }

    Task<ISubscription> Subscribe(
        Topic topic,
        Func<Publication, Task> handler,
        SubscriptionGroup? group = null,
        CancellationToken cancellation = default);
}