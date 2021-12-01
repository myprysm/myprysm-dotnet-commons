namespace Myprysm.ImageService.Abstractions.Tests.Unit;

using System.Globalization;
using FluentAssertions;
using Moq;
using Myprysm.ImageService.Abstractions.Exceptions;
using Myprysm.Testing.NUnit;
using Myprysm.Tracing.Abstractions;
using NUnit.Framework;

[TestFixture]
[Category(Categories.Unit)]
public class TracedImageServiceTests : FixtureTests
{
    [Test]
    public async Task GetMetadataAsync_WhenImageProcessingException_LogsImageAlreadyExistError()
    {
        // Arrange
        var serviceMock = new Mock<IImageService>();
        var (imageService, collector) = GetSut(serviceMock.Object);
        await using var content = new MemoryStream();
        var message = $"A message";
        serviceMock.Setup(s => s.GetMetadataAsync(
                content,
                It.IsAny<CancellationToken>()))
            .ThrowsAsync(new ImageProcessingException(message, new Exception("something")));

        // Act
        var actual = () => imageService.GetMetadataAsync(content);

        // Assert
        await actual.Should().ThrowAsync<ImageProcessingException>().WithMessage(message);
        collector.Traces.Should().HaveCount(1);
        var trace = collector.Traces.First();

        trace.Tags.Should()
            .Contain(
                new KeyValuePair<string, string?>("otel.status_code", "ERROR"),
                new KeyValuePair<string, string?>("otel.status_description", $"Image processing exception: {message}"));
    }

    [Test]
    public async Task GetMetadataAsync_WhenOtherException_LogsUnhandledError()
    {
        // Arrange
        var serviceMock = new Mock<IImageService>();
        var (imageService, collector) = GetSut(serviceMock.Object);
        await using var content = new MemoryStream();
        var message = $"A message";
        serviceMock.Setup(s => s.GetMetadataAsync(
                content,
                It.IsAny<CancellationToken>()))
            .ThrowsAsync(new Exception(message));

        // Act
        var actual = () => imageService.GetMetadataAsync(content);

        // Assert
        await actual.Should().ThrowAsync<Exception>().WithMessage(message);
        collector.Traces.Should().HaveCount(1);
        var trace = collector.Traces.First();

        trace.Tags.Should()
            .Contain(
                new KeyValuePair<string, string?>("otel.status_code", "ERROR"),
                new KeyValuePair<string, string?>("otel.status_description", $"Unhandled exception: {message}"));
    }

    [Test]
    public async Task CropAsync_TagsParameters()
    {
        // Arrange
        var serviceMock = new Mock<IImageService>();
        var (imageService, collector) = GetSut(serviceMock.Object);
        await using var content = new MemoryStream();
        var cropArea = this.A<Rectangle>();
        var format = this.A<ImageFormat>();

        // Act
        _ = await imageService.CropAsync(content, cropArea, format);

        // Assert
        collector.Traces.Should().HaveCount(1);
        var trace = collector.Traces.First();

        trace.Tags.Should()
            .Contain(
                new KeyValuePair<string, string?>("image_service.crop_area.x", cropArea.Point.X.ToString(CultureInfo.InvariantCulture)),
                new KeyValuePair<string, string?>("image_service.crop_area.y", cropArea.Point.Y.ToString(CultureInfo.InvariantCulture)),
                new KeyValuePair<string, string?>("image_service.crop_area.width", cropArea.Size.Width.ToString(CultureInfo.InvariantCulture)),
                new KeyValuePair<string, string?>("image_service.crop_area.height", cropArea.Size.Height.ToString(CultureInfo.InvariantCulture)),
                new KeyValuePair<string, string?>("image_service.format", format.ToString()));
    }

    [Test]
    public async Task CropAsync_WhenImageProcessingException_LogsImageAlreadyExistError()
    {
        // Arrange
        var serviceMock = new Mock<IImageService>();
        var (imageService, collector) = GetSut(serviceMock.Object);
        await using var content = new MemoryStream();
        var message = $"A message";
        var cropArea = this.A<Rectangle>();
        var format = this.A<ImageFormat>();
        serviceMock.Setup(s => s.CropAsync(
                content,
                cropArea,
                format,
                It.IsAny<CancellationToken>()))
            .ThrowsAsync(new ImageProcessingException(message, new Exception("something")));

        // Act
        var actual = () => imageService.CropAsync(content, cropArea, format);

        // Assert
        await actual.Should().ThrowAsync<ImageProcessingException>().WithMessage(message);
        collector.Traces.Should().HaveCount(1);
        var trace = collector.Traces.First();

        trace.Tags.Should()
            .Contain(
                new KeyValuePair<string, string?>("otel.status_code", "ERROR"),
                new KeyValuePair<string, string?>("otel.status_description", $"Image processing exception: {message}"));
    }

