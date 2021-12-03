namespace Myprysm.FileService.FileSystem;

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
    /// Registers a <see cref="FileSystemFileService"/> in the service collection and configure it from the given configuration section.
    /// </summary>
    /// <param name="services">The service collection to register the <see cref="FileSystemFileService"/>.</param>
    /// <param name="configurationSection">The configuration section.</param>
    /// <returns>The service collection for fluent APIs.</returns>
    public static IServiceCollection AddFileSystemFileService(
        this IServiceCollection services,
        IConfiguration configurationSection) =>
        services.AddFileSystemFileService(configurationSection.Bind);

    /// <summary>
    /// Registers a <see cref="FileSystemFileService"/> in the service collection and configure it from the given action.
    /// </summary>
    /// <param name="services">The service collection to register the <see cref="FileSystemFileService"/>.</param>
    /// <param name="configure">The configuration action.</param>
    /// <returns>The service collection for fluent APIs.</returns>
    public static IServiceCollection AddFileSystemFileService(
        this IServiceCollection services,
        Action<FileSystemFileServiceOptions> configure)
    {
        return services
            .Configure(configure)
            .TryAddDefaultTracer()
            .RegisterTracerOnStartup(FileServiceFileSystemConstants.TracerIdentity)
            .AddSingleton<FileSystemFileService>()
            .AddSingleton(sp => sp.CreateFileService<FileSystemFileServiceOptions>(
                FileServiceFileSystemConstants.TracerIdentity,
                p => p.GetRequiredService<FileSystemFileService>()));
    }
}
