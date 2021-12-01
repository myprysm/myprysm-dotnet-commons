namespace Myprysm.FileService.Abstractions.Testing.Integration;

using System.Text;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.FileService.Abstractions;
using Myprysm.FileService.Abstractions.Exceptions;
using Myprysm.Testing.NUnit;
using NUnit.Framework;

/// <summary>
/// Base test suite for <see cref="IFileService"/>.
/// </summary>
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

    /// <summary>
    /// Resets the position of the content used in the tests.
    /// </summary>
    [SetUp]
    public void ResetContent()
    {
        Content.Position = 0;
    }

    /// <summary>
    /// You should ensure that given a container
    /// When a file is uploaded to this container at a random path
    /// And the file is downloaded from this container at this random path
    /// Then the downloaded content is the same as the uploaded content.
    /// </summary>
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

    /// <summary>
    /// You should ensure that given a container
    /// When this file is uploaded to the root of this container
    /// And the file is downloaded from the root of this container
    /// Then the downloaded content is the same as the uploaded content.
    /// </summary>
    /// <remarks>The container may or may not exist yet. The operation should succeed either way.</remarks>
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

    /// <summary>
    /// You should ensure that given a file at a random path
    /// When this file is uploaded to this random path
    /// And the file is downloaded from this container at this random path
    /// Then the downloaded content is the same as the uploaded content.
    /// </summary>
    /// <remarks>The container may or may not exist yet. The operation should succeed either way.</remarks>
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

    /// <summary>
    /// You should ensure that given a container
    /// When a file is uploaded to this container at a random path
    /// And another file is uploaded at this random path with the overwrite option disabled
    /// Then the operation results in a <see cref="FileAlreadyExistsException"/>.
    /// </summary>
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

    /// <summary>
    /// You should ensure that given a container
    /// When a file is uploaded to this container at a random path
    /// And another file is uploaded at this random path with the overwrite option enabled
    /// And the file is downloaded from this container at this random path
    /// Then the downloaded content is the same as the overwriting content.
    /// </summary>
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

    /// <summary>
    /// You should ensure that given a container
    /// When a non existing file is downloaded
    /// Then the operation results in a <see cref="FileNotFoundException"/>.
    /// </summary>
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

    /// <summary>
    /// You should ensure that given a container
    /// When a non existing file is deleted
    /// Then the operation should succeed.
    /// </summary>
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

    /// <summary>
    /// You should ensure that given a container
    /// When a file is uploaded to this container at a random path
    /// And the file is deleted
    /// And the file is downloaded from this container at this random path
    /// Then the operation results in a <see cref="FileNotFoundException"/>.
    /// </summary>
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

    /// <summary>
    /// You should ensure that given a container
    /// When a file is uploaded to this container at a random path
    /// And the container is deleted
    /// And the file is downloaded from this container at this random path
    /// Then the operation results in a <see cref="FileNotFoundException"/>.
    /// </summary>
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
