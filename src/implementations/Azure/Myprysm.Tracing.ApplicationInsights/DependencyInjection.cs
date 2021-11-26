namespace Myprysm.Tracing.ApplicationInsights;

using Microsoft.Extensions.DependencyInjection;
using Myprysm.Tracing.Abstractions;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationInsightsTracer(
        this IServiceCollection services)
    {
        return services
            .AddSingleton<ITracerFactory, TelemetryClientTracerFactory>();
    }
}
