namespace Myprysm.FileService.Minio;

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
    /// Registers a <see cref="MinioFileService"/> in the service collection and configure it from the given configuration section.
    /// </summary>
    /// <param name="services">The service collection to register the <see cref="MinioFileService"/>.</param>
    /// <param name="configurationSection">The configuration section.</param>
    /// <returns>The service collection for fluent APIs.</returns>
    public static IServiceCollection AddMinioFileService(
        this IServiceCollection services,
        IConfiguration configurationSection) =>
        services.AddMinioFileService(configurationSection.Bind);

    /// <summary>
    /// Registers a <see cref="MinioFileService"/> in the service collection and configure it from the given action.
    /// </summary>
    /// <param name="services">The service collection to register the <see cref="MinioFileService"/>.</param>
    /// <param name="configure">The configuration action.</param>
    /// <returns>The service collection for fluent APIs.</returns>
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
                p => p.GetRequiredService<MinioFileService>()));
    }
}
