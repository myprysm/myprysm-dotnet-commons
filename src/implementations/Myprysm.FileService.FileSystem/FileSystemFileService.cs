namespace Myprysm.FileService.FileSystem;

using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Options;
using Myprysm.FileService.Abstractions;
using Myprysm.FileService.Abstractions.Exceptions;
using Myprysm.FileService.Abstractions.ValueObjects;
using Myprysm.SharedKernel.Exceptions;
using NodaTime;

public class FileSystemFileService : IFileService
{
    private readonly DirectoryInfo rootDirectory;

    public FileSystemFileService(IOptions<FileSystemFileServiceOptions> options)
    {
        this.rootDirectory = new DirectoryInfo(options.Value.Directory);
        this.EnsureRoot(options);
    }

    [ExcludeFromCodeCoverage(Justification = "Cannot cover with test")]
    private void EnsureRoot(IOptions<FileSystemFileServiceOptions> options)
    {
        if (!this.rootDirectory.Exists)
        {
            throw new NotFoundException($"Directory '{options.Value.Directory}' does not exist.");
        }
    }

    public async Task UploadFile(
        string container,
        string path,
        Stream content,
        string contentType,
        long contentLength,
        bool overwriteExistingFile = false,
        CancellationToken cancellation = default)
    {
        this.EnsureContainerExists(container);

        if (!overwriteExistingFile)
        {
            this.EnsureFileDoesNotExist(container, path);
        }

        this.EnsureBasePathExist(container, path);
        await this.WriteContent(container, path, content, contentLength, cancellation).ConfigureAwait(false);
    }

    private async Task WriteContent(string container, string path, Stream content, long contentLength, CancellationToken cancellation)
    {
        var fileInfo = this.GetFileInfo(container, path);

        await using var fileStream = fileInfo.OpenWrite();
        await content.CopyToAsync(fileStream, cancellation).ConfigureAwait(false);
        fileStream.SetLength(contentLength);
    }

    private void EnsureBasePathExist(string container, string path)
    {
        var directories = path.Split('/').SkipLast(1).ToList();

        if (!directories.Any())
        {
            return;
        }

        var root = this.rootDirectory.GetDirectories().First(d => d.Name == container);

        foreach (var dir in directories)
        {
            var subDirectory = root.GetDirectories().FirstOrDefault(d => d.Name == dir);
            if (subDirectory is null || !subDirectory.Exists)
            {
                subDirectory = root.CreateSubdirectory(dir);
            }

            root = subDirectory;
        }
    }

    private void EnsureFileDoesNotExist(string container, string path)
    {
        var fileInfo = this.GetFileInfo(container, path);

        if (fileInfo.Exists)
        {
            throw new FileAlreadyExistsException(container, path);
        }
    }

    private void EnsureContainerExists(string container)
    {
        if (this.rootDirectory.GetDirectories().All(d => d.Name != container))
        {
            this.rootDirectory.CreateSubdirectory(container);
        }
    }

    private FileInfo GetFileInfo(string container, string path)
    {
        var filePath = Path.Join(this.rootDirectory.FullName, container, path);
        return new FileInfo(filePath);
    }

    public Task<FileDownload> DownloadFile(string container, string path, CancellationToken cancellation = default)
    {
        var fileInfo = new FileInfo(Path.Join(this.rootDirectory.FullName, container, path));

        if (!fileInfo.Exists)
        {
            throw new FileNotFoundException(container, path);
        }

        var fileStream = fileInfo.OpenRead();
        var fileDownload = new FileDownload(
            fileStream,
            ETag.From(fileInfo.LastWriteTimeUtc.Ticks.ToString()),
            Instant.FromDateTimeUtc(fileInfo.LastWriteTimeUtc),
            fileInfo.Length);

        return Task.FromResult(fileDownload);
    }

    /// <inheritdoc cref="IFileService.RemoveFile"/>
    public Task RemoveFile(string container, string path, CancellationToken cancellation = default)
    {
        var fileInfo = new FileInfo(Path.Join(this.rootDirectory.FullName, container, path));
        if (fileInfo.Exists)
        {
            fileInfo.Delete();
        }

        return Task.CompletedTask;
    }

    /// <inheritdoc cref="IFileService.CreateContainer"/>
    public Task CreateContainer(string container, CancellationToken cancellation = default)
    {
        this.EnsureContainerExists(container);
        return Task.CompletedTask;
    }

    /// <inheritdoc cref="IFileService.RemoveContainer"/>
    public Task RemoveContainer(string container, CancellationToken cancellation = default)
    {
        var directoryInfo = new DirectoryInfo(Path.Join(this.rootDirectory.FullName, container));

        if (directoryInfo.Exists)
        {
            directoryInfo.Delete(true);
        }

        return Task.CompletedTask;
    }
}
