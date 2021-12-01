namespace Myprysm.FileService.Abstractions.Tests.Unit;

using System.Globalization;
using FluentAssertions;
using Moq;
using Myprysm.FileService.Abstractions;
using Myprysm.FileService.Abstractions.Exceptions;
using Myprysm.Testing.NUnit;
using Myprysm.Tracing.Abstractions;
using NUnit.Framework;

[TestFixture]
[Category(Categories.Unit)]
public class TracedFileServiceTests : FixtureTests
{
    [Test]
    public async Task UploadFile_TagsParameters()
    {
        // Arrange
        var serviceMock = new Mock<IFileService>();
        var (fileService, collector) = GetSut(serviceMock.Object);
        var container = this.A<string>();
        var path = this.A<string>();
        await using var content = new MemoryStream();
        var contentType = this.A<string>();
        var contentLength = this.A<long>();
        var overwriteExistingFile = this.A<bool>();

        // Act
        await fileService.UploadFile(
            container,
            path,
            content,
            contentType,
            contentLength,
            overwriteExistingFile);

        // Assert
        collector.Traces.Should().HaveCount(1);
        var trace = collector.Traces.First();

        trace.Name.Should().Be(nameof(IFileService.UploadFile));
        trace.Tags.Should()
            .Contain(
                new KeyValuePair<string, string?>("file_service.container", container),
                new KeyValuePair<string, string?>("file_service.path", path),
                new KeyValuePair<string, string?>("file_service.content_type", contentType),
                new KeyValuePair<string, string?>("file_service.content_length", contentLength.ToString(CultureInfo.InvariantCulture)),
                new KeyValuePair<string, string?>("file_service.overwrite_existing_file", overwriteExistingFile.ToString(CultureInfo.InvariantCulture)));
    }

    [Test]
    public async Task UploadFile_WhenFileAlreadyExistsException_LogsFileAlreadyExistError()
    {
        // Arrange
        var serviceMock = new Mock<IFileService>();
        var (fileService, collector) = GetSut(serviceMock.Object);
        var container = this.A<string>();
        var path = this.A<string>();
        await using var content = new MemoryStream();
        var contentType = this.A<string>();
        var contentLength = this.A<long>();
        var overwriteExistingFile = this.A<bool>();
        var message = $"{container}/{path}";
        serviceMock.Setup(s => s.UploadFile(
                container,
                path,
                content,
                contentType,
                contentLength,
                overwriteExistingFile,
                It.IsAny<CancellationToken>()))
            .ThrowsAsync(new FileAlreadyExistsException(container, path));

        // Act
        var actual = () => fileService.UploadFile(
            container,
            path,
            content,
            contentType,
            contentLength,
            overwriteExistingFile);

        // Assert
        await actual.Should().ThrowAsync<FileAlreadyExistsException>().WithMessage(message);
        collector.Traces.Should().HaveCount(1);
        var trace = collector.Traces.First();

        trace.Tags.Should()
            .Contain(
                new KeyValuePair<string, string?>("otel.status_code", "ERROR"),
                new KeyValuePair<string, string?>("otel.status_description", $"File already exists: {message}"));
    }

