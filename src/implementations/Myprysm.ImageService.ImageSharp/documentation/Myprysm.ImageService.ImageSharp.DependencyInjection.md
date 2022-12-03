#### [Myprysm.ImageService.ImageSharp](index.md 'index')
### [Myprysm.ImageService.ImageSharp](index.md#Myprysm.ImageService.ImageSharp 'Myprysm.ImageService.ImageSharp')

## DependencyInjection Class

Dependency injection extensions.

```csharp
public static class DependencyInjection
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DependencyInjection
### Methods

<a name='Myprysm.ImageService.ImageSharp.DependencyInjection.AddImageSharpImageService(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.Configuration.IConfiguration)'></a>

## DependencyInjection.AddImageSharpImageService(this IServiceCollection, IConfiguration) Method

Registers a [ImageSharpImageService](Myprysm.ImageService.ImageSharp.ImageSharpImageService.md 'Myprysm.ImageService.ImageSharp.ImageSharpImageService') in the service collection and configure it from the given configuration section.

```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddImageSharpImageService(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration configurationSection);
```
#### Parameters

<a name='Myprysm.ImageService.ImageSharp.DependencyInjection.AddImageSharpImageService(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.Configuration.IConfiguration).services'></a>

`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')

The service collection to register the [ImageSharpImageService](Myprysm.ImageService.ImageSharp.ImageSharpImageService.md 'Myprysm.ImageService.ImageSharp.ImageSharpImageService').

<a name='Myprysm.ImageService.ImageSharp.DependencyInjection.AddImageSharpImageService(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.Configuration.IConfiguration).configurationSection'></a>

`configurationSection` [Microsoft.Extensions.Configuration.IConfiguration](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Configuration.IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration')

The configuration section.

#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection for fluent APIs.

<a name='Myprysm.ImageService.ImageSharp.DependencyInjection.AddImageSharpImageService(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Action_Myprysm.ImageService.ImageSharp.ImageSharpImageServiceOptions_)'></a>

## DependencyInjection.AddImageSharpImageService(this IServiceCollection, Action<ImageSharpImageServiceOptions>) Method

Registers a [ImageSharpImageService](Myprysm.ImageService.ImageSharp.ImageSharpImageService.md 'Myprysm.ImageService.ImageSharp.ImageSharpImageService') in the service collection and configure it from the given action.

```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddImageSharpImageService(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, System.Action<Myprysm.ImageService.ImageSharp.ImageSharpImageServiceOptions> configure);
```
#### Parameters

<a name='Myprysm.ImageService.ImageSharp.DependencyInjection.AddImageSharpImageService(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Action_Myprysm.ImageService.ImageSharp.ImageSharpImageServiceOptions_).services'></a>

`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')

The service collection to register the [ImageSharpImageService](Myprysm.ImageService.ImageSharp.ImageSharpImageService.md 'Myprysm.ImageService.ImageSharp.ImageSharpImageService').

<a name='Myprysm.ImageService.ImageSharp.DependencyInjection.AddImageSharpImageService(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Action_Myprysm.ImageService.ImageSharp.ImageSharpImageServiceOptions_).configure'></a>

`configure` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[ImageSharpImageServiceOptions](Myprysm.ImageService.ImageSharp.ImageSharpImageServiceOptions.md 'Myprysm.ImageService.ImageSharp.ImageSharpImageServiceOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The configuration action.

#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection for fluent APIs.

<a name='Myprysm.ImageService.ImageSharp.DependencyInjection.AddImageSharpImageService(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection)'></a>

## DependencyInjection.AddImageSharpImageService(this IServiceCollection) Method

Registers a [ImageSharpImageService](Myprysm.ImageService.ImageSharp.ImageSharpImageService.md 'Myprysm.ImageService.ImageSharp.ImageSharpImageService') in the service collection.

```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddImageSharpImageService(this Microsoft.Extensions.DependencyInjection.IServiceCollection services);
```
#### Parameters

<a name='Myprysm.ImageService.ImageSharp.DependencyInjection.AddImageSharpImageService(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection).services'></a>

`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')

The service collection to register the [ImageSharpImageService](Myprysm.ImageService.ImageSharp.ImageSharpImageService.md 'Myprysm.ImageService.ImageSharp.ImageSharpImageService').

#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection for fluent APIs.