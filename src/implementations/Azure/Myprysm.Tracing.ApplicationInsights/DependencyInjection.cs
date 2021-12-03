namespace Myprysm.Tracing.ApplicationInsights;

using Microsoft.Extensions.DependencyInjection;
using Myprysm.Tracing.Abstractions;

/// <summary>
/// Dependency injection extensions.
/// </summary>
public static class DependencyInjection
{
    /// <summary>
    /// Registers an <see cref="TelemetryClientTracerFactory"/> that can generate <see cref="ITracer"/>
    /// for application telemetry.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <returns>The service collection for fluent APIs.</returns>
    public static IServiceCollection AddApplicationInsightsTracer(
        this IServiceCollection services)
    {
        return services
            .AddSingleton<ITracerFactory, TelemetryClientTracerFactory>();
    }
}
