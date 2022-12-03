namespace Myprysm.PubSub.Nats.Tests.Integration.WithPassword;

using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;

[TestFixture]
public class NatsVolatileBrokerConnectionTests : Default.NatsVolatileBrokerConnectionTests
{
    protected override void Configure(ConfigurationBuilder configuration)
    {
        var config = new Dictionary<string, string?>
        {
            [nameof(NatsPubSubOptions.Url)] = "nats://localhost:4224",
            [nameof(NatsPubSubOptions.Password)] = "myprysm-dotnet-commons-integration-password",
            [nameof(NatsPubSubOptions.User)] = "myprysm-dotnet-commons-integration-user",
        };

        configuration.AddInMemoryCollection(config);
    }
}