    [Test]
    public async Task CropAsync_WhenOtherException_LogsUnhandledError()
    {
        // Arrange
        var serviceMock = new Mock<IImageService>();
        var (imageService, collector) = GetSut(serviceMock.Object);
        await using var content = new MemoryStream();
        var message = $"A message";
        var cropArea = this.A<Rectangle>();
        var format = this.A<ImageFormat>();
        serviceMock.Setup(s => s.CropAsync(
                content,
                cropArea,
                format,
                It.IsAny<CancellationToken>()))
            .ThrowsAsync(new Exception(message));

        // Act
        var actual = () => imageService.CropAsync(content, cropArea, format);

        // Assert
        await actual.Should().ThrowAsync<Exception>().WithMessage(message);
        collector.Traces.Should().HaveCount(1);
        var trace = collector.Traces.First();

        trace.Tags.Should()
            .Contain(
                new KeyValuePair<string, string?>("otel.status_code", "ERROR"),
                new KeyValuePair<string, string?>("otel.status_description", $"Unhandled exception: {message}"));
    }

    [Test]
    public async Task ResizeAsync_TagsParameters()
    {
        // Arrange
        var serviceMock = new Mock<IImageService>();
        var (imageService, collector) = GetSut(serviceMock.Object);
        await using var content = new MemoryStream();
        var size = this.A<Size>();
        var format = this.A<ImageFormat>();

        // Act
        _ = await imageService.ResizeAsync(content, size, format);

        // Assert
        collector.Traces.Should().HaveCount(1);
        var trace = collector.Traces.First();

        trace.Tags.Should()
            .Contain(
                new KeyValuePair<string, string?>("image_service.size.width", size.Width.ToString(CultureInfo.InvariantCulture)),
                new KeyValuePair<string, string?>("image_service.size.height", size.Height.ToString(CultureInfo.InvariantCulture)),
                new KeyValuePair<string, string?>("image_service.format", format.ToString()));
    }

    [Test]
    public async Task ResizeAsync_WhenImageProcessingException_LogsImageAlreadyExistError()
    {
        // Arrange
        var serviceMock = new Mock<IImageService>();
        var (imageService, collector) = GetSut(serviceMock.Object);
        await using var content = new MemoryStream();
        var message = $"A message";
        var size = this.A<Size>();
        var format = this.A<ImageFormat>();
        serviceMock.Setup(s => s.ResizeAsync(
                content,
                size,
                format,
                It.IsAny<CancellationToken>()))
            .ThrowsAsync(new ImageProcessingException(message, new Exception("something")));

        // Act
        var actual = () => imageService.ResizeAsync(content, size, format);

        // Assert
        await actual.Should().ThrowAsync<ImageProcessingException>().WithMessage(message);
        collector.Traces.Should().HaveCount(1);
        var trace = collector.Traces.First();

        trace.Tags.Should()
            .Contain(
                new KeyValuePair<string, string?>("otel.status_code", "ERROR"),
                new KeyValuePair<string, string?>("otel.status_description", $"Image processing exception: {message}"));
    }

    [Test]
    public async Task ResizeAsync_WhenOtherException_LogsUnhandledError()
    {
        // Arrange
        var serviceMock = new Mock<IImageService>();
        var (imageService, collector) = GetSut(serviceMock.Object);
        await using var content = new MemoryStream();
        var message = $"A message";
        var size = this.A<Size>();
        var format = this.A<ImageFormat>();
        serviceMock.Setup(s => s.ResizeAsync(
                content,
                size,
                format,
                It.IsAny<CancellationToken>()))
            .ThrowsAsync(new Exception(message));

        // Act
        var actual = () => imageService.ResizeAsync(content, size, format);

        // Assert
        await actual.Should().ThrowAsync<Exception>().WithMessage(message);
        collector.Traces.Should().HaveCount(1);
        var trace = collector.Traces.First();

        trace.Tags.Should()
            .Contain(
                new KeyValuePair<string, string?>("otel.status_code", "ERROR"),
                new KeyValuePair<string, string?>("otel.status_description", $"Unhandled exception: {message}"));
    }

    private static (TracedImageService fileService, CollectorTracer tracer) GetSut(IImageService @delegate)
    {
        var tracer = new DefaultTracer(new TracerIdentity("TracedImageService", null));
        var collector = new CollectorTracer(tracer);
        var fileService = new TracedImageService(@delegate, collector);

        return (fileService, collector);
    }
}
