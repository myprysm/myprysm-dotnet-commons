#### [Myprysm.Converter.SystemTextJson](index.md 'index')
### [Myprysm.Converter.SystemTextJson](index.md#Myprysm.Converter.SystemTextJson 'Myprysm.Converter.SystemTextJson')

## SystemTextJsonConverterOptions Class

Options for the System.Text.Json [Myprysm.Converter.Abstractions.IConverter](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Converter.Abstractions.IConverter 'Myprysm.Converter.Abstractions.IConverter').

```csharp
public class SystemTextJsonConverterOptions : Myprysm.Converter.Abstractions.ConverterOptions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Myprysm.Converter.Abstractions.ConverterOptions](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Converter.Abstractions.ConverterOptions 'Myprysm.Converter.Abstractions.ConverterOptions') &#129106; SystemTextJsonConverterOptions
### Properties

<a name='Myprysm.Converter.SystemTextJson.SystemTextJsonConverterOptions.JsonSerializerSettings'></a>

## SystemTextJsonConverterOptions.JsonSerializerSettings Property

Gets or sets the settings used by System.Text.Json for serialization.

```csharp
public System.Text.Json.JsonSerializerOptions JsonSerializerSettings { get; set; }
```

#### Property Value
[System.Text.Json.JsonSerializerOptions](https://docs.microsoft.com/en-us/dotnet/api/System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions')