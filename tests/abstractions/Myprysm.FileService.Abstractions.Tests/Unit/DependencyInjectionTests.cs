namespace Myprysm.FileService.Abstractions.Tests.Unit;

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
        var provider = GetSut(Mock.Of<IFileService>(), true);

        // Act
        var converter = provider.GetRequiredService<IFileService>();

        // Assert
        converter.Should().BeOfType<TracedFileService>();
    }

    [Test]
    public void WithoutTracing()
    {
        // Arrange
        var service = Mock.Of<IFileService>();
        var provider = GetSut(service, false);

        // Act
        var converter = provider.GetRequiredService<IFileService>();

        // Assert
        converter.Should().BeOfType(service.GetType());
    }

    private static IServiceProvider GetSut(IFileService fileService, bool withTracing)
    {
        return new ServiceCollection()
            .TryAddDefaultTracer()
            .Configure<FileServiceOptions>(options => options.WithTracing = withTracing)
            .AddSingleton(sp => sp.CreateFileService<FileServiceOptions>(
                new TracerIdentity("FileService", null),
                _ => fileService))
            .BuildServiceProvider();
    }
}
