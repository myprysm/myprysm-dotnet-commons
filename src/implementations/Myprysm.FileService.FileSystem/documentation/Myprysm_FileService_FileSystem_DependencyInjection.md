#### [Myprysm.FileService.FileSystem](index.md 'index')
### [Myprysm.FileService.FileSystem](index.md#Myprysm_FileService_FileSystem 'Myprysm.FileService.FileSystem')
## DependencyInjection Class
Dependency injection extensions.  
```csharp
public static class DependencyInjection
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DependencyInjection  
### Methods
<a name='Myprysm_FileService_FileSystem_DependencyInjection_AddFileSystemFileService(Microsoft_Extensions_DependencyInjection_IServiceCollection_Microsoft_Extensions_Configuration_IConfiguration)'></a>
## DependencyInjection.AddFileSystemFileService(IServiceCollection, IConfiguration) Method
Registers a [FileSystemFileService](Myprysm_FileService_FileSystem_FileSystemFileService.md 'Myprysm.FileService.FileSystem.FileSystemFileService') in the service collection and configure it from the given configuration section.  
```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddFileSystemFileService(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration configurationSection);
```
#### Parameters
<a name='Myprysm_FileService_FileSystem_DependencyInjection_AddFileSystemFileService(Microsoft_Extensions_DependencyInjection_IServiceCollection_Microsoft_Extensions_Configuration_IConfiguration)_services'></a>
`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection to register the [FileSystemFileService](Myprysm_FileService_FileSystem_FileSystemFileService.md 'Myprysm.FileService.FileSystem.FileSystemFileService').
  
<a name='Myprysm_FileService_FileSystem_DependencyInjection_AddFileSystemFileService(Microsoft_Extensions_DependencyInjection_IServiceCollection_Microsoft_Extensions_Configuration_IConfiguration)_configurationSection'></a>
`configurationSection` [Microsoft.Extensions.Configuration.IConfiguration](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Configuration.IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration')  
The configuration section.
  
#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection for fluent APIs.
  
<a name='Myprysm_FileService_FileSystem_DependencyInjection_AddFileSystemFileService(Microsoft_Extensions_DependencyInjection_IServiceCollection_System_Action_Myprysm_FileService_FileSystem_FileSystemFileServiceOptions_)'></a>
## DependencyInjection.AddFileSystemFileService(IServiceCollection, Action&lt;FileSystemFileServiceOptions&gt;) Method
Registers a [FileSystemFileService](Myprysm_FileService_FileSystem_FileSystemFileService.md 'Myprysm.FileService.FileSystem.FileSystemFileService') in the service collection and configure it from the given action.  
```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddFileSystemFileService(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, System.Action<Myprysm.FileService.FileSystem.FileSystemFileServiceOptions> configure);
```
#### Parameters
<a name='Myprysm_FileService_FileSystem_DependencyInjection_AddFileSystemFileService(Microsoft_Extensions_DependencyInjection_IServiceCollection_System_Action_Myprysm_FileService_FileSystem_FileSystemFileServiceOptions_)_services'></a>
`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection to register the [FileSystemFileService](Myprysm_FileService_FileSystem_FileSystemFileService.md 'Myprysm.FileService.FileSystem.FileSystemFileService').
  
<a name='Myprysm_FileService_FileSystem_DependencyInjection_AddFileSystemFileService(Microsoft_Extensions_DependencyInjection_IServiceCollection_System_Action_Myprysm_FileService_FileSystem_FileSystemFileServiceOptions_)_configure'></a>
`configure` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[FileSystemFileServiceOptions](Myprysm_FileService_FileSystem_FileSystemFileServiceOptions.md 'Myprysm.FileService.FileSystem.FileSystemFileServiceOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The configuration action.
  
#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection for fluent APIs.
  
