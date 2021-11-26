namespace Myprysm.FileService.AzureStorageBlob;

using Azure;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Myprysm.FileService.Abstractions;
using Myprysm.FileService.Abstractions.Exceptions;
using NodaTime;
using ETag = Myprysm.FileService.Abstractions.ValueObjects.ETag;

public class AzureStorageBlobFileService : IFileService
{
    private readonly BlobServiceClient client;
    private readonly ILogger<AzureStorageBlobFileService> logger;

    public AzureStorageBlobFileService(
        IOptions<AzureStorageBlobFileServiceOptions> options,
        ILogger<AzureStorageBlobFileService> logger)
    {
        this.client = new BlobServiceClient(options.Value.ConnectionString);
        this.logger = logger;
    }

    /// <inheritdoc cref="IFileService.UploadFile"/>
    public async Task UploadFile(
        string container,
        string path,
        Stream content,
        string contentType,
        long contentLength,
        bool overwriteExistingFile = false,
        CancellationToken cancellation = default)
    {
        var containerClient = this.client.GetBlobContainerClient(container);
        await containerClient.CreateIfNotExistsAsync(cancellationToken: cancellation).ConfigureAwait(false);

        var blobClient = containerClient.GetBlobClient(path);

        var conditions = default(BlobRequestConditions);
        if (!overwriteExistingFile)
        {
            var blobExists = await blobClient.ExistsAsync(cancellation).ConfigureAwait(false);

            if (blobExists)
            {
                throw new FileAlreadyExistsException(container, path);
            }

            conditions = new BlobRequestConditions { IfNoneMatch = new Azure.ETag(ETag.All.Value), };
        }

        var uploadOptions = new BlobUploadOptions
        {
            Conditions = conditions,
            AccessTier = AccessTier.Hot,
            HttpHeaders = new BlobHttpHeaders
            {
                ContentType = contentType,
            },
        };

        try
        {
            await blobClient.UploadAsync(content, uploadOptions, cancellation).ConfigureAwait(false);
        }
        catch (RequestFailedException exception)
        {
            if (exception.Status != 412)
            {
                this.logger.LogError(
                    exception,
                    "An unmanaged exception occured during blob upload at path {Path} in container {Container}, allow overwrite: {AllowOverwrite}",
                    path,
                    container,
                    overwriteExistingFile);
                throw;
            }

            this.logger.LogError(
                exception,
                "Unable to upload blob at path {Path} in container {Container}, allow overwrite: {AllowOverwrite}",
                path,
                container,
                overwriteExistingFile);
            throw new FileAlreadyExistsException(container, path);
        }
    }

    /// <inheritdoc cref="IFileService.DownloadFile"/>
    public async Task<FileDownload> DownloadFile(string container, string path, CancellationToken cancellation = default)
    {
        var blobClient = this.client.GetBlobContainerClient(container).GetBlobClient(path);
        var blobExists = await blobClient.ExistsAsync(cancellation).ConfigureAwait(false);

        if (!blobExists)
        {
            throw new FileNotFoundException(container, path);
        }

        var blobProperties = await blobClient.GetPropertiesAsync(cancellationToken: cancellation).ConfigureAwait(false);
        var contentLength = blobProperties.Value.ContentLength;
        var eTag = blobProperties.Value.ETag.ToString().Replace("\"", "");
        var lastModified = Instant.FromDateTimeOffset(blobProperties.Value.LastModified);

        var fileStream = await blobClient.OpenReadAsync(cancellationToken: cancellation).ConfigureAwait(false);

        return new FileDownload(fileStream, ETag.From(eTag), lastModified, contentLength);
    }

    /// <inheritdoc cref="IFileService.RemoveFile"/>
    public async Task RemoveFile(string container, string path, CancellationToken cancellation = default)
    {
        var blobClient = this.client.GetBlobContainerClient(container).GetBlobClient(path);
        await blobClient.DeleteIfExistsAsync(cancellationToken: cancellation).ConfigureAwait(false);
    }

    /// <inheritdoc cref="IFileService.CreateContainer"/>
    public async Task CreateContainer(string container, CancellationToken cancellation = default)
    {
        var containerClient = this.client.GetBlobContainerClient(container);
        await containerClient.CreateIfNotExistsAsync(cancellationToken: cancellation).ConfigureAwait(false);
    }

    /// <inheritdoc cref="IFileService.RemoveContainer"/>
    public async Task RemoveContainer(string container, CancellationToken cancellation = default)
    {
        var containerClient = this.client.GetBlobContainerClient(container);
        await containerClient.DeleteIfExistsAsync(cancellationToken: cancellation).ConfigureAwait(false);
    }
}
