namespace Myprysm.Tracing.ActivitySource;

using Microsoft.Extensions.DependencyInjection;
using Myprysm.Tracing.Abstractions;

public static class DependencyInjection
{
    public static IServiceCollection AddActivityTracing(
        this IServiceCollection services)
    {
        return services
            .AddSingleton<ITracerFactory, ActivitySourceTracerFactory>();
    }
}
