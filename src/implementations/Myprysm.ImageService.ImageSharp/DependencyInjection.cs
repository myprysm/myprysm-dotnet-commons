namespace Myprysm.ImageService.ImageSharp;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.ImageService.Abstractions;
using Myprysm.Tracing.Abstractions;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Memory;

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
    /// Registers a <see cref="ImageSharpImageService"/> in the service collection and configure it with the given <see cref="MemoryPoolKind"/>.
    /// </summary>
    /// <param name="services">The service collection to register the <see cref="ImageSharpImageService"/>.</param>
    /// <param name="memoryPool">The memory pool kind.</param>
    /// <returns>The service collection for fluent APIs.</returns>
    public static IServiceCollection AddImageSharpImageService(
        this IServiceCollection services,
        MemoryPoolKind memoryPool = MemoryPoolKind.Default)
    {
        return services.AddImageSharpImageService(options => options.MemoryPoolKind = memoryPool);
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
            .PostConfigure<ImageSharpImageServiceOptions>(options => { Configuration.Default.MemoryAllocator = GetMemoryAllocator(options.MemoryPoolKind); })
            .TryAddDefaultTracer()
            .RegisterTracerOnStartup(ImageServiceImageSharpConstants.TracerIdentity)
            .AddSingleton<ImageSharpImageService>()
            .AddSingleton(sp => sp.CreateImageService<ImageSharpImageServiceOptions>(
                ImageServiceImageSharpConstants.TracerIdentity,
                p => p.GetRequiredService<ImageSharpImageService>()));
    }

    private static MemoryAllocator GetMemoryAllocator(MemoryPoolKind kind)
    {
        return kind switch
        {
            MemoryPoolKind.Default => ArrayPoolMemoryAllocator.CreateDefault(),
            MemoryPoolKind.Large => ArrayPoolMemoryAllocator.CreateWithAggressivePooling(),
            MemoryPoolKind.Minimal => ArrayPoolMemoryAllocator.CreateWithMinimalPooling(),
            MemoryPoolKind.Medium => ArrayPoolMemoryAllocator.CreateWithModeratePooling(),
            _ => ArrayPoolMemoryAllocator.CreateDefault(),
        };
    }
}
