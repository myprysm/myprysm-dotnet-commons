namespace Myprysm.PubSub.Abstractions;

/// <summary>
/// Base pub sub options.
///
/// You should extend those options and use the dependency injection extensions if you want to enable tracing
/// </summary>
public class PubSubOptions
{
    /// <summary>
    /// Enable tracing with the broker connection implementation.
    /// </summary>
    /// <remarks>Tracing is enabled by default.</remarks>
    public bool WithTracing { get; set; } = true;

    /// <summary>
    /// Global subscription exception handler used when no specific handler is given for a subscription. 
    /// </summary>
    /// <remarks>
    /// You can configure this handler as a catch-all for any subscription issue.
    /// This handler should not throw any exception.
    /// </remarks>
    public SubscriptionExceptionHandler GlobalSubscriptionExceptionHandler = delegate { };
}
