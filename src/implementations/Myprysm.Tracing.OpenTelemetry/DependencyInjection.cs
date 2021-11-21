namespace Myprysm.Tracing.OpenTelemetry;

using global::OpenTelemetry.Trace;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.Tracing.Abstractions;

public static class DependencyInjection
{
    public static TracerProviderBuilder ConfigureMyprysmTracers(
        this TracerProviderBuilder builder,
        IServiceProvider serviceProvider)
    {
        var tracer = serviceProvider.GetRequiredService<ITracerFactory>();
        foreach (var identity in tracer.RegisteredIdentities)
        {
            builder.AddSource(identity.Name);
        }

        return builder;
    }
}
