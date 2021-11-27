namespace Myprysm.PubSub.Nats.Tests.Integration.Default;

using System.Collections.Generic;
using System.Threading.Tasks;
using AutoFixture;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.PubSub.Abstractions;
using Myprysm.PubSub.Tests.Integration;
using Myprysm.Testing.NUnit;
using NUnit.Framework;

[TestFixture]
public class NatsSubscriptionGroupBrokerConnectionTests : SubscriptionGroupBrokerConnectionTests<NatsPubSubOptions>
{
    protected override void CustomizeFixture(Fixture fixture)
    {
        fixture.LoadCustomizations(this.GetType().Assembly);
    }

    protected override void Configure(ConfigurationBuilder configuration)
    {
        var config = new Dictionary<string, string>
        {
            [nameof(NatsPubSubOptions.Url)] = "nats://localhost:4222",
        };

        configuration.AddInMemoryCollection(config);
    }

    protected override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        base.ConfigureServices(services, configuration);

        services.AddPubSubNats(configuration);
    }

    protected override Task SendNullMessage(Topic topic)
    {
        var connection = this.Services.GetRequiredService<IBrokerConnection>() as NatsBrokerConnection;

        connection?.Connection.Publish(topic.Value, null);
        return Task.CompletedTask;
    }
}
