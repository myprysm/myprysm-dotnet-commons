namespace Myprysm.ImageService.Abstractions;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Myprysm.Tracing.Abstractions;

/// <summary>
/// Dependency injection extensions.
/// </summary>
public static class DependencyInjection
{
    /// <summary>
    /// Create an image service with optional tracing.
    /// </summary>
    /// <param name="provider">The service provider.</param>
    /// <param name="identity">The tracer identity (usually for the implementation library).</param>
    /// <param name="factory">The image service factory.</param>
    /// <typeparam name="TOptions">The specialized type of <see cref="ImageServiceOptions"/>.</typeparam>
    /// <returns>The image service, optionally decorated with tracing.</returns>
    public static IImageService CreateImageService<TOptions>(
        this IServiceProvider provider,
        TracerIdentity identity,
        Func<IServiceProvider, IImageService> factory)
        where TOptions : ImageServiceOptions
    {
        var imageService = factory(provider);
        var options = provider.GetRequiredService<IOptions<TOptions>>();

        if (!options.Value.WithTracing)
        {
            return imageService;
        }

        var tracerFactory = provider.GetRequiredService<ITracerFactory>();
        var tracer = tracerFactory.GetTracer(identity);

        return new TracedImageService(imageService, tracer);
    }
}
