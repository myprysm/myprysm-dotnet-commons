namespace Myprysm.ImageService.ImageSharp.Tests.Integration;

using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.ImageService.Abstractions.Testing.Integration;
using NUnit.Framework;

[TestFixture]
public class ImageSharpImageServiceTests : ImageServiceTests
{
    protected override void Configure(ConfigurationBuilder configuration)
    {
        var config = new Dictionary<string, string>
        {
            [nameof(ImageSharpImageServiceOptions.MemoryPoolKind)] = "Medium",
        };

        configuration.AddInMemoryCollection(config);
    }
    protected override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddImageSharpImageService(configuration);
    }
}
