namespace Myprysm.ImageService.Abstractions.Tests.Unit;

using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Myprysm.Testing.NUnit;
using Myprysm.Tracing.Abstractions;
using NUnit.Framework;

[TestFixture]
[Category(Categories.Unit)]
public class DependencyInjectionTests
{
    [Test]
    public void WithTracing()
    {
        // Arrange
        var provider = GetSut(Mock.Of<IImageService>(), true);

        // Act
        var converter = provider.GetRequiredService<IImageService>();

        // Assert
        converter.Should().BeOfType<TracedImageService>();
    }

    [Test]
    public void WithoutTracing()
    {
        // Arrange
        var service = Mock.Of<IImageService>();
        var provider = GetSut(service, false);

        // Act
        var converter = provider.GetRequiredService<IImageService>();

        // Assert
        converter.Should().BeOfType(service.GetType());
    }

    private static IServiceProvider GetSut(IImageService fileService, bool withTracing)
    {
        return new ServiceCollection()
            .TryAddDefaultTracer()
            .Configure<ImageServiceOptions>(options => options.WithTracing = withTracing)
            .AddSingleton(sp => sp.CreateImageService<ImageServiceOptions>(
                new TracerIdentity("ImageService", null),
                _ => fileService))
            .BuildServiceProvider();
    }
}
