namespace Myprysm.FileService.Abstractions.Tests.Unit;

using FluentAssertions;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Moq;
using Myprysm.FileService.Abstractions;
using Myprysm.FileService.Abstractions.ValueObjects;
using Myprysm.Testing.NUnit;
using NodaTime;
using NUnit.Framework;

[TestFixture]
[Category(Categories.Unit)]
public class FileServiceHealthCheckTests
{
    private IFileService fileService = null!;

    [SetUp]
    public void SetUp()
    {
        this.fileService = Mock.Of<IFileService>();
    }

    [Test]
    public async Task ShouldReturnHealthy_WhenAllActionsSucceed()
    {
        // Arrange
        var file = new FileDownload(
            new MemoryStream(),
            ETag.All,
            SystemClock.Instance.GetCurrentInstant(),
            0);

        Mock.Get(this.fileService)
            .Setup(s => s.DownloadFile("container", It.IsAny<string>(), CancellationToken.None))
            .ReturnsAsync(file);

        // Act
        var actual = await this.GetSut().CheckHealthAsync(new HealthCheckContext(), CancellationToken.None);

        // Assert
        actual.Status.Should().Be(HealthStatus.Healthy);
    }

    [Test]
    public async Task ShouldReturnUnhealthy_WhenCannotCreateContainer()
    {
        // Arrange
        Mock.Get(this.fileService)
            .Setup(s => s.CreateContainer(It.IsAny<string>(), CancellationToken.None))
            .ThrowsAsync(new Exception("something"));

        // Act
        var actual = await this.GetSut().CheckHealthAsync(new HealthCheckContext(), CancellationToken.None);

        // Assert
        actual.Status.Should().Be(HealthStatus.Unhealthy);
    }

    [Test]
    public async Task ShouldReturnUnhealthy_WhenCannotUploadProbeFile()
    {
        // Arrange
        Mock.Get(this.fileService)
            .Setup(s => s.UploadFile(
                It.IsAny<string>(),
                It.IsAny<string>(),
                It.IsAny<Stream>(),
                It.IsAny<string>(),
                It.IsAny<long>(),
                false,
                CancellationToken.None))
            .ThrowsAsync(new Exception("something"));

        // Act
        var actual = await this.GetSut().CheckHealthAsync(new HealthCheckContext(), CancellationToken.None);

        // Assert
        actual.Status.Should().Be(HealthStatus.Unhealthy);
    }

    [Test]
    public async Task ShouldReturnUnhealthy_WhenCannotDownloadProbeFile()
    {
        // Arrange
        Mock.Get(this.fileService)
            .Setup(s => s.DownloadFile(It.IsAny<string>(), It.IsAny<string>(), CancellationToken.None))
            .ThrowsAsync(new Exception("something"));

        // Act
        var actual = await this.GetSut().CheckHealthAsync(new HealthCheckContext(), CancellationToken.None);

        // Assert
        actual.Status.Should().Be(HealthStatus.Unhealthy);
    }

    [Test]
    public async Task ShouldReturnUnhealthy_WhenCannotRemoveProbeFile()
    {
        // Arrange
        var file = new FileDownload(
            new MemoryStream(),
            ETag.All,
            SystemClock.Instance.GetCurrentInstant(),
            0);

        Mock.Get(this.fileService)
            .Setup(s => s.DownloadFile("container", It.IsAny<string>(), CancellationToken.None))
            .ReturnsAsync(file);

        Mock.Get(this.fileService)
            .Setup(s => s.RemoveFile(It.IsAny<string>(), It.IsAny<string>(), CancellationToken.None))
            .ThrowsAsync(new Exception("something"));

        // Act
        var actual = await this.GetSut().CheckHealthAsync(new HealthCheckContext(), CancellationToken.None);

        // Assert
        actual.Status.Should().Be(HealthStatus.Unhealthy);
    }

    private FileServiceHealthCheck GetSut()
    {
        return new FileServiceHealthCheck(this.fileService, "container");
    }
}
