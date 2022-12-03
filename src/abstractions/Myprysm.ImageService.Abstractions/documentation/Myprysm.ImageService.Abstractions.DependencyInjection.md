#### [Myprysm.ImageService.Abstractions](index.md 'index')
### [Myprysm.ImageService.Abstractions](index.md#Myprysm.ImageService.Abstractions 'Myprysm.ImageService.Abstractions')

## DependencyInjection Class

Dependency injection extensions.

```csharp
public static class DependencyInjection
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DependencyInjection
### Methods

<a name='Myprysm.ImageService.Abstractions.DependencyInjection.CreateImageService_TOptions_(thisSystem.IServiceProvider,Myprysm.Tracing.Abstractions.TracerIdentity,System.Func_System.IServiceProvider,Myprysm.ImageService.Abstractions.IImageService_)'></a>

## DependencyInjection.CreateImageService<TOptions>(this IServiceProvider, TracerIdentity, Func<IServiceProvider,IImageService>) Method

Create an image service with optional tracing.

```csharp
public static Myprysm.ImageService.Abstractions.IImageService CreateImageService<TOptions>(this System.IServiceProvider provider, Myprysm.Tracing.Abstractions.TracerIdentity identity, System.Func<System.IServiceProvider,Myprysm.ImageService.Abstractions.IImageService> factory)
    where TOptions : Myprysm.ImageService.Abstractions.ImageServiceOptions;
```
#### Type parameters

<a name='Myprysm.ImageService.Abstractions.DependencyInjection.CreateImageService_TOptions_(thisSystem.IServiceProvider,Myprysm.Tracing.Abstractions.TracerIdentity,System.Func_System.IServiceProvider,Myprysm.ImageService.Abstractions.IImageService_).TOptions'></a>

`TOptions`

The specialized type of [ImageServiceOptions](Myprysm.ImageService.Abstractions.ImageServiceOptions.md 'Myprysm.ImageService.Abstractions.ImageServiceOptions').
#### Parameters

<a name='Myprysm.ImageService.Abstractions.DependencyInjection.CreateImageService_TOptions_(thisSystem.IServiceProvider,Myprysm.Tracing.Abstractions.TracerIdentity,System.Func_System.IServiceProvider,Myprysm.ImageService.Abstractions.IImageService_).provider'></a>

`provider` [System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider')

The service provider.

<a name='Myprysm.ImageService.Abstractions.DependencyInjection.CreateImageService_TOptions_(thisSystem.IServiceProvider,Myprysm.Tracing.Abstractions.TracerIdentity,System.Func_System.IServiceProvider,Myprysm.ImageService.Abstractions.IImageService_).identity'></a>

`identity` [Myprysm.Tracing.Abstractions.TracerIdentity](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.TracerIdentity 'Myprysm.Tracing.Abstractions.TracerIdentity')

The tracer identity (usually for the implementation library).

<a name='Myprysm.ImageService.Abstractions.DependencyInjection.CreateImageService_TOptions_(thisSystem.IServiceProvider,Myprysm.Tracing.Abstractions.TracerIdentity,System.Func_System.IServiceProvider,Myprysm.ImageService.Abstractions.IImageService_).factory'></a>

`factory` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[IImageService](Myprysm.ImageService.Abstractions.IImageService.md 'Myprysm.ImageService.Abstractions.IImageService')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

The image service factory.

#### Returns
[IImageService](Myprysm.ImageService.Abstractions.IImageService.md 'Myprysm.ImageService.Abstractions.IImageService')  
The image service, optionally decorated with tracing.