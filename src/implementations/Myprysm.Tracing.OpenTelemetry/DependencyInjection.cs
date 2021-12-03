namespace Myprysm.Tracing.OpenTelemetry;

using global::OpenTelemetry.Trace;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.Tracing.ActivitySource;

/// <summary>
/// Dependency injection extensions.
/// </summary>
public static class DependencyInjection
{

    /// <summary>
    /// Adds OpenTelemetry TracerProvider configures with Myprysm Tracing enabled libraries into the specified <see cref="IServiceCollection" />.
    /// </summary>
    /// <param name="services">The <see cref="IServiceCollection" /> to add services into.</param>
    /// <param name="configure">Callback action to configure the <see cref="TracerProviderBuilder"/>.</param>
    /// <returns>The service collection for fluent APIs.</returns>
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
