namespace Myprysm.FileService.Minio;

using Myprysm.FileService.Abstractions;
using Myprysm.FileService.Abstractions.ValueObjects;
using NodaTime;

public sealed record MinioFileDownload(
    Stream Stream,
    ETag ETag,
    Instant LastModified,
    long ContentLength,
    string temporaryFile) : FileDownload(
    Stream,
    ETag,
    LastModified,
    ContentLength)
{
    private readonly string temporaryFile = temporaryFile;

    public override void Dispose()
    {
        base.Dispose();
        File.Delete(this.temporaryFile);
    }
}
