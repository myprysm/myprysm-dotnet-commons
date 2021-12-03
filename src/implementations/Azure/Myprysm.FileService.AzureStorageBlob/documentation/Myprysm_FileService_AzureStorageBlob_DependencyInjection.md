#### [Myprysm.FileService.AzureStorageBlob](index.md 'index')
### [Myprysm.FileService.AzureStorageBlob](index.md#Myprysm_FileService_AzureStorageBlob 'Myprysm.FileService.AzureStorageBlob')
## DependencyInjection Class
Dependency injection extensions.  
```csharp
public static class DependencyInjection
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DependencyInjection  
### Methods
<a name='Myprysm_FileService_AzureStorageBlob_DependencyInjection_AddFileServiceAzureStorageBlob(Microsoft_Extensions_DependencyInjection_IServiceCollection_Microsoft_Extensions_Configuration_IConfiguration)'></a>
## DependencyInjection.AddFileServiceAzureStorageBlob(IServiceCollection, IConfiguration) Method
Registers a [AzureStorageBlobFileService](Myprysm_FileService_AzureStorageBlob_AzureStorageBlobFileService.md 'Myprysm.FileService.AzureStorageBlob.AzureStorageBlobFileService') in the service collection and configure it from the given configuration section.  
```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddFileServiceAzureStorageBlob(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration configurationSection);
```
#### Parameters
<a name='Myprysm_FileService_AzureStorageBlob_DependencyInjection_AddFileServiceAzureStorageBlob(Microsoft_Extensions_DependencyInjection_IServiceCollection_Microsoft_Extensions_Configuration_IConfiguration)_services'></a>
`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection to register the [AzureStorageBlobFileService](Myprysm_FileService_AzureStorageBlob_AzureStorageBlobFileService.md 'Myprysm.FileService.AzureStorageBlob.AzureStorageBlobFileService').
  
<a name='Myprysm_FileService_AzureStorageBlob_DependencyInjection_AddFileServiceAzureStorageBlob(Microsoft_Extensions_DependencyInjection_IServiceCollection_Microsoft_Extensions_Configuration_IConfiguration)_configurationSection'></a>
`configurationSection` [Microsoft.Extensions.Configuration.IConfiguration](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Configuration.IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration')  
The configuration section.
  
#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection for fluent APIs.
  
<a name='Myprysm_FileService_AzureStorageBlob_DependencyInjection_AddFileServiceAzureStorageBlob(Microsoft_Extensions_DependencyInjection_IServiceCollection_System_Action_Myprysm_FileService_AzureStorageBlob_AzureStorageBlobFileServiceOptions__)'></a>
## DependencyInjection.AddFileServiceAzureStorageBlob(IServiceCollection, Action&lt;AzureStorageBlobFileServiceOptions&gt;?) Method
Registers a [AzureStorageBlobFileService](Myprysm_FileService_AzureStorageBlob_AzureStorageBlobFileService.md 'Myprysm.FileService.AzureStorageBlob.AzureStorageBlobFileService') in the service collection and configure it from the given action.  
```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddFileServiceAzureStorageBlob(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, System.Action<Myprysm.FileService.AzureStorageBlob.AzureStorageBlobFileServiceOptions>? configure=null);
```
#### Parameters
<a name='Myprysm_FileService_AzureStorageBlob_DependencyInjection_AddFileServiceAzureStorageBlob(Microsoft_Extensions_DependencyInjection_IServiceCollection_System_Action_Myprysm_FileService_AzureStorageBlob_AzureStorageBlobFileServiceOptions__)_services'></a>
`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection to register the [AzureStorageBlobFileService](Myprysm_FileService_AzureStorageBlob_AzureStorageBlobFileService.md 'Myprysm.FileService.AzureStorageBlob.AzureStorageBlobFileService').
  
<a name='Myprysm_FileService_AzureStorageBlob_DependencyInjection_AddFileServiceAzureStorageBlob(Microsoft_Extensions_DependencyInjection_IServiceCollection_System_Action_Myprysm_FileService_AzureStorageBlob_AzureStorageBlobFileServiceOptions__)_configure'></a>
`configure` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[AzureStorageBlobFileServiceOptions](Myprysm_FileService_AzureStorageBlob_AzureStorageBlobFileServiceOptions.md 'Myprysm.FileService.AzureStorageBlob.AzureStorageBlobFileServiceOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The configuration action.
  
#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection for fluent APIs.
  
