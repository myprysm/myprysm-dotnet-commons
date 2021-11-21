namespace Myprysm.Tracing.Abstractions;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

public static class DependencyInjection
{
    public static IServiceCollection RegisterTracerOnStartup(
        this IServiceCollection services,
        TracerIdentity identity)
    {
        return services
                .Configure<StartupTracerOptions>(options => options.OnStartup.Add(identity))
            ;
    }

    public static IServiceCollection TryAddDefaultTracer(
        this IServiceCollection services)
    {
        services.TryAddSingleton<ITracerFactory, DefaultTracerFactory>();

        return services;
    }
}
