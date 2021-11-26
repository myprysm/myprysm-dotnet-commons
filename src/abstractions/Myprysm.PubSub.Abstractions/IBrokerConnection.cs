namespace Myprysm.PubSub.Abstractions;

public interface IBrokerConnection : IDisposable
{
    BrokerCapabilities Capabilities { get; }

    Task Publish(Publication publication, CancellationToken cancellation = default);

    Task<ISubscription> Subscribe(
        Topic topic,
        PublicationHandler handler,
        SubscriptionGroup? group = null,
        SubscriptionExceptionHandler? exceptionHandler = null,
        CancellationToken cancellation = default);
}
