namespace Myprysm.FileService.Abstractions;

using Myprysm.FileService.Abstractions.ValueObjects;
using NodaTime;

/// <summary>
/// A <see cref="IDisposable"/> file downloaded from an <see cref="IFileService"/>.
/// </summary>
/// <remarks>
/// You can extend this record if you need a custom way of disposing resources.
/// </remarks>
/// <param name="Stream">The stream content of the file.</param>
/// <param name="ETag">The <see cref="ETag"/>.</param>
/// <param name="LastModified">The date the file has been modified for the last time.</param>
/// <param name="ContentLength">The lenght of the content.</param>
public record FileDownload(
    Stream Stream,
    ETag ETag,
    Instant LastModified,
    long ContentLength) : IDisposable
{
    /// <inheritdoc />
    public virtual void Dispose()
    {
        this.Stream.Dispose();
        GC.SuppressFinalize(this);
    }
}
