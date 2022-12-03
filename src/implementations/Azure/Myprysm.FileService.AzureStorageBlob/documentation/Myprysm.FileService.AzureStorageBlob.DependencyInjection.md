#### [Myprysm.FileService.AzureStorageBlob](index.md 'index')
### [Myprysm.FileService.AzureStorageBlob](index.md#Myprysm.FileService.AzureStorageBlob 'Myprysm.FileService.AzureStorageBlob')

## DependencyInjection Class

Dependency injection extensions.

```csharp
public static class DependencyInjection
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DependencyInjection
### Methods

<a name='Myprysm.FileService.AzureStorageBlob.DependencyInjection.AddFileServiceAzureStorageBlob(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.Configuration.IConfiguration)'></a>

## DependencyInjection.AddFileServiceAzureStorageBlob(this IServiceCollection, IConfiguration) Method

Registers a [AzureStorageBlobFileService](Myprysm.FileService.AzureStorageBlob.AzureStorageBlobFileService.md 'Myprysm.FileService.AzureStorageBlob.AzureStorageBlobFileService') in the service collection and configure it from the given configuration section.

```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddFileServiceAzureStorageBlob(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration configurationSection);
```
#### Parameters

<a name='Myprysm.FileService.AzureStorageBlob.DependencyInjection.AddFileServiceAzureStorageBlob(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.Configuration.IConfiguration).services'></a>

`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')

The service collection to register the [AzureStorageBlobFileService](Myprysm.FileService.AzureStorageBlob.AzureStorageBlobFileService.md 'Myprysm.FileService.AzureStorageBlob.AzureStorageBlobFileService').

<a name='Myprysm.FileService.AzureStorageBlob.DependencyInjection.AddFileServiceAzureStorageBlob(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.Configuration.IConfiguration).configurationSection'></a>

`configurationSection` [Microsoft.Extensions.Configuration.IConfiguration](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Configuration.IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration')

The configuration section.

#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection for fluent APIs.

<a name='Myprysm.FileService.AzureStorageBlob.DependencyInjection.AddFileServiceAzureStorageBlob(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Action_Myprysm.FileService.AzureStorageBlob.AzureStorageBlobFileServiceOptions_)'></a>

## DependencyInjection.AddFileServiceAzureStorageBlob(this IServiceCollection, Action<AzureStorageBlobFileServiceOptions>) Method

Registers a [AzureStorageBlobFileService](Myprysm.FileService.AzureStorageBlob.AzureStorageBlobFileService.md 'Myprysm.FileService.AzureStorageBlob.AzureStorageBlobFileService') in the service collection and configure it from the given action.

```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddFileServiceAzureStorageBlob(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, System.Action<Myprysm.FileService.AzureStorageBlob.AzureStorageBlobFileServiceOptions>? configure=null);
```
#### Parameters

<a name='Myprysm.FileService.AzureStorageBlob.DependencyInjection.AddFileServiceAzureStorageBlob(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Action_Myprysm.FileService.AzureStorageBlob.AzureStorageBlobFileServiceOptions_).services'></a>

`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')

The service collection to register the [AzureStorageBlobFileService](Myprysm.FileService.AzureStorageBlob.AzureStorageBlobFileService.md 'Myprysm.FileService.AzureStorageBlob.AzureStorageBlobFileService').

<a name='Myprysm.FileService.AzureStorageBlob.DependencyInjection.AddFileServiceAzureStorageBlob(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Action_Myprysm.FileService.AzureStorageBlob.AzureStorageBlobFileServiceOptions_).configure'></a>

`configure` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[AzureStorageBlobFileServiceOptions](Myprysm.FileService.AzureStorageBlob.AzureStorageBlobFileServiceOptions.md 'Myprysm.FileService.AzureStorageBlob.AzureStorageBlobFileServiceOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The configuration action.

#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection for fluent APIs.