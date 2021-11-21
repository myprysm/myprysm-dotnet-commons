namespace Myprysm.FileService.AzureStorageBlob.Tests.Integration;

using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.FileService.AzureStorageBlob;
using Myprysm.FileService.Tests.Integration;
using NUnit.Framework;

[TestFixture]
public class AzureStorageBlobFileServiceTests : FileServiceTests
{
    protected override void Configure(ConfigurationBuilder configuration)
    {
        var config = new Dictionary<string, string>
        {
            [nameof(AzureStorageBlobFileServiceOptions.ConnectionString)] = "UseDevelopmentStorage=true",
        };

        configuration.AddInMemoryCollection(config);
    }

    protected override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddFileServiceAzureStorageBlob(configuration);
    }
}
