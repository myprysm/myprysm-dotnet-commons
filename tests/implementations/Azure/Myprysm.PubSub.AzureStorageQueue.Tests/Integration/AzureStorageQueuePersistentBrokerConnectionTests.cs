namespace Myprysm.PubSub.AzureStorageQueue.Tests.Integration;

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.PubSub.Abstractions;
using Myprysm.PubSub.Abstractions.Testing.Integration;
using NUnit.Framework;

[TestFixture]
public class AzureStorageQueuePersistentBrokerConnectionTests : PersistentBrokerConnectionTests<AzureStorageQueuePubSubOptions>
{
    protected override void Configure(ConfigurationBuilder configuration)
    {
        var config = new Dictionary<string, string?>
        {
            [nameof(AzureStorageQueuePubSubOptions.ConnectionString)] = "UseDevelopmentStorage=true",
        };

        configuration.AddInMemoryCollection(config);
    }

    protected override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        base.ConfigureServices(services, configuration);

        services.AddPubSubAzureStorageQueue(configuration);
    }

    protected override async Task SendNullMessage(Topic topic)
    {
        var connection = this.Services.GetRequiredService<IBrokerConnection>() as AzureStorageQueueBrokerConnection;

        var client = await connection!.GetClient(topic.Value, CancellationToken.None);

        await client.SendMessageAsync(null);
    }
}
