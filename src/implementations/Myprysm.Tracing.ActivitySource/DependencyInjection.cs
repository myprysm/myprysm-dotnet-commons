namespace Myprysm.Tracing.ActivitySource;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Myprysm.Tracing.Abstractions;

/// <summary>
/// Dependency injection extensions.
/// </summary>
public static class DependencyInjection
{
    /// <summary>
    /// Registers an <see cref="ActivitySourceTracerFactory"/> that can generate eagerly <see cref="ITracer"/>
    /// for application telemetry.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <returns>The service collection for fluent APIs.</returns>
    public static IServiceCollection AddActivityTracing(
        this IServiceCollection services)
    {
        services.TryAddSingleton<ActivitySourceTracerFactory>();

        // Ensure the latest factory will be an ActivitySourceTracerFactory until better solution. 
        services.AddSingleton<ITracerFactory>(p => p.GetRequiredService<ActivitySourceTracerFactory>());
        return services;
    }
}
