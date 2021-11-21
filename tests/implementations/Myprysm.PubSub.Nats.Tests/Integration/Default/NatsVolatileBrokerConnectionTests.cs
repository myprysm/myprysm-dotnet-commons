namespace Myprysm.PubSub.Nats.Tests.Integration.Default;

using System.Collections.Generic;
using AutoFixture;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.PubSub.Tests.Integration;
using Myprysm.Testing;
using NUnit.Framework;

[TestFixture]
public class NatsVolatileBrokerConnectionTests : VolatileBrokerConnectionTests
{
    protected override void CustomizeFixture(Fixture fixture)
    {
        fixture.LoadCustomizations(this.GetType().Assembly);
    }

    protected override void Configure(ConfigurationBuilder configuration)
    {
        var config = new Dictionary<string, string>
        {
            [nameof(NatsBrokerOptions.Url)] = "nats://localhost:4222",
        };

        configuration.AddInMemoryCollection(config);
    }

    protected override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        base.ConfigureServices(services, configuration);
            
        services.AddPubSubNats(configuration);
    }
}