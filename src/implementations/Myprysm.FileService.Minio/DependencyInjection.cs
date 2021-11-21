namespace Myprysm.FileService.Minio;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.FileService.Abstractions;

public static class DependencyInjection
{
    public static IServiceCollection AddMinioFileService(
        this IServiceCollection services,
        Action<MinioFileServiceOptions>? configure = null)
    {
        var configureOptions = configure ?? (_ => {});
        
        return services
            .Configure(configureOptions)
            .AddSingleton<IFileService, MinioFileService>();
    }

    public static IServiceCollection AddMinioFileService(
        this IServiceCollection services,
        IConfiguration configurationSection) =>
        services.AddMinioFileService(configurationSection.Bind);
}
