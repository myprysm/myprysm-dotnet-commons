#### [Myprysm.PubSub.Nats](index.md 'index')
### [Myprysm.PubSub.Nats](index.md#Myprysm.PubSub.Nats 'Myprysm.PubSub.Nats')

## DependencyInjection Class

Dependency injection extensions.

```csharp
public static class DependencyInjection
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DependencyInjection
### Methods

<a name='Myprysm.PubSub.Nats.DependencyInjection.AddPubSubNats(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.Configuration.IConfiguration)'></a>

## DependencyInjection.AddPubSubNats(this IServiceCollection, IConfiguration) Method

Registers a [NatsBrokerConnection](Myprysm.PubSub.Nats.NatsBrokerConnection.md 'Myprysm.PubSub.Nats.NatsBrokerConnection') in the service collection and configure it from the given configuration section.

```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddPubSubNats(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration configurationSection);
```
#### Parameters

<a name='Myprysm.PubSub.Nats.DependencyInjection.AddPubSubNats(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.Configuration.IConfiguration).services'></a>

`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')

The service collection to register the [NatsBrokerConnection](Myprysm.PubSub.Nats.NatsBrokerConnection.md 'Myprysm.PubSub.Nats.NatsBrokerConnection').

<a name='Myprysm.PubSub.Nats.DependencyInjection.AddPubSubNats(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.Configuration.IConfiguration).configurationSection'></a>

`configurationSection` [Microsoft.Extensions.Configuration.IConfiguration](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Configuration.IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration')

The configuration section.

#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection for fluent APIs.

<a name='Myprysm.PubSub.Nats.DependencyInjection.AddPubSubNats(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Action_Myprysm.PubSub.Nats.NatsPubSubOptions_)'></a>

## DependencyInjection.AddPubSubNats(this IServiceCollection, Action<NatsPubSubOptions>) Method

Registers a [NatsBrokerConnection](Myprysm.PubSub.Nats.NatsBrokerConnection.md 'Myprysm.PubSub.Nats.NatsBrokerConnection') in the service collection and configure it from the given action.

```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddPubSubNats(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, System.Action<Myprysm.PubSub.Nats.NatsPubSubOptions>? configure=null);
```
#### Parameters

<a name='Myprysm.PubSub.Nats.DependencyInjection.AddPubSubNats(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Action_Myprysm.PubSub.Nats.NatsPubSubOptions_).services'></a>

`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')

The service collection to register the [NatsBrokerConnection](Myprysm.PubSub.Nats.NatsBrokerConnection.md 'Myprysm.PubSub.Nats.NatsBrokerConnection').

<a name='Myprysm.PubSub.Nats.DependencyInjection.AddPubSubNats(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Action_Myprysm.PubSub.Nats.NatsPubSubOptions_).configure'></a>

`configure` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[NatsPubSubOptions](Myprysm.PubSub.Nats.NatsPubSubOptions.md 'Myprysm.PubSub.Nats.NatsPubSubOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The configuration action.

#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection for fluent APIs.