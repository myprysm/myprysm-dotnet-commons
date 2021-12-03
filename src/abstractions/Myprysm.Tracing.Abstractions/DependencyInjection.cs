namespace Myprysm.Tracing.Abstractions;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

/// <summary>
/// Dependency injection extensions.
/// </summary>
public static class DependencyInjection
{
    /// <summary>
    /// Registers a <see cref="TracerIdentity"/> in the startup options.
    /// Can be useful with some implementations like OpenTelemetry.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <param name="identity">The tracer identity.</param>
    /// <returns>The service collection.</returns>
    public static IServiceCollection RegisterTracerOnStartup(
        this IServiceCollection services,
        TracerIdentity identity)
    {
        return services
                .Configure<StartupTracerOptions>(options => options.OnStartup.Add(identity))
            ;
    }

    /// <summary>
    /// Try to register a default noop tracer factory if no tracer factory has been already registered.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <returns>The service collection.</returns>
    public static IServiceCollection TryAddDefaultTracer(
        this IServiceCollection services)
    {
        services.TryAddSingleton<ITracerFactory, DefaultTracerFactory>();

        return services;
    }
}
