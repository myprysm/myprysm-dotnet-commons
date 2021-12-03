namespace Myprysm.Converter.Abstractions;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Myprysm.Tracing.Abstractions;

/// <summary>
/// Dependency injection extensions
/// </summary>
public static class DependencyInjection
{
    /// <summary>
    /// Create a converter with optional tracing.
    /// </summary>
    /// <param name="provider">The service provider.</param>
    /// <param name="identity">The tracer identity (usually for the implementation library).</param>
    /// <param name="factory">The converter factory.</param>
    /// <typeparam name="TOptions">The specialized type of <see cref="ConverterOptions"/>.</typeparam>
    /// <returns>The converter, optionally decorated with tracing.</returns>
    public static IConverter CreateConverter<TOptions>(
        this IServiceProvider provider,
        TracerIdentity identity,
        Func<IServiceProvider, IConverter> factory)
        where TOptions : ConverterOptions
    {
        var converter = factory(provider);
        var options = provider.GetRequiredService<IOptions<TOptions>>();

        if (!options.Value.WithTracing)
        {
            return converter;
        }

        var tracerFactory = provider.GetRequiredService<ITracerFactory>();
        var tracer = tracerFactory.GetTracer(identity);

        return new TracedConverter(converter, tracer);
    }
}
