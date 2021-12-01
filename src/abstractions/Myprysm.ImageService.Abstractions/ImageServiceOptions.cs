namespace Myprysm.ImageService.Abstractions;

/// <summary>
/// Base image service options.
///
/// You should extend those options and use the dependency injection extensions if you want to enable tracing
/// </summary>
public class ImageServiceOptions
{
    /// <summary>
    /// Enable tracing with the image service implementation.
    /// </summary>
    /// <remarks>Tracing is enabled by default.</remarks>
    public bool WithTracing { get; set; } = true;
}
