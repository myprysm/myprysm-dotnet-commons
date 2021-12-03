#### [Myprysm.Converter.Abstractions](index.md 'index')
### [Myprysm.Converter.Abstractions](index.md#Myprysm_Converter_Abstractions 'Myprysm.Converter.Abstractions')
## DependencyInjection Class
Dependency injection extensions  
```csharp
public static class DependencyInjection
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DependencyInjection  
### Methods
<a name='Myprysm_Converter_Abstractions_DependencyInjection_CreateConverter_TOptions_(System_IServiceProvider_Myprysm_Tracing_Abstractions_TracerIdentity_System_Func_System_IServiceProvider_Myprysm_Converter_Abstractions_IConverter_)'></a>
## DependencyInjection.CreateConverter&lt;TOptions&gt;(IServiceProvider, TracerIdentity, Func&lt;IServiceProvider,IConverter&gt;) Method
Create a converter with optional tracing.  
```csharp
public static Myprysm.Converter.Abstractions.IConverter CreateConverter<TOptions>(this System.IServiceProvider provider, Myprysm.Tracing.Abstractions.TracerIdentity identity, System.Func<System.IServiceProvider,Myprysm.Converter.Abstractions.IConverter> factory)
    where TOptions : Myprysm.Converter.Abstractions.ConverterOptions;
```
#### Type parameters
<a name='Myprysm_Converter_Abstractions_DependencyInjection_CreateConverter_TOptions_(System_IServiceProvider_Myprysm_Tracing_Abstractions_TracerIdentity_System_Func_System_IServiceProvider_Myprysm_Converter_Abstractions_IConverter_)_TOptions'></a>
`TOptions`  
The specialized type of [ConverterOptions](Myprysm_Converter_Abstractions_ConverterOptions.md 'Myprysm.Converter.Abstractions.ConverterOptions').
  
#### Parameters
<a name='Myprysm_Converter_Abstractions_DependencyInjection_CreateConverter_TOptions_(System_IServiceProvider_Myprysm_Tracing_Abstractions_TracerIdentity_System_Func_System_IServiceProvider_Myprysm_Converter_Abstractions_IConverter_)_provider'></a>
`provider` [System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider')  
The service provider.
  
<a name='Myprysm_Converter_Abstractions_DependencyInjection_CreateConverter_TOptions_(System_IServiceProvider_Myprysm_Tracing_Abstractions_TracerIdentity_System_Func_System_IServiceProvider_Myprysm_Converter_Abstractions_IConverter_)_identity'></a>
`identity` [Myprysm.Tracing.Abstractions.TracerIdentity](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.TracerIdentity 'Myprysm.Tracing.Abstractions.TracerIdentity')  
The tracer identity (usually for the implementation library).
  
<a name='Myprysm_Converter_Abstractions_DependencyInjection_CreateConverter_TOptions_(System_IServiceProvider_Myprysm_Tracing_Abstractions_TracerIdentity_System_Func_System_IServiceProvider_Myprysm_Converter_Abstractions_IConverter_)_factory'></a>
`factory` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[IConverter](Myprysm_Converter_Abstractions_IConverter.md 'Myprysm.Converter.Abstractions.IConverter')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
The converter factory.
  
#### Returns
[IConverter](Myprysm_Converter_Abstractions_IConverter.md 'Myprysm.Converter.Abstractions.IConverter')  
The converter, optionally decorated with tracing.
  
