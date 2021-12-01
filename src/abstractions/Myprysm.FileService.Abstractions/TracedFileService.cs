namespace Myprysm.FileService.Abstractions;

using System;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Myprysm.FileService.Abstractions.Exceptions;
using Myprysm.Tracing.Abstractions;
using FileNotFoundException = Myprysm.FileService.Abstractions.Exceptions.FileNotFoundException;

internal class TracedFileService : IFileService
{
    private readonly IFileService delegated;
    private readonly ITracer tracer;

    internal TracedFileService(
        IFileService delegated,
        ITracer tracer)
    {
        this.delegated = delegated;
        this.tracer = tracer;
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
        using var trace = this.tracer.StartTrace(nameof(this.UploadFile));
        trace?.AddTag("file_service.container", container);
        trace?.AddTag("file_service.path", path);
        trace?.AddTag("file_service.content_type", contentType);
        trace?.AddTag("file_service.content_length", contentLength.ToString(CultureInfo.InvariantCulture));
        trace?.AddTag("file_service.overwrite_existing_file", overwriteExistingFile.ToString(CultureInfo.InvariantCulture));

        try
        {
            await this.delegated
                .UploadFile(
                    container,
                    path,
                    content,
                    contentType,
                    contentLength,
                    overwriteExistingFile,
                    cancellation)
                .ConfigureAwait(false);
        }
        catch (FileAlreadyExistsException exception)
        {
            trace?.AddTag("otel.status_code", "ERROR");
            trace?.AddTag("otel.status_description", $"File already exists: {exception.Message}");
            throw;
        }
        catch (Exception exception)
        {
            trace?.AddTag("otel.status_code", "ERROR");
            trace?.AddTag("otel.status_description", $"Unhandled exception: {exception.Message}");
            throw;
        }
    }

    public async Task<FileDownload> DownloadFile(string container, string path, CancellationToken cancellation = default)
    {
        using var trace = this.tracer.StartTrace(nameof(this.DownloadFile));
        trace?.AddTag("file_service.container", container);
        trace?.AddTag("file_service.path", path);

        try
        {
            return await this.delegated
                .DownloadFile(
                    container,
                    path,
                    cancellation)
                .ConfigureAwait(false);
        }
        catch (FileNotFoundException exception)
        {
            trace?.AddTag("otel.status_code", "ERROR");
            trace?.AddTag("otel.status_description", $"File not found: {exception.Message}");
            throw;
        }
        catch (Exception exception)
        {
            trace?.AddTag("otel.status_code", "ERROR");
            trace?.AddTag("otel.status_description", $"Unhandled exception: {exception.Message}");
            throw;
        }
    }

    public async Task RemoveFile(string container, string path, CancellationToken cancellation = default)
    {
        using var trace = this.tracer.StartTrace(nameof(this.RemoveFile));
        trace?.AddTag("file_service.container", container);
        trace?.AddTag("file_service.path", path);

        try
        {
            await this.delegated.RemoveFile(container, path, cancellation).ConfigureAwait(false);
        }
        catch (Exception exception)
        {
            trace?.AddTag("otel.status_code", "ERROR");
            trace?.AddTag("otel.status_description", $"Unhandled exception: {exception.Message}");
            throw;
        }
    }

    public async Task CreateContainer(string container, CancellationToken cancellation = default)
    {
        using var trace = this.tracer.StartTrace(nameof(this.CreateContainer));
        trace?.AddTag("file_service.container", container);

        try
        {
            await this.delegated.CreateContainer(container, cancellation).ConfigureAwait(false);
        }
        catch (Exception exception)
        {
            trace?.AddTag("otel.status_code", "ERROR");
            trace?.AddTag("otel.status_description", $"Unhandled exception: {exception.Message}");
            throw;
        }
    }

    public async Task RemoveContainer(string container, CancellationToken cancellation = default)
    {
        using var trace = this.tracer.StartTrace(nameof(this.RemoveContainer));
        trace?.AddTag("file_service.container", container);

        try
        {
            await this.delegated.RemoveContainer(container, cancellation).ConfigureAwait(false);
        }
        catch (Exception exception)
        {
            trace?.AddTag("otel.status_code", "ERROR");
            trace?.AddTag("otel.status_description", $"Unhandled exception: {exception.Message}");
            throw;
        }
    }
}
