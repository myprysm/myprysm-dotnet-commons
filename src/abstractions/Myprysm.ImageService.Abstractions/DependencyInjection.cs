namespace Myprysm.ImageService.Abstractions;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Myprysm.Tracing.Abstractions;

public static class DependencyInjection
{
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
