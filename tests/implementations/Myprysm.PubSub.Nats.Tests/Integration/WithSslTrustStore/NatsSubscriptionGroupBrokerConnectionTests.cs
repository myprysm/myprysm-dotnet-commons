namespace Myprysm.PubSub.Nats.Tests.Integration.WithSslTrustStore;

using System.Collections.Generic;
using AutoFixture;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.PubSub.Tests.Integration;
using Myprysm.Testing;
using NUnit.Framework;

[TestFixture]
public class NatsSubscriptionGroupBrokerConnectionTests : SubscriptionGroupBrokerConnectionTests
{
    protected override void CustomizeFixture(Fixture fixture)
    {
        fixture.LoadCustomizations(this.GetType().Assembly);
    }

    protected override void Configure(ConfigurationBuilder configuration)
    {
        var config = new Dictionary<string, string>
        {
            [nameof(NatsBrokerOptions.Url)] = "nats://localhost:4223",
            [nameof(NatsBrokerOptions.WithSsl)] = "true",
            [nameof(NatsBrokerOptions.KeyStorePath)] = "certificates/nats-ssl-client.p12",
            [nameof(NatsBrokerOptions.KeyStorePassword)] = "changeit",
            [nameof(NatsBrokerOptions.TrustStorePath)] = "certificates/rootCA.p12",
            [nameof(NatsBrokerOptions.TrustStorePassword)] = "changeit",
        };

        configuration.AddInMemoryCollection(config);
    }
        
    protected override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        base.ConfigureServices(services, configuration);

        services.AddPubSubNats(configuration);
    }
}