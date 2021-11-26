namespace Myprysm.ImageService.ImageSharp;

using Microsoft.Extensions.DependencyInjection;
using Myprysm.ImageService.Abstractions;
using Myprysm.Tracing.Abstractions;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Memory;

public static class DependencyInjection
{
    public static IServiceCollection AddImageSharpImageService(
        this IServiceCollection services,
        MemoryPoolKind memoryPool = MemoryPoolKind.Default)
    {
        return services.AddImageSharpImageService(options => options.MemoryPoolKind = memoryPool);
    }

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
