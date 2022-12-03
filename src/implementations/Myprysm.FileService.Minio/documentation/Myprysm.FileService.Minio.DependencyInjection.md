#### [Myprysm.FileService.Minio](index.md 'index')
### [Myprysm.FileService.Minio](index.md#Myprysm.FileService.Minio 'Myprysm.FileService.Minio')

## DependencyInjection Class

Dependency injection extensions.

```csharp
public static class DependencyInjection
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DependencyInjection
### Methods

<a name='Myprysm.FileService.Minio.DependencyInjection.AddMinioFileService(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.Configuration.IConfiguration)'></a>

## DependencyInjection.AddMinioFileService(this IServiceCollection, IConfiguration) Method

Registers a [MinioFileService](Myprysm.FileService.Minio.MinioFileService.md 'Myprysm.FileService.Minio.MinioFileService') in the service collection and configure it from the given configuration section.

```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddMinioFileService(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration configurationSection);
```
#### Parameters

<a name='Myprysm.FileService.Minio.DependencyInjection.AddMinioFileService(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.Configuration.IConfiguration).services'></a>

`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')

The service collection to register the [MinioFileService](Myprysm.FileService.Minio.MinioFileService.md 'Myprysm.FileService.Minio.MinioFileService').

<a name='Myprysm.FileService.Minio.DependencyInjection.AddMinioFileService(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.Configuration.IConfiguration).configurationSection'></a>

`configurationSection` [Microsoft.Extensions.Configuration.IConfiguration](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Configuration.IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration')

The configuration section.

#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection for fluent APIs.

<a name='Myprysm.FileService.Minio.DependencyInjection.AddMinioFileService(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Action_Myprysm.FileService.Minio.MinioFileServiceOptions_)'></a>

## DependencyInjection.AddMinioFileService(this IServiceCollection, Action<MinioFileServiceOptions>) Method

Registers a [MinioFileService](Myprysm.FileService.Minio.MinioFileService.md 'Myprysm.FileService.Minio.MinioFileService') in the service collection and configure it from the given action.

```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddMinioFileService(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, System.Action<Myprysm.FileService.Minio.MinioFileServiceOptions>? configure=null);
```
#### Parameters

<a name='Myprysm.FileService.Minio.DependencyInjection.AddMinioFileService(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Action_Myprysm.FileService.Minio.MinioFileServiceOptions_).services'></a>

`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')

The service collection to register the [MinioFileService](Myprysm.FileService.Minio.MinioFileService.md 'Myprysm.FileService.Minio.MinioFileService').

<a name='Myprysm.FileService.Minio.DependencyInjection.AddMinioFileService(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Action_Myprysm.FileService.Minio.MinioFileServiceOptions_).configure'></a>

`configure` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[MinioFileServiceOptions](Myprysm.FileService.Minio.MinioFileServiceOptions.md 'Myprysm.FileService.Minio.MinioFileServiceOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The configuration action.

#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection for fluent APIs.