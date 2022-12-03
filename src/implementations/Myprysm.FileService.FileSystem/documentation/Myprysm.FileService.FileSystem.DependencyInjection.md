#### [Myprysm.FileService.FileSystem](index.md 'index')
### [Myprysm.FileService.FileSystem](index.md#Myprysm.FileService.FileSystem 'Myprysm.FileService.FileSystem')

## DependencyInjection Class

Dependency injection extensions.

```csharp
public static class DependencyInjection
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DependencyInjection
### Methods

<a name='Myprysm.FileService.FileSystem.DependencyInjection.AddFileSystemFileService(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.Configuration.IConfiguration)'></a>

## DependencyInjection.AddFileSystemFileService(this IServiceCollection, IConfiguration) Method

Registers a [FileSystemFileService](Myprysm.FileService.FileSystem.FileSystemFileService.md 'Myprysm.FileService.FileSystem.FileSystemFileService') in the service collection and configure it from the given configuration section.

```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddFileSystemFileService(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration configurationSection);
```
#### Parameters

<a name='Myprysm.FileService.FileSystem.DependencyInjection.AddFileSystemFileService(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.Configuration.IConfiguration).services'></a>

`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')

The service collection to register the [FileSystemFileService](Myprysm.FileService.FileSystem.FileSystemFileService.md 'Myprysm.FileService.FileSystem.FileSystemFileService').

<a name='Myprysm.FileService.FileSystem.DependencyInjection.AddFileSystemFileService(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.Configuration.IConfiguration).configurationSection'></a>

`configurationSection` [Microsoft.Extensions.Configuration.IConfiguration](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Configuration.IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration')

The configuration section.

#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection for fluent APIs.

<a name='Myprysm.FileService.FileSystem.DependencyInjection.AddFileSystemFileService(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Action_Myprysm.FileService.FileSystem.FileSystemFileServiceOptions_)'></a>

## DependencyInjection.AddFileSystemFileService(this IServiceCollection, Action<FileSystemFileServiceOptions>) Method

Registers a [FileSystemFileService](Myprysm.FileService.FileSystem.FileSystemFileService.md 'Myprysm.FileService.FileSystem.FileSystemFileService') in the service collection and configure it from the given action.

```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddFileSystemFileService(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, System.Action<Myprysm.FileService.FileSystem.FileSystemFileServiceOptions> configure);
```
#### Parameters

<a name='Myprysm.FileService.FileSystem.DependencyInjection.AddFileSystemFileService(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Action_Myprysm.FileService.FileSystem.FileSystemFileServiceOptions_).services'></a>

`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')

The service collection to register the [FileSystemFileService](Myprysm.FileService.FileSystem.FileSystemFileService.md 'Myprysm.FileService.FileSystem.FileSystemFileService').

<a name='Myprysm.FileService.FileSystem.DependencyInjection.AddFileSystemFileService(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Action_Myprysm.FileService.FileSystem.FileSystemFileServiceOptions_).configure'></a>

`configure` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[FileSystemFileServiceOptions](Myprysm.FileService.FileSystem.FileSystemFileServiceOptions.md 'Myprysm.FileService.FileSystem.FileSystemFileServiceOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The configuration action.

#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection for fluent APIs.