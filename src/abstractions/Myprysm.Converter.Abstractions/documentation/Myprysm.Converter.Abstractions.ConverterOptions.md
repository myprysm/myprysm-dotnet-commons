#### [Myprysm.Converter.Abstractions](index.md 'index')
### [Myprysm.Converter.Abstractions](index.md#Myprysm.Converter.Abstractions 'Myprysm.Converter.Abstractions')

## ConverterOptions Class

Base converter options.  
  
You should extend those options and use the dependency injection extensions if you want to enable tracing

```csharp
public class ConverterOptions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ConverterOptions
### Properties

<a name='Myprysm.Converter.Abstractions.ConverterOptions.WithTracing'></a>

## ConverterOptions.WithTracing Property

Enable tracing with the converter implementation.

```csharp
public bool WithTracing { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

### Remarks
Tracing is enabled by default.