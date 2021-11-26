namespace Myprysm.FileService.Abstractions;

using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Myprysm.Tracing.Abstractions;

public static class DependencyInjection
{
    public static IFileService CreateFileService<TOptions>(
        this IServiceProvider provider,
        TracerIdentity identity,
        Func<IServiceProvider, IFileService> factory)
        where TOptions : FileServiceOptions
    {
        var fileService = factory(provider);
        var options = provider.GetRequiredService<IOptions<TOptions>>();

        if (!options.Value.WithTracing)
        {
            return fileService;
        }

        var tracerFactory = provider.GetRequiredService<ITracerFactory>();
        var tracer = tracerFactory.GetTracer(identity);

        return new TracedFileService(fileService, tracer);
    }
}
