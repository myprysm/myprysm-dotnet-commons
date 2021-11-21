namespace Myprysm.FileService.FileSystem;

using Microsoft.Extensions.DependencyInjection;
using Myprysm.FileService.Abstractions;

public static class DependencyInjection
{
    public static IServiceCollection AddFileSystemFileService(
        this IServiceCollection services,
        string directory)
    {
        return services.AddFileSystemFileService(options => { options.Directory = directory; });
    }

    public static IServiceCollection AddFileSystemFileService(
        this IServiceCollection services,
        Action<FileSystemFileServiceOptions> configure)
    {
        return services
            .Configure(configure)
            .AddSingleton<IFileService, FileSystemFileService>();
    }
}
