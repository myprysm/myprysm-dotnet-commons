#### [Myprysm.PubSub.AzureStorageQueue](index.md 'index')
### [Myprysm.PubSub.AzureStorageQueue](index.md#Myprysm_PubSub_AzureStorageQueue 'Myprysm.PubSub.AzureStorageQueue')
## DependencyInjection Class
Dependency injection extensions.  
```csharp
public static class DependencyInjection
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DependencyInjection  
### Methods
<a name='Myprysm_PubSub_AzureStorageQueue_DependencyInjection_AddPubSubAzureStorageQueue(Microsoft_Extensions_DependencyInjection_IServiceCollection_Microsoft_Extensions_Configuration_IConfiguration)'></a>
## DependencyInjection.AddPubSubAzureStorageQueue(IServiceCollection, IConfiguration) Method
Registers a [AzureStorageQueueBrokerConnection](Myprysm_PubSub_AzureStorageQueue_AzureStorageQueueBrokerConnection.md 'Myprysm.PubSub.AzureStorageQueue.AzureStorageQueueBrokerConnection') in the service collection and configure it from the given configuration section.  
```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddPubSubAzureStorageQueue(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration configurationSection);
```
#### Parameters
<a name='Myprysm_PubSub_AzureStorageQueue_DependencyInjection_AddPubSubAzureStorageQueue(Microsoft_Extensions_DependencyInjection_IServiceCollection_Microsoft_Extensions_Configuration_IConfiguration)_services'></a>
`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection to register the [AzureStorageQueueBrokerConnection](Myprysm_PubSub_AzureStorageQueue_AzureStorageQueueBrokerConnection.md 'Myprysm.PubSub.AzureStorageQueue.AzureStorageQueueBrokerConnection').
  
<a name='Myprysm_PubSub_AzureStorageQueue_DependencyInjection_AddPubSubAzureStorageQueue(Microsoft_Extensions_DependencyInjection_IServiceCollection_Microsoft_Extensions_Configuration_IConfiguration)_configurationSection'></a>
`configurationSection` [Microsoft.Extensions.Configuration.IConfiguration](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Configuration.IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration')  
The configuration section.
  
#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection for fluent APIs.
  
<a name='Myprysm_PubSub_AzureStorageQueue_DependencyInjection_AddPubSubAzureStorageQueue(Microsoft_Extensions_DependencyInjection_IServiceCollection_System_Action_Myprysm_PubSub_AzureStorageQueue_AzureStorageQueuePubSubOptions__)'></a>
## DependencyInjection.AddPubSubAzureStorageQueue(IServiceCollection, Action&lt;AzureStorageQueuePubSubOptions&gt;?) Method
Registers a [AzureStorageQueueBrokerConnection](Myprysm_PubSub_AzureStorageQueue_AzureStorageQueueBrokerConnection.md 'Myprysm.PubSub.AzureStorageQueue.AzureStorageQueueBrokerConnection') in the service collection and configure it from the given action.  
```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddPubSubAzureStorageQueue(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, System.Action<Myprysm.PubSub.AzureStorageQueue.AzureStorageQueuePubSubOptions>? configure=null);
```
#### Parameters
<a name='Myprysm_PubSub_AzureStorageQueue_DependencyInjection_AddPubSubAzureStorageQueue(Microsoft_Extensions_DependencyInjection_IServiceCollection_System_Action_Myprysm_PubSub_AzureStorageQueue_AzureStorageQueuePubSubOptions__)_services'></a>
`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection to register the [AzureStorageQueueBrokerConnection](Myprysm_PubSub_AzureStorageQueue_AzureStorageQueueBrokerConnection.md 'Myprysm.PubSub.AzureStorageQueue.AzureStorageQueueBrokerConnection').
  
<a name='Myprysm_PubSub_AzureStorageQueue_DependencyInjection_AddPubSubAzureStorageQueue(Microsoft_Extensions_DependencyInjection_IServiceCollection_System_Action_Myprysm_PubSub_AzureStorageQueue_AzureStorageQueuePubSubOptions__)_configure'></a>
`configure` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[AzureStorageQueuePubSubOptions](Myprysm_PubSub_AzureStorageQueue_AzureStorageQueuePubSubOptions.md 'Myprysm.PubSub.AzureStorageQueue.AzureStorageQueuePubSubOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The configuration action.
  
#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection for fluent APIs.
  
