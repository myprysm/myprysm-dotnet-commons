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

/// <summary>
/// Manages files with a remote MinIO/S3 instance.
/// </summary>
public class MinioFileService : IFileService
{
    private readonly ILogger<MinioFileService> logger;
    private readonly MinioClient client;

    /// <summary>
    /// Creates a new <see cref="MinioFileService"/> with the given options an logger.
    /// </summary>
    /// <param name="options">The options.</param>
    /// <param name="logger">The logger.</param>
    public MinioFileService(
        IOptions<MinioFileServiceOptions> options,
        ILogger<MinioFileService> logger)
    {
        this.logger = logger;
        var config = options.Value;


        var minio = new MinioClient()
            .WithEndpoint(config.Endpoint)
            .WithCredentials(config.AccessKey, config.SecretKey)
            .WithRegion(config.Region);

        if (config.WithSsl)
        {
            minio = minio.WithSSL();
        }

        this.client = minio.Build();
    }

    /// <inheritdoc />
    public async Task UploadFile(
        string container,
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

        var args = new PutObjectArgs()
            .WithBucket(container)
            .WithObject(path)
            .WithStreamData(content)
            .WithObjectSize(contentLength)
            .WithContentType(contentType);
        await this.client
            .PutObjectAsync(args, cancellation)
            .ConfigureAwait(false);
    }

    /// <inheritdoc />
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
                    new StatObjectArgs()
                        .WithBucket(container)
                        .WithObject(path),
                    cancellation)
                .ConfigureAwait(false);
        }
        catch (MinioException)
        {
            throw new FileNotFoundException(container, path);
        }


        var temporaryFile = Path.GetTempFileName();

        await this.client
            .GetObjectAsync(
                new GetObjectArgs()
                    .WithBucket(container)
                    .WithObject(path)
                    .WithFile(temporaryFile),
                cancellation)
            .ConfigureAwait(false);

        var lastModified = Instant.FromDateTimeUtc(DateTime.SpecifyKind(fileStats.LastModified, DateTimeKind.Utc));
        return new MinioFileDownload(
            new FileStream(temporaryFile, FileMode.Open),
            ETag.From(fileStats.ETag),
            lastModified,
            fileStats.Size,
            temporaryFile);
    }

    /// <inheritdoc />
    public async Task RemoveFile(string container, string path, CancellationToken cancellation = default)
    {
        try
        {
            await this.client
                .StatObjectAsync(
                    new StatObjectArgs()
                        .WithBucket(container)
                        .WithObject(path),
                    cancellation)
                .ConfigureAwait(false);
        }
        catch (MinioException)
        {
            return;
        }

        await this.client.RemoveObjectAsync(
                new RemoveObjectArgs()
                    .WithBucket(container)
                    .WithObject(path),
                cancellation)
            .ConfigureAwait(false);
    }

    /// <inheritdoc />
    public Task CreateContainer(string container, CancellationToken cancellation = default)
    {
        return this.EnsureBucketExists(container, cancellation);
    }

    /// <inheritdoc />
    public async Task RemoveContainer(string container, CancellationToken cancellation = default)
    {
        var bucketExists = await this.client
            .BucketExistsAsync(new BucketExistsArgs().WithBucket(container), cancellation)
            .ConfigureAwait(false);

        if (!bucketExists)
        {
            return;
        }

        await this.CleanupAndRemoveContainer(container, cancellation);
    }

    private async Task CleanupAndRemoveContainer(string container, CancellationToken cancellation)
    {
        var _ = await this.client
            .ListObjectsAsync(new ListObjectsArgs().WithBucket(container).WithRecursive(true), cancellation)
            .SelectMany(file => Observable.FromAsync(ct => this.client.RemoveObjectAsync(new RemoveObjectArgs().WithBucket(container).WithObject(file.Key), ct)))
            .LastOrDefaultAsync();


        await this.client.RemoveBucketAsync(new RemoveBucketArgs().WithBucket(container), cancellation).ConfigureAwait(false);
        this.logger.LogInformation("Removed container {Container}", container);
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
                    new StatObjectArgs()
                        .WithBucket(container)
                        .WithObject(path),
                    cancellation)
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
            .BucketExistsAsync(new BucketExistsArgs().WithBucket(container), cancellation)
            .ConfigureAwait(false);

        if (!bucketExists)
        {
            this.logger.LogInformation("Creating container {Container}", container);
            await this.client
                .MakeBucketAsync(new MakeBucketArgs().WithBucket(container), cancellationToken: cancellation)
                .ConfigureAwait(false);
        }
    }
}
