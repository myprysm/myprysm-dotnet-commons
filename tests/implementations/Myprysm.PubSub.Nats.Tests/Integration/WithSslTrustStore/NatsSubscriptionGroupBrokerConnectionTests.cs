namespace Myprysm.PubSub.Nats.Tests.Integration.WithSslTrustStore;

using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;

[TestFixture]
public class NatsSubscriptionGroupBrokerConnectionTests : Default.NatsSubscriptionGroupBrokerConnectionTests
{
    protected override void Configure(ConfigurationBuilder configuration)
    {
        var config = new Dictionary<string, string?>
        {
            [nameof(NatsPubSubOptions.Url)] = "nats://localhost:4223",
            [nameof(NatsPubSubOptions.WithSsl)] = "true",
            [nameof(NatsPubSubOptions.KeyStorePath)] = "certificates/nats-ssl-client.p12",
            [nameof(NatsPubSubOptions.KeyStorePassword)] = "changeit",
            [nameof(NatsPubSubOptions.TrustStorePath)] = "certificates/rootCA.p12",
            [nameof(NatsPubSubOptions.TrustStorePassword)] = "changeit",
        };

        configuration.AddInMemoryCollection(config);
    }
}
