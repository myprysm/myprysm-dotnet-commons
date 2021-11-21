namespace Myprysm.FileService.Tests.Integration;

using System.Text;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.FileService.Abstractions;
using Myprysm.FileService.Abstractions.Exceptions;
using Myprysm.Testing;
using NUnit.Framework;

[Category(Categories.Integration)]
public abstract class FileServiceTests : ServiceTests
{
    private const string JsonString = @"{""answer"":42}";
    private const string ContentType = "application/json";

    private static readonly byte[] ContentBytes = Encoding.UTF8.GetBytes(JsonString);
    private static readonly Stream Content = new MemoryStream(ContentBytes);
    private static readonly long ContentLength = Content.Length;
    private static readonly string Container = Guid.NewGuid().ToString();

    private IFileService FileService => this.Services.GetRequiredService<IFileService>();

    [SetUp]
    public void ResetContent()
    {
        Content.Position = 0;
    }

    [Test]
    public async Task CreateContainer_AcceptsContent()
    {
        // Arrange
        var container = this.A<string>();
        await this.FileService.CreateContainer(container);
        var path = $"{this.A<string>()}/{this.A<string>()}";

        // Act
        await this.FileService.UploadFile(container, path, Content, ContentType, ContentLength);
        using var upload = await this.FileService.DownloadFile(container, path);

        // Assert
        using var reader = new StreamReader(upload.Stream, Encoding.UTF8);
        var actual = await reader.ReadToEndAsync();

        actual.Should().Be(JsonString);
    }

    [Test]
    public async Task UploadFileAtRoot_WritesContent()
    {
        // Arrange
        var path = this.A<string>();

        // Act
        await this.FileService.UploadFile(Container, path, Content, ContentType, ContentLength);
        using var upload = await this.FileService.DownloadFile(Container, path);

        // Assert
        using var reader = new StreamReader(upload.Stream, Encoding.UTF8);
        var actual = await reader.ReadToEndAsync();

        actual.Should().Be(JsonString);
    }

    [Test]
    public async Task UploadFile_WritesContent()
    {
        // Arrange
        var path = $"{this.A<string>()}/{this.A<string>()}";

        // Act
        await this.FileService.UploadFile(Container, path, Content, ContentType, ContentLength);
        using var upload = await this.FileService.DownloadFile(Container, path);

        // Assert
        using var reader = new StreamReader(upload.Stream, Encoding.UTF8);
        var actual = await reader.ReadToEndAsync();

        actual.Should().Be(JsonString);
    }

    [Test]
    public async Task UploadFile_WhenPathAlreadyExists_ThrowsFileAlreadyExistsException()
    {
        // Arrange
        var path = $"{this.A<string>()}/{this.A<string>()}";
        await this.FileService.UploadFile(Container, path, Content, ContentType, ContentLength);

        // Act
        var act = this.FileService.Invoking(f => f.UploadFile(Container, path, Content, ContentType, ContentLength));

        // Assert
        await act.Should().ThrowAsync<FileAlreadyExistsException>();
    }

    [Test]
    public async Task UploadFile_WhenPathAlreadyExistsAndOverrideIsAllowed_Succeeds()
    {
        // Arrange
        var path = $"{this.A<string>()}/{this.A<string>()}";
        await this.FileService.UploadFile(Container, path, Content, ContentType, ContentLength);

        var overwrittenContentString = @"{""answer"":3}";
        var overwrittenContent = new MemoryStream(Encoding.UTF8.GetBytes(overwrittenContentString));

        // Act
        await this.FileService.UploadFile(Container, path, overwrittenContent, ContentType, overwrittenContent.Length, true);

        // Assert
        using var upload = await this.FileService.DownloadFile(Container, path);
        using var reader = new StreamReader(upload.Stream, Encoding.UTF8);
        var actual = await reader.ReadToEndAsync();

        actual.Should().Be(overwrittenContentString);
    }

    [Test]
    public async Task DownloadFile_WhenFileDoesNotExist_ThrowsFileNotFoundException()
    {
        // Arrange
        var path = $"{this.A<string>()}/{this.A<string>()}";

        // Act
        var act = this.FileService.Invoking(f => f.DownloadFile(Container, path));

        // Assert
        await act.Should().ThrowAsync<FileNotFoundException>();
    }

    [Test]
    public async Task RemoveFile_WhenFileDoesNotExist_Succeeds()
    {
        // Arrange
        var path = $"{this.A<string>()}/{this.A<string>()}";

        // Act
        var act = this.FileService.Invoking(s => s.RemoveFile(Container, path));

        // Assert
        await act.Should().NotThrowAsync();
    }

    [Test]
    public async Task RemoveFile_WhenFileExists_Succeeds()
    {
        // Arrange
        var path = $"{this.A<string>()}/{this.A<string>()}";
        await this.FileService.UploadFile(Container, path, Content, ContentType, ContentLength);
        await this.FileService.RemoveFile(Container, path);

        // Act
        var act = this.FileService.Invoking(s => s.DownloadFile(Container, path));

        // Assert
        await act.Should().ThrowAsync<FileNotFoundException>();
    }

    [Test]
    public async Task RemoveContainer_WhenContainerContainsFiles_Succeeds()
    {
        // Arrange
        var container = this.A<string>();
        var path = $"{this.A<string>()}/{this.A<string>()}";
        await this.FileService.UploadFile(container, path, Content, ContentType, ContentLength);
        await this.FileService.RemoveContainer(container);

        // Act
        var act = this.FileService.Invoking(s => s.DownloadFile(Container, path));

        // Assert
        await act.Should().ThrowAsync<FileNotFoundException>();
    }
}
