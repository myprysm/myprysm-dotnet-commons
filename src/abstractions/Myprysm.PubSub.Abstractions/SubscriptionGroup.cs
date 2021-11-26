namespace Myprysm.PubSub.Abstractions;

using Myprysm.SharedKernel.ValueObjects;

public class SubscriptionGroup : SingleValueObject<string>
{
    public SubscriptionGroup(string value) : base(value)
    {
    }
}
