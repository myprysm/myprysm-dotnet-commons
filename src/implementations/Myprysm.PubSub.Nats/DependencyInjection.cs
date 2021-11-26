namespace Myprysm.PubSub.Nats;

using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.PubSub.Abstractions;
using Myprysm.Tracing.Abstractions;

public static class DependencyInjection
{
    public static IServiceCollection AddPubSubNats(
        this IServiceCollection services,
        Action<NatsPubSubOptions>? configure = null)
    {
        var configureOptions = configure ?? (_ => { });

        return services
                .Configure(configureOptions)
                .TryAddDefaultTracer()
                .RegisterTracerOnStartup(PubSubNatsConstants.TracerIdentity)
                .AddSingleton<IBrokerConnection, NatsBrokerConnection>()
            ;
    }

    public static IServiceCollection AddPubSubNats(
        this IServiceCollection services,
        IConfiguration configurationSection) =>
        services.AddPubSubNats(configurationSection.Bind);
}
