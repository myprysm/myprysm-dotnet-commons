namespace Myprysm.FileService.Abstractions;

/// <summary>
/// Base file service options.
///
/// You should extend those options and use the dependency injection extensions if you want to enable tracing
/// </summary>
public class FileServiceOptions
{
    /// <summary>
    /// Enable tracing with the file service implementation.
    /// </summary>
    /// <remarks>Tracing is enabled by default.</remarks>
    public bool WithTracing { get; set; } = true;
}
