namespace Myprysm.PubSub.Nats.Tests.Integration.WithSslTrustAll;

using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;

[TestFixture]
public class NatsVolatileBrokerConnectionTests : Default.NatsVolatileBrokerConnectionTests
{
    protected override void Configure(ConfigurationBuilder configuration)
    {
        var config = new Dictionary<string, string>
        {
            [nameof(NatsPubSubOptions.Url)] = "nats://localhost:4223",
            [nameof(NatsPubSubOptions.WithSsl)] = "true",
            [nameof(NatsPubSubOptions.TrustAllCertificates)] = "true",
            [nameof(NatsPubSubOptions.KeyStorePath)] = "certificates/nats-ssl-client.p12",
            [nameof(NatsPubSubOptions.KeyStorePassword)] = "changeit",
        };

        configuration.AddInMemoryCollection(config);
    }
}
