#### [Myprysm.PubSub.AzureStorageQueue](index.md 'index')
### [Myprysm.PubSub.AzureStorageQueue](index.md#Myprysm.PubSub.AzureStorageQueue 'Myprysm.PubSub.AzureStorageQueue')

## DependencyInjection Class

Dependency injection extensions.

```csharp
public static class DependencyInjection
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DependencyInjection
### Methods

<a name='Myprysm.PubSub.AzureStorageQueue.DependencyInjection.AddPubSubAzureStorageQueue(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.Configuration.IConfiguration)'></a>

## DependencyInjection.AddPubSubAzureStorageQueue(this IServiceCollection, IConfiguration) Method

Registers a [AzureStorageQueueBrokerConnection](Myprysm.PubSub.AzureStorageQueue.AzureStorageQueueBrokerConnection.md 'Myprysm.PubSub.AzureStorageQueue.AzureStorageQueueBrokerConnection') in the service collection and configure it from the given configuration section.

```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddPubSubAzureStorageQueue(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration configurationSection);
```
#### Parameters

<a name='Myprysm.PubSub.AzureStorageQueue.DependencyInjection.AddPubSubAzureStorageQueue(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.Configuration.IConfiguration).services'></a>

`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')

The service collection to register the [AzureStorageQueueBrokerConnection](Myprysm.PubSub.AzureStorageQueue.AzureStorageQueueBrokerConnection.md 'Myprysm.PubSub.AzureStorageQueue.AzureStorageQueueBrokerConnection').

<a name='Myprysm.PubSub.AzureStorageQueue.DependencyInjection.AddPubSubAzureStorageQueue(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.Configuration.IConfiguration).configurationSection'></a>

`configurationSection` [Microsoft.Extensions.Configuration.IConfiguration](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Configuration.IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration')

The configuration section.

#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection for fluent APIs.

<a name='Myprysm.PubSub.AzureStorageQueue.DependencyInjection.AddPubSubAzureStorageQueue(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Action_Myprysm.PubSub.AzureStorageQueue.AzureStorageQueuePubSubOptions_)'></a>

## DependencyInjection.AddPubSubAzureStorageQueue(this IServiceCollection, Action<AzureStorageQueuePubSubOptions>) Method

Registers a [AzureStorageQueueBrokerConnection](Myprysm.PubSub.AzureStorageQueue.AzureStorageQueueBrokerConnection.md 'Myprysm.PubSub.AzureStorageQueue.AzureStorageQueueBrokerConnection') in the service collection and configure it from the given action.

```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddPubSubAzureStorageQueue(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, System.Action<Myprysm.PubSub.AzureStorageQueue.AzureStorageQueuePubSubOptions>? configure=null);
```
#### Parameters

<a name='Myprysm.PubSub.AzureStorageQueue.DependencyInjection.AddPubSubAzureStorageQueue(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Action_Myprysm.PubSub.AzureStorageQueue.AzureStorageQueuePubSubOptions_).services'></a>

`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')

The service collection to register the [AzureStorageQueueBrokerConnection](Myprysm.PubSub.AzureStorageQueue.AzureStorageQueueBrokerConnection.md 'Myprysm.PubSub.AzureStorageQueue.AzureStorageQueueBrokerConnection').

<a name='Myprysm.PubSub.AzureStorageQueue.DependencyInjection.AddPubSubAzureStorageQueue(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Action_Myprysm.PubSub.AzureStorageQueue.AzureStorageQueuePubSubOptions_).configure'></a>

`configure` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[AzureStorageQueuePubSubOptions](Myprysm.PubSub.AzureStorageQueue.AzureStorageQueuePubSubOptions.md 'Myprysm.PubSub.AzureStorageQueue.AzureStorageQueuePubSubOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The configuration action.

#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection for fluent APIs.