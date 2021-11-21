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
        Action<NatsBrokerOptions>? configure = null)
    {
        var configureOptions = configure ?? (_ => { });

        return services
                .Configure(configureOptions)
                .RegisterTracerOnStartup(PubSubNatsConstants.TracerIdentity)
                .AddSingleton<NatsBrokerConnectionHolder>()
                .AddScoped<IBrokerConnection, NatsBrokerConnection>()
            ;
    }

    public static IServiceCollection AddPubSubNats(
        this IServiceCollection services,
        IConfiguration configurationSection) =>
        services.AddPubSubNats(configurationSection.Bind);
}
