namespace Myprysm.PubSub.AzureStorageQueue;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.PubSub.Abstractions;
using Myprysm.Tracing.Abstractions;

public static class DependencyInjection
{
    public static IServiceCollection AddPubSubAzureStorageQueue(
        this IServiceCollection services,
        Action<AzureStorageQueuePubSubOptions>? configure = null)
    {
        var configureOptions = configure ?? (_ => { });

        return services
                .Configure(configureOptions)
                .TryAddDefaultTracer()
                .RegisterTracerOnStartup(PubSubAzureStorageQueueConstants.TracerIdentity)
                .AddSingleton<IBrokerConnection, AzureStorageQueueBrokerConnection>()
            ;
    }

    public static IServiceCollection AddPubSubAzureStorageQueue(
        this IServiceCollection services,
        IConfiguration configurationSection) =>
        services.AddPubSubAzureStorageQueue(configurationSection.Bind);
}
