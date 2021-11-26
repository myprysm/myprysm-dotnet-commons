namespace Myprysm.FileService.Abstractions;

using System;
using System.IO;
using Myprysm.FileService.Abstractions.ValueObjects;
using NodaTime;

public record FileDownload(
    Stream Stream,
    ETag ETag,
    Instant LastModified,
    long ContentLength) : IDisposable
{
    public virtual void Dispose()
    {
        this.Stream.Dispose();
        GC.SuppressFinalize(this);
    }
}
