namespace Myprysm.PubSub.AzureStorageQueue.Tests.Integration;

using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.PubSub.Tests.Integration;
using NUnit.Framework;

[TestFixture]
public class AzureStorageQueuePersistentBrokerConnectionTests : PersistentBrokerConnectionTests
{
    protected override void Configure(ConfigurationBuilder configuration)
    {
        var config = new Dictionary<string, string>
        {
            [nameof(AzureStorageQueueBrokerOptions.ConnectionString)] = "UseDevelopmentStorage=true",
        };

        configuration.AddInMemoryCollection(config);
    }
        
    protected override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        base.ConfigureServices(services, configuration);

        services.AddPubSubAzureStorageQueue(configuration);
    }
}