    [Test]
    public async Task UploadFile_WhenOtherException_LogsUnhandledError()
    {
        // Arrange
        var message = "A message";
        var serviceMock = new Mock<IFileService>();
        var (fileService, collector) = GetSut(serviceMock.Object);
        var container = this.A<string>();
        var path = this.A<string>();
        await using var content = new MemoryStream();
        var contentType = this.A<string>();
        var contentLength = this.A<long>();
        var overwriteExistingFile = this.A<bool>();
        serviceMock.Setup(s => s.UploadFile(
                container,
                path,
                content,
                contentType,
                contentLength,
                overwriteExistingFile,
                It.IsAny<CancellationToken>()))
            .ThrowsAsync(new Exception(message));

        // Act
        var actual = () => fileService.UploadFile(
            container,
            path,
            content,
            contentType,
            contentLength,
            overwriteExistingFile);

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
    public async Task DownloadFile_TagsParameters()
    {
        // Arrange
        var serviceMock = new Mock<IFileService>();
        var (fileService, collector) = GetSut(serviceMock.Object);
        var container = this.A<string>();
        var path = this.A<string>();

        // Act
        await fileService.DownloadFile(
            container,
            path);

        // Assert
        collector.Traces.Should().HaveCount(1);
        var trace = collector.Traces.First();

        trace.Name.Should().Be(nameof(IFileService.DownloadFile));
        trace.Tags.Should()
            .Contain(
                new KeyValuePair<string, string?>("file_service.container", container),
                new KeyValuePair<string, string?>("file_service.path", path));
    }

    [Test]
    public async Task DownloadFile_WhenFileNotFoundException_LogsFileFileNotFoundError()
    {
        // Arrange
        var serviceMock = new Mock<IFileService>();
        var (fileService, collector) = GetSut(serviceMock.Object);
        var container = this.A<string>();
        var path = this.A<string>();
        var message = $"{container}/{path}";
        serviceMock.Setup(s => s.DownloadFile(
                container,
                path,
                It.IsAny<CancellationToken>()))
            .ThrowsAsync(new FileNotFoundException(container, path));

        // Act
        var actual = () => fileService.DownloadFile(container, path);

        // Assert
        await actual.Should().ThrowAsync<FileNotFoundException>().WithMessage(message);
        collector.Traces.Should().HaveCount(1);
        var trace = collector.Traces.First();

        trace.Tags.Should()
            .Contain(
                new KeyValuePair<string, string?>("otel.status_code", "ERROR"),
                new KeyValuePair<string, string?>("otel.status_description", $"File not found: {message}"));
    }

    [Test]
    public async Task DownloadFile_WhenOtherException_LogsUnhandledError()
    {
        // Arrange
        var message = "A message";
        var serviceMock = new Mock<IFileService>();
        var (fileService, collector) = GetSut(serviceMock.Object);
        var container = this.A<string>();
        var path = this.A<string>();
        serviceMock.Setup(s => s.DownloadFile(
                container,
                path,
                It.IsAny<CancellationToken>()))
            .ThrowsAsync(new Exception(message));

        // Act
        var actual = () => fileService.DownloadFile(container, path);

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
    public async Task RemoveFile_TagsParameters()
    {
        // Arrange
        var serviceMock = new Mock<IFileService>();
        var (fileService, collector) = GetSut(serviceMock.Object);
        var container = this.A<string>();
        var path = this.A<string>();

        // Act
        await fileService.RemoveFile(
            container,
            path);

        // Assert
        collector.Traces.Should().HaveCount(1);
        var trace = collector.Traces.First();

        trace.Name.Should().Be(nameof(IFileService.RemoveFile));
        trace.Tags.Should()
            .Contain(
                new KeyValuePair<string, string?>("file_service.container", container),
                new KeyValuePair<string, string?>("file_service.path", path));
    }

    [Test]
    public async Task RemoveFile_WhenOtherException_LogsUnhandledError()
    {
        // Arrange
        var message = "A message";
        var serviceMock = new Mock<IFileService>();
        var (fileService, collector) = GetSut(serviceMock.Object);
        var container = this.A<string>();
        var path = this.A<string>();
        serviceMock.Setup(s => s.RemoveFile(
                container,
                path,
                It.IsAny<CancellationToken>()))
            .ThrowsAsync(new Exception(message));

        // Act
        var actual = () => fileService.RemoveFile(container, path);

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
    public async Task CreateContainer_TagsParameters()
    {
        // Arrange
        var serviceMock = new Mock<IFileService>();
        var (fileService, collector) = GetSut(serviceMock.Object);
        var container = this.A<string>();

        // Act
        await fileService.CreateContainer(container);

        // Assert
        collector.Traces.Should().HaveCount(1);
        var trace = collector.Traces.First();

        trace.Name.Should().Be(nameof(IFileService.CreateContainer));
        trace.Tags.Should()
            .Contain(
                new KeyValuePair<string, string?>("file_service.container", container));
    }

    [Test]
    public async Task CreateContainer_WhenOtherException_LogsUnhandledError()
    {
        // Arrange
        var message = "A message";
        var serviceMock = new Mock<IFileService>();
        var (fileService, collector) = GetSut(serviceMock.Object);
        var container = this.A<string>();
        serviceMock.Setup(s => s.CreateContainer(
                container,
                It.IsAny<CancellationToken>()))
            .ThrowsAsync(new Exception(message));

        // Act
        var actual = () => fileService.CreateContainer(container);

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
    public async Task RemoveContainer_TagsParameters()
    {
        // Arrange
        var serviceMock = new Mock<IFileService>();
        var (fileService, collector) = GetSut(serviceMock.Object);
        var container = this.A<string>();

        // Act
        await fileService.RemoveContainer(container);

        // Assert
        collector.Traces.Should().HaveCount(1);
        var trace = collector.Traces.First();

        trace.Name.Should().Be(nameof(IFileService.RemoveContainer));
        trace.Tags.Should()
            .Contain(
                new KeyValuePair<string, string?>("file_service.container", container));
    }

    [Test]
    public async Task RemoveContainer_WhenOtherException_LogsUnhandledError()
    {
        // Arrange
        var message = "A message";
        var serviceMock = new Mock<IFileService>();
        var (fileService, collector) = GetSut(serviceMock.Object);
        var container = this.A<string>();
        serviceMock.Setup(s => s.RemoveContainer(
                container,
                It.IsAny<CancellationToken>()))
            .ThrowsAsync(new Exception(message));

        // Act
        var actual = () => fileService.RemoveContainer(container);

        // Assert
        await actual.Should().ThrowAsync<Exception>().WithMessage(message);
        collector.Traces.Should().HaveCount(1);
        var trace = collector.Traces.First();

        trace.Tags.Should()
            .Contain(
                new KeyValuePair<string, string?>("otel.status_code", "ERROR"),
                new KeyValuePair<string, string?>("otel.status_description", $"Unhandled exception: {message}"));
    }

    private static (TracedFileService fileService, CollectorTracer tracer) GetSut(IFileService @delegate)
    {
        var tracer = new DefaultTracer(new TracerIdentity("TracedFileService", null));
        var collector = new CollectorTracer(tracer);
        var fileService = new TracedFileService(@delegate, collector);

        return (fileService, collector);
    }
}
