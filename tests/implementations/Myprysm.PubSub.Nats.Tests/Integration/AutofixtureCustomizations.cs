namespace Myprysm.PubSub.Nats.Tests.Integration;

using AutoFixture;
using Myprysm.PubSub.Abstractions;

public class AutofixtureCustomizations : ICustomization
{
    public void Customize(IFixture fixture)
    {
        fixture.Register(() => new Topic(fixture.Create<string>().Replace("-", ".")));
        fixture.Register(() => new SubscriptionGroup(fixture.Create<string>().Replace("-", ".")));
    }
}
