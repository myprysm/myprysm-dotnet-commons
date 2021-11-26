namespace Myprysm.FileService.FileSystem;

using Microsoft.Extensions.DependencyInjection;
using Myprysm.FileService.Abstractions;
using Myprysm.Tracing.Abstractions;

public static class DependencyInjection
{
    public static IServiceCollection AddFileSystemFileService(
        this IServiceCollection services,
        string directory)
    {
        return services.AddFileSystemFileService(options => options.Directory = directory);
    }

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
