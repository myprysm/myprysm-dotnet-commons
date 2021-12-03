namespace Myprysm.PubSub.Abstractions;

/// <summary>
/// Represents a broker connection that can be used to send <see cref="Publication"/> and subscribe to <see cref="Topic"/>.
/// </summary>
public interface IBrokerConnection : IDisposable
{
    /// <summary>
    /// Gets the capabilities supported by the underlying <see cref="IBrokerConnection"/>.
    /// </summary>
    BrokerCapabilities Capabilities { get; }

    /// <summary>
    /// Publish a <see cref="Publication"/>.
    /// </summary>
    /// <param name="publication">The publication to publish.</param>
    /// <param name="cancellation">The cancellation token.</param>
    /// <returns></returns>
    Task Publish(Publication publication, CancellationToken cancellation = default);

    /// <summary>
    /// Subscribe to a given <see cref="Topic"/>
    /// within an optional <see cref="SubscriptionGroup"/>
    /// and with an optional dedicated <see cref="SubscriptionExceptionHandler"/>.
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <param name="topic"></param>
    /// <param name="handler"></param>
    /// <param name="group"></param>
    /// <param name="exceptionHandler"></param>
    /// <param name="cancellation"></param>
    /// <returns></returns>
    Task<ISubscription> Subscribe(
        Topic topic,
        PublicationHandler handler,
        SubscriptionGroup? group = null,
        SubscriptionExceptionHandler? exceptionHandler = null,
        CancellationToken cancellation = default);
}
