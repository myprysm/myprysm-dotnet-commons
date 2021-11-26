namespace Myprysm.PubSub.Abstractions;

using Myprysm.SharedKernel.ValueObjects;

public class Topic : SingleValueObject<string>
{
    public Topic(string value) : base(value)
    {
    }
}
