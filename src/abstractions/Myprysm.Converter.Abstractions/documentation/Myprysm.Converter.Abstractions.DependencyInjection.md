#### [Myprysm.Converter.Abstractions](index.md 'index')
### [Myprysm.Converter.Abstractions](index.md#Myprysm.Converter.Abstractions 'Myprysm.Converter.Abstractions')

## DependencyInjection Class

Dependency injection extensions

```csharp
public static class DependencyInjection
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DependencyInjection
### Methods

<a name='Myprysm.Converter.Abstractions.DependencyInjection.CreateConverter_TOptions_(thisSystem.IServiceProvider,Myprysm.Tracing.Abstractions.TracerIdentity,System.Func_System.IServiceProvider,Myprysm.Converter.Abstractions.IConverter_)'></a>

## DependencyInjection.CreateConverter<TOptions>(this IServiceProvider, TracerIdentity, Func<IServiceProvider,IConverter>) Method

Create a converter with optional tracing.

```csharp
public static Myprysm.Converter.Abstractions.IConverter CreateConverter<TOptions>(this System.IServiceProvider provider, Myprysm.Tracing.Abstractions.TracerIdentity identity, System.Func<System.IServiceProvider,Myprysm.Converter.Abstractions.IConverter> factory)
    where TOptions : Myprysm.Converter.Abstractions.ConverterOptions;
```
#### Type parameters

<a name='Myprysm.Converter.Abstractions.DependencyInjection.CreateConverter_TOptions_(thisSystem.IServiceProvider,Myprysm.Tracing.Abstractions.TracerIdentity,System.Func_System.IServiceProvider,Myprysm.Converter.Abstractions.IConverter_).TOptions'></a>

`TOptions`

The specialized type of [ConverterOptions](Myprysm.Converter.Abstractions.ConverterOptions.md 'Myprysm.Converter.Abstractions.ConverterOptions').
#### Parameters

<a name='Myprysm.Converter.Abstractions.DependencyInjection.CreateConverter_TOptions_(thisSystem.IServiceProvider,Myprysm.Tracing.Abstractions.TracerIdentity,System.Func_System.IServiceProvider,Myprysm.Converter.Abstractions.IConverter_).provider'></a>

`provider` [System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider')

The service provider.

<a name='Myprysm.Converter.Abstractions.DependencyInjection.CreateConverter_TOptions_(thisSystem.IServiceProvider,Myprysm.Tracing.Abstractions.TracerIdentity,System.Func_System.IServiceProvider,Myprysm.Converter.Abstractions.IConverter_).identity'></a>

`identity` [Myprysm.Tracing.Abstractions.TracerIdentity](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.TracerIdentity 'Myprysm.Tracing.Abstractions.TracerIdentity')

The tracer identity (usually for the implementation library).

<a name='Myprysm.Converter.Abstractions.DependencyInjection.CreateConverter_TOptions_(thisSystem.IServiceProvider,Myprysm.Tracing.Abstractions.TracerIdentity,System.Func_System.IServiceProvider,Myprysm.Converter.Abstractions.IConverter_).factory'></a>

`factory` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[IConverter](Myprysm.Converter.Abstractions.IConverter.md 'Myprysm.Converter.Abstractions.IConverter')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

The converter factory.

#### Returns
[IConverter](Myprysm.Converter.Abstractions.IConverter.md 'Myprysm.Converter.Abstractions.IConverter')  
The converter, optionally decorated with tracing.