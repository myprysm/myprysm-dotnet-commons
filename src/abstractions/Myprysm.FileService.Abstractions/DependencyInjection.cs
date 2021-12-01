namespace Myprysm.FileService.Abstractions;

using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Myprysm.Tracing.Abstractions;

/// <summary>
/// Dependency injection extensions
/// </summary>
public static class DependencyInjection
{
    /// <summary>
    /// Create a file service with optional tracing.
    /// </summary>
    /// <param name="provider">The service provider.</param>
    /// <param name="identity">The tracer identity (usually for the implementation library).</param>
    /// <param name="factory">The file service factory.</param>
    /// <typeparam name="TOptions">The specialized type of <see cref="FileServiceOptions"/>.</typeparam>
    /// <returns>The file service, optionally decorated with tracing.</returns>
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
