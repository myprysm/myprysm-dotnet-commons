namespace Myprysm.FileService.Minio.Tests.Integration;

using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.FileService.Tests.Integration;
using NUnit.Framework;

[TestFixture]
public class MinioFileServiceTests : FileServiceTests
{
    protected override void Configure(ConfigurationBuilder configuration)
    {
        var config = new Dictionary<string, string>
        {
            [nameof(MinioFileServiceOptions.WithTracing)] = "true",
            [nameof(MinioFileServiceOptions.Endpoint)] = "localhost:9001",
            [nameof(MinioFileServiceOptions.AccessKey)] = "integration-minio",
            [nameof(MinioFileServiceOptions.SecretKey)] = "integration-minio-secret",
        };

        configuration.AddInMemoryCollection(config);
    }

    protected override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddMinioFileService(configuration);
    }
}
