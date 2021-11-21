namespace Myprysm.FileService.AzureStorageBlob;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.FileService.Abstractions;

public static class DependencyInjection
{
    public static IServiceCollection AddFileServiceAzureStorageBlob(
        this IServiceCollection services,
        Action<AzureStorageBlobFileServiceOptions>? configure = null)
    {
        var configureOptions = configure ?? (_ => { });

        return services
                .Configure(configureOptions)
                .AddSingleton<IFileService, AzureStorageBlobFileService>()
            ;
    }

    public static IServiceCollection AddFileServiceAzureStorageBlob(
        this IServiceCollection services,
        IConfiguration configurationSection) =>
        services.AddFileServiceAzureStorageBlob(configurationSection.Bind);
}
