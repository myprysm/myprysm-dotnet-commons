namespace Myprysm.Tracing.OpenTelemetry;

using global::OpenTelemetry.Trace;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.Tracing.Abstractions;
using Myprysm.Tracing.ActivitySource;

public static class DependencyInjection
{
    public static IServiceCollection AddMyprysmOpenTelemetryTracing(
        this IServiceCollection services,
        Action<IServiceProvider, TracerProviderBuilder> configure)
    {
        return services
            .AddActivityTracing()
            .AddOpenTelemetryTracing(builder =>
            {
                builder
                    .Configure((sp, b) => b.ConfigureMyprysmTracers(sp))
                    .Configure(configure);
            });
    }

    private static void ConfigureMyprysmTracers(
        this TracerProviderBuilder builder,
        IServiceProvider serviceProvider)
    {
        var tracer = serviceProvider.GetRequiredService<ActivitySourceTracerFactory>();
        foreach (var identity in tracer.RegisteredIdentities)
        {
            builder.AddSource(identity.Name);
        }
    }
}
