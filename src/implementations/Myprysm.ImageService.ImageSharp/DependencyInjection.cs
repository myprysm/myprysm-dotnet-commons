namespace Myprysm.ImageService.ImageSharp;

using Microsoft.Extensions.DependencyInjection;
using Myprysm.ImageService.Abstractions;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Memory;

public static class DependencyInjection
{
    public static IServiceCollection AddImageSharpImageService(
        this IServiceCollection services,
        MemoryPoolKind memoryPool = MemoryPoolKind.Default)
    {
        Configuration.Default.MemoryAllocator = GetMemoryAllocator(memoryPool);

        return services.AddScoped<IImageService, ImageSharpImageService>();
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
