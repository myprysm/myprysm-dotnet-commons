namespace Myprysm.FileService.Minio;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.FileService.Abstractions;
using Myprysm.Tracing.Abstractions;

public static class DependencyInjection
{
    public static IServiceCollection AddMinioFileService(
        this IServiceCollection services,
        Action<MinioFileServiceOptions>? configure = null)
    {
        var configureOptions = configure ?? (_ => { });

        return services
                .Configure(configureOptions)
                .TryAddDefaultTracer()
                .RegisterTracerOnStartup(FileServiceMinioConstants.TracerIdentity)
                .AddSingleton<MinioFileService>()
                .AddSingleton(sp => sp.CreateFileService<MinioFileServiceOptions>(
                    FileServiceMinioConstants.TracerIdentity,
                    p => p.GetRequiredService<MinioFileService>()))
            ;
    }

    public static IServiceCollection AddMinioFileService(
        this IServiceCollection services,
        IConfiguration configurationSection) =>
        services.AddMinioFileService(configurationSection.Bind);
}
