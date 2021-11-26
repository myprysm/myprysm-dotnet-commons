namespace Myprysm.FileService.AzureStorageBlob;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.FileService.Abstractions;
using Myprysm.Tracing.Abstractions;

public static class DependencyInjection
{
    public static IServiceCollection AddFileServiceAzureStorageBlob(
        this IServiceCollection services,
        Action<AzureStorageBlobFileServiceOptions>? configure = null)
    {
        var configureOptions = configure ?? (_ => { });

        return services
                .Configure(configureOptions)
                .TryAddDefaultTracer()
                .RegisterTracerOnStartup(FileServiceAzureStorageBlobConstants.TracerIdentity)
                .AddSingleton<AzureStorageBlobFileService>()
                .AddSingleton(sp => sp.CreateFileService<AzureStorageBlobFileServiceOptions>(
                    FileServiceAzureStorageBlobConstants.TracerIdentity,
                    p => p.GetRequiredService<AzureStorageBlobFileService>()))
            ;
    }

    public static IServiceCollection AddFileServiceAzureStorageBlob(
        this IServiceCollection services,
        IConfiguration configurationSection) =>
        services.AddFileServiceAzureStorageBlob(configurationSection.Bind);
}
