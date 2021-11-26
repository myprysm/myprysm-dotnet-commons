namespace Myprysm.Converter.Abstractions;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Myprysm.Tracing.Abstractions;

public static class DependencyInjection
{
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
