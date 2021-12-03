#### [Myprysm.ImageService.ImageSharp](index.md 'index')
### [Myprysm.ImageService.ImageSharp](index.md#Myprysm_ImageService_ImageSharp 'Myprysm.ImageService.ImageSharp')
## DependencyInjection Class
Dependency injection extensions.  
```csharp
public static class DependencyInjection
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DependencyInjection  
### Methods
<a name='Myprysm_ImageService_ImageSharp_DependencyInjection_AddImageSharpImageService(Microsoft_Extensions_DependencyInjection_IServiceCollection_Microsoft_Extensions_Configuration_IConfiguration)'></a>
## DependencyInjection.AddImageSharpImageService(IServiceCollection, IConfiguration) Method
Registers a [ImageSharpImageService](Myprysm_ImageService_ImageSharp_ImageSharpImageService.md 'Myprysm.ImageService.ImageSharp.ImageSharpImageService') in the service collection and configure it from the given configuration section.  
```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddImageSharpImageService(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration configurationSection);
```
#### Parameters
<a name='Myprysm_ImageService_ImageSharp_DependencyInjection_AddImageSharpImageService(Microsoft_Extensions_DependencyInjection_IServiceCollection_Microsoft_Extensions_Configuration_IConfiguration)_services'></a>
`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection to register the [ImageSharpImageService](Myprysm_ImageService_ImageSharp_ImageSharpImageService.md 'Myprysm.ImageService.ImageSharp.ImageSharpImageService').
  
<a name='Myprysm_ImageService_ImageSharp_DependencyInjection_AddImageSharpImageService(Microsoft_Extensions_DependencyInjection_IServiceCollection_Microsoft_Extensions_Configuration_IConfiguration)_configurationSection'></a>
`configurationSection` [Microsoft.Extensions.Configuration.IConfiguration](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Configuration.IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration')  
The configuration section.
  
#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection for fluent APIs.
  
<a name='Myprysm_ImageService_ImageSharp_DependencyInjection_AddImageSharpImageService(Microsoft_Extensions_DependencyInjection_IServiceCollection_Myprysm_ImageService_ImageSharp_MemoryPoolKind)'></a>
## DependencyInjection.AddImageSharpImageService(IServiceCollection, MemoryPoolKind) Method
Registers a [ImageSharpImageService](Myprysm_ImageService_ImageSharp_ImageSharpImageService.md 'Myprysm.ImageService.ImageSharp.ImageSharpImageService') in the service collection and configure it with the given [MemoryPoolKind](Myprysm_ImageService_ImageSharp_MemoryPoolKind.md 'Myprysm.ImageService.ImageSharp.MemoryPoolKind').  
```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddImageSharpImageService(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Myprysm.ImageService.ImageSharp.MemoryPoolKind memoryPool=Myprysm.ImageService.ImageSharp.MemoryPoolKind.Default);
```
#### Parameters
<a name='Myprysm_ImageService_ImageSharp_DependencyInjection_AddImageSharpImageService(Microsoft_Extensions_DependencyInjection_IServiceCollection_Myprysm_ImageService_ImageSharp_MemoryPoolKind)_services'></a>
`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection to register the [ImageSharpImageService](Myprysm_ImageService_ImageSharp_ImageSharpImageService.md 'Myprysm.ImageService.ImageSharp.ImageSharpImageService').
  
<a name='Myprysm_ImageService_ImageSharp_DependencyInjection_AddImageSharpImageService(Microsoft_Extensions_DependencyInjection_IServiceCollection_Myprysm_ImageService_ImageSharp_MemoryPoolKind)_memoryPool'></a>
`memoryPool` [MemoryPoolKind](Myprysm_ImageService_ImageSharp_MemoryPoolKind.md 'Myprysm.ImageService.ImageSharp.MemoryPoolKind')  
The memory pool kind.
  
#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection for fluent APIs.
  
<a name='Myprysm_ImageService_ImageSharp_DependencyInjection_AddImageSharpImageService(Microsoft_Extensions_DependencyInjection_IServiceCollection_System_Action_Myprysm_ImageService_ImageSharp_ImageSharpImageServiceOptions_)'></a>
## DependencyInjection.AddImageSharpImageService(IServiceCollection, Action&lt;ImageSharpImageServiceOptions&gt;) Method
Registers a [ImageSharpImageService](Myprysm_ImageService_ImageSharp_ImageSharpImageService.md 'Myprysm.ImageService.ImageSharp.ImageSharpImageService') in the service collection and configure it from the given action.  
```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddImageSharpImageService(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, System.Action<Myprysm.ImageService.ImageSharp.ImageSharpImageServiceOptions> configure);
```
#### Parameters
<a name='Myprysm_ImageService_ImageSharp_DependencyInjection_AddImageSharpImageService(Microsoft_Extensions_DependencyInjection_IServiceCollection_System_Action_Myprysm_ImageService_ImageSharp_ImageSharpImageServiceOptions_)_services'></a>
`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection to register the [ImageSharpImageService](Myprysm_ImageService_ImageSharp_ImageSharpImageService.md 'Myprysm.ImageService.ImageSharp.ImageSharpImageService').
  
<a name='Myprysm_ImageService_ImageSharp_DependencyInjection_AddImageSharpImageService(Microsoft_Extensions_DependencyInjection_IServiceCollection_System_Action_Myprysm_ImageService_ImageSharp_ImageSharpImageServiceOptions_)_configure'></a>
`configure` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[ImageSharpImageServiceOptions](Myprysm_ImageService_ImageSharp_ImageSharpImageServiceOptions.md 'Myprysm.ImageService.ImageSharp.ImageSharpImageServiceOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The configuration action.
  
#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection for fluent APIs.
  
