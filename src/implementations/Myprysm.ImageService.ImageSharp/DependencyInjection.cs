namespace Myprysm.ImageService.ImageSharp;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.ImageService.Abstractions;
using Myprysm.Tracing.Abstractions;

/// <summary>
/// Dependency injection extensions.
/// </summary>
public static class DependencyInjection
{
    /// <summary>
    /// Registers a <see cref="ImageSharpImageService"/> in the service collection and configure it from the given configuration section.
    /// </summary>
    /// <param name="services">The service collection to register the <see cref="ImageSharpImageService"/>.</param>
    /// <param name="configurationSection">The configuration section.</param>
    /// <returns>The service collection for fluent APIs.</returns>
    public static IServiceCollection AddImageSharpImageService(
        this IServiceCollection services,
        IConfiguration configurationSection)
    {
        return services.AddImageSharpImageService(configurationSection.Bind);
    }

    /// <summary>
    /// Registers a <see cref="ImageSharpImageService"/> in the service collection.
    /// </summary>
    /// <param name="services">The service collection to register the <see cref="ImageSharpImageService"/>.</param>
    /// <returns>The service collection for fluent APIs.</returns>
    public static IServiceCollection AddImageSharpImageService(this IServiceCollection services)
    {
        return services.AddImageSharpImageService(_ => {});
    }

    /// <summary>
    /// Registers a <see cref="ImageSharpImageService"/> in the service collection and configure it from the given action.
    /// </summary>
    /// <param name="services">The service collection to register the <see cref="ImageSharpImageService"/>.</param>
    /// <param name="configure">The configuration action.</param>
    /// <returns>The service collection for fluent APIs.</returns>
    public static IServiceCollection AddImageSharpImageService(
        this IServiceCollection services,
        Action<ImageSharpImageServiceOptions> configure)
    {
        return services
            .Configure(configure)
            .TryAddDefaultTracer()
            .RegisterTracerOnStartup(ImageServiceImageSharpConstants.TracerIdentity)
            .AddSingleton<ImageSharpImageService>()
            .AddSingleton(sp => sp.CreateImageService<ImageSharpImageServiceOptions>(
                ImageServiceImageSharpConstants.TracerIdentity,
                p => p.GetRequiredService<ImageSharpImageService>()));
    }
}
