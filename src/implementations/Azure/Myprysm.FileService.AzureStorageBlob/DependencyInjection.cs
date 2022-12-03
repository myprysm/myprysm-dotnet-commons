namespace Myprysm.FileService.AzureStorageBlob;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.FileService.Abstractions;
using Myprysm.Tracing.Abstractions;

/// <summary>
/// Dependency injection extensions.
/// </summary>
public static class DependencyInjection
{
    /// <summary>
    /// Registers a <see cref="AzureStorageBlobFileService"/> in the service collection and configure it from the given configuration section.
    /// </summary>
    /// <param name="services">The service collection to register the <see cref="AzureStorageBlobFileService"/>.</param>
    /// <param name="configurationSection">The configuration section.</param>
    /// <returns>The service collection for fluent APIs.</returns>
    public static IServiceCollection AddFileServiceAzureStorageBlob(
        this IServiceCollection services,
        IConfiguration configurationSection) =>
        services.AddFileServiceAzureStorageBlob(configurationSection.Bind);

    /// <summary>
    /// Registers a <see cref="AzureStorageBlobFileService"/> in the service collection and configure it from the given action.
    /// </summary>
    /// <param name="services">The service collection to register the <see cref="AzureStorageBlobFileService"/>.</param>
    /// <param name="configure">The configuration action.</param>
    /// <returns>The service collection for fluent APIs.</returns>
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
}
