namespace Myprysm.FileService.Minio;

using System.Reactive.Linq;
using global::Minio;
using global::Minio.DataModel;
using global::Minio.Exceptions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Myprysm.FileService.Abstractions;
using Myprysm.FileService.Abstractions.Exceptions;
using Myprysm.FileService.Abstractions.ValueObjects;
using NodaTime;

/// <inheritdoc cref="IFileService"/>
public class MinioFileService : IFileService
{
    private readonly ILogger<MinioFileService> logger;
    private readonly MinioClient client;

    public MinioFileService(
        IOptions<MinioFileServiceOptions> options,
        ILogger<MinioFileService> logger)
    {
        this.logger = logger;
        var config = options.Value;
        var minio = new MinioClient(
            config.Endpoint,
            config.AccessKey,
            config.SecretKey,
            config.Region);

        if (config.WithSsl)
        {
            minio = minio.WithSSL();
        }

        this.client = minio;
    }

    /// <inheritdoc cref="IFileService.UploadFile"/>
    public async Task UploadFile(string container,
        string path,
        Stream content,
        string contentType,
        long contentLength,
        bool overwriteExistingFile = false,
        CancellationToken cancellation = default)
    {
        await this.EnsureBucketExists(container, cancellation).ConfigureAwait(false);

        if (!overwriteExistingFile)
        {
            await this.EnsureObjectDoesNotExist(container, path, cancellation).ConfigureAwait(false);
        }

        await this.client
            .PutObjectAsync(
                container,
                path,
                content,
                contentLength,
                contentType,
                cancellationToken: cancellation)
            .ConfigureAwait(false);
    }

    private async Task EnsureObjectDoesNotExist(
        string container,
        string path,
        CancellationToken cancellation)
    {
        try
        {
            await this.client
                .StatObjectAsync(
                    container,
                    path,
                    cancellationToken: cancellation)
                .ConfigureAwait(false);
        }
        catch (ObjectNotFoundException)
        {
            return;
        }

        throw new FileAlreadyExistsException(container, path);
    }

    private async Task EnsureBucketExists(
        string container,
        CancellationToken cancellation)
    {
        var bucketExists = await this.client
            .BucketExistsAsync(container, cancellation)
            .ConfigureAwait(false);

        if (!bucketExists)
        {
            this.logger.LogInformation("Creating container {Container}", container);
            await this.client
                .MakeBucketAsync(container, cancellationToken: cancellation)
                .ConfigureAwait(false);
        }
    }

    /// <inheritdoc cref="IFileService.DownloadFile"/>
    public async Task<FileDownload> DownloadFile(
        string container,
        string path,
        CancellationToken cancellation = default)
    {
        ObjectStat fileStats;
        try
        {
            fileStats = await this.client
                .StatObjectAsync(
                    container,
                    path,
                    cancellationToken: cancellation)
                .ConfigureAwait(false);
        }
        catch (MinioException)
        {
            throw new FileNotFoundException(container, path);
        }


        var temporaryFile = Path.GetTempFileName();

        await this.client
            .GetObjectAsync(
                container,
                path,
                temporaryFile,
                cancellationToken: cancellation)
            .ConfigureAwait(false);

        var lastModified = Instant.FromDateTimeUtc(DateTime.SpecifyKind(fileStats.LastModified, DateTimeKind.Utc));
        return new MinioFileDownload(
            new FileStream(temporaryFile, FileMode.Open),
            ETag.From(fileStats.ETag),
            lastModified,
            fileStats.Size,
            temporaryFile);
    }

    /// <inheritdoc cref="IFileService.RemoveFile"/>
    public async Task RemoveFile(string container, string path, CancellationToken cancellation = default)
    {
        try
        {
            await this.client
                .StatObjectAsync(container, path, cancellationToken: cancellation)
                .ConfigureAwait(false);
        }
        catch (MinioException)
        {
            return;
        }

        await this.client.RemoveObjectAsync(container, path, cancellation).ConfigureAwait(false);
    }

    public Task CreateContainer(string container, CancellationToken cancellation = default)
    {
        return this.EnsureBucketExists(container, cancellation);
    }

    public async Task RemoveContainer(string container, CancellationToken cancellation = default)
    {
        var bucketExists = await this.client.BucketExistsAsync(container, cancellation).ConfigureAwait(false);

        if (!bucketExists)
        {
            return;
        }

        await this.CleanupAndRemoveContainer(container, cancellation);
    }

    private async Task CleanupAndRemoveContainer(string container, CancellationToken cancellation)
    {
        var _ = await this.client
            .ListObjectsAsync(container, recursive: true, cancellationToken: cancellation)
            .SelectMany(file => Observable.FromAsync(ct => this.client.RemoveObjectAsync(container, file.Key, ct)))
            .LastOrDefaultAsync();


        await this.client.RemoveBucketAsync(container, cancellation).ConfigureAwait(false);
        this.logger.LogInformation("Removed container {Container}", container);
    }
}
