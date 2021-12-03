namespace Myprysm.PubSub.Nats;

using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.PubSub.Abstractions;
using Myprysm.Tracing.Abstractions;

/// <summary>
/// Dependency injection extensions.
/// </summary>
public static class DependencyInjection
{
    /// <summary>
    /// Registers a <see cref="NatsBrokerConnection"/> in the service collection and configure it from the given configuration section.
    /// </summary>
    /// <param name="services">The service collection to register the <see cref="NatsBrokerConnection"/>.</param>
    /// <param name="configurationSection">The configuration section.</param>
    /// <returns>The service collection for fluent APIs.</returns>
    public static IServiceCollection AddPubSubNats(
        this IServiceCollection services,
        IConfiguration configurationSection) =>
        services.AddPubSubNats(configurationSection.Bind);

    /// <summary>
    /// Registers a <see cref="NatsBrokerConnection"/> in the service collection and configure it from the given action.
    /// </summary>
    /// <param name="services">The service collection to register the <see cref="NatsBrokerConnection"/>.</param>
    /// <param name="configure">The configuration action.</param>
    /// <returns>The service collection for fluent APIs.</returns>
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
}
