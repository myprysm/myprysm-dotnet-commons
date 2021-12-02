namespace Myprysm.PubSub.Abstractions;

/// <summary>
/// Delegate invoked when an exception is thrown when processing a <see cref="Publication"/> in an <see cref="ISubscription"/>.
/// </summary>
public delegate void SubscriptionExceptionHandler(Exception exception);
