namespace Myprysm.PubSub.Abstractions;

using Myprysm.SharedKernel.ValueObjects;

/// <summary>
/// Represents a subscription group that can be use to load balance publication across subscriptions within the group.
/// Also known as competing consumer pattern. 
/// </summary>
public class SubscriptionGroup : SingleValueObject<string>
{
    /// <summary>
    /// Creates a new <see cref="SubscriptionGroup"/>
    /// </summary>
    /// <param name="value">The value of the subscription group.</param>
    public SubscriptionGroup(string value) : base(value)
    {
    }
}
