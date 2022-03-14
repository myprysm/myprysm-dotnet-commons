namespace Myprysm.ImageService.ImageSharp.Tests.Integration;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.ImageService.Abstractions.Testing.Integration;
using NUnit.Framework;

[TestFixture]
public class ImageSharpImageServiceTests : ImageServiceTests
{
    protected override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddImageSharpImageService(configuration);
    }
}
