#### [Myprysm.ImageService.Abstractions](index.md 'index')
### [Myprysm.ImageService.Abstractions](index.md#Myprysm_ImageService_Abstractions 'Myprysm.ImageService.Abstractions')
## DependencyInjection Class
Dependency injection extensions.  
```csharp
public static class DependencyInjection
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DependencyInjection  
### Methods
<a name='Myprysm_ImageService_Abstractions_DependencyInjection_CreateImageService_TOptions_(System_IServiceProvider_Myprysm_Tracing_Abstractions_TracerIdentity_System_Func_System_IServiceProvider_Myprysm_ImageService_Abstractions_IImageService_)'></a>
## DependencyInjection.CreateImageService&lt;TOptions&gt;(IServiceProvider, TracerIdentity, Func&lt;IServiceProvider,IImageService&gt;) Method
Create an image service with optional tracing.  
```csharp
public static Myprysm.ImageService.Abstractions.IImageService CreateImageService<TOptions>(this System.IServiceProvider provider, Myprysm.Tracing.Abstractions.TracerIdentity identity, System.Func<System.IServiceProvider,Myprysm.ImageService.Abstractions.IImageService> factory)
    where TOptions : Myprysm.ImageService.Abstractions.ImageServiceOptions;
```
#### Type parameters
<a name='Myprysm_ImageService_Abstractions_DependencyInjection_CreateImageService_TOptions_(System_IServiceProvider_Myprysm_Tracing_Abstractions_TracerIdentity_System_Func_System_IServiceProvider_Myprysm_ImageService_Abstractions_IImageService_)_TOptions'></a>
`TOptions`  
The specialized type of [ImageServiceOptions](Myprysm_ImageService_Abstractions_ImageServiceOptions.md 'Myprysm.ImageService.Abstractions.ImageServiceOptions').
  
#### Parameters
<a name='Myprysm_ImageService_Abstractions_DependencyInjection_CreateImageService_TOptions_(System_IServiceProvider_Myprysm_Tracing_Abstractions_TracerIdentity_System_Func_System_IServiceProvider_Myprysm_ImageService_Abstractions_IImageService_)_provider'></a>
`provider` [System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider')  
The service provider.
  
<a name='Myprysm_ImageService_Abstractions_DependencyInjection_CreateImageService_TOptions_(System_IServiceProvider_Myprysm_Tracing_Abstractions_TracerIdentity_System_Func_System_IServiceProvider_Myprysm_ImageService_Abstractions_IImageService_)_identity'></a>
`identity` [Myprysm.Tracing.Abstractions.TracerIdentity](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.TracerIdentity 'Myprysm.Tracing.Abstractions.TracerIdentity')  
The tracer identity (usually for the implementation library).
  
<a name='Myprysm_ImageService_Abstractions_DependencyInjection_CreateImageService_TOptions_(System_IServiceProvider_Myprysm_Tracing_Abstractions_TracerIdentity_System_Func_System_IServiceProvider_Myprysm_ImageService_Abstractions_IImageService_)_factory'></a>
`factory` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[IImageService](Myprysm_ImageService_Abstractions_IImageService.md 'Myprysm.ImageService.Abstractions.IImageService')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The image service factory.
  
#### Returns
[IImageService](Myprysm_ImageService_Abstractions_IImageService.md 'Myprysm.ImageService.Abstractions.IImageService')  
The image service, optionally decorated with tracing.
  
