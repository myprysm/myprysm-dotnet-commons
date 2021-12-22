#### [Myprysm.Converter.SystemTextJson.ValueObjects](index.md 'index')
### [Myprysm.Converter.SystemTextJson.ValueObjects](index.md#Myprysm_Converter_SystemTextJson_ValueObjects 'Myprysm.Converter.SystemTextJson.ValueObjects')
## JsonSerializerOptionsExtensions Class
[System.Text.Json.JsonSerializerOptions](https://docs.microsoft.com/en-us/dotnet/api/System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') extensions.  
            
```csharp
public static class JsonSerializerOptionsExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; JsonSerializerOptionsExtensions  
### Methods
<a name='Myprysm_Converter_SystemTextJson_ValueObjects_JsonSerializerOptionsExtensions_ConfigureValueObjectConverters(System_Text_Json_JsonSerializerOptions)'></a>
## JsonSerializerOptionsExtensions.ConfigureValueObjectConverters(JsonSerializerOptions) Method
Configure the [Myprysm.Converter.SystemTextJson.ValueObjects.SingleValueObjectConverter&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Converter.SystemTextJson.ValueObjects.SingleValueObjectConverter-2 'Myprysm.Converter.SystemTextJson.ValueObjects.SingleValueObjectConverter`2') on the given [System.Text.Json.JsonSerializerOptions](https://docs.microsoft.com/en-us/dotnet/api/System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions').  
```csharp
public static System.Text.Json.JsonSerializerOptions ConfigureValueObjectConverters(this System.Text.Json.JsonSerializerOptions settings);
```
#### Parameters
<a name='Myprysm_Converter_SystemTextJson_ValueObjects_JsonSerializerOptionsExtensions_ConfigureValueObjectConverters(System_Text_Json_JsonSerializerOptions)_settings'></a>
`settings` [System.Text.Json.JsonSerializerOptions](https://docs.microsoft.com/en-us/dotnet/api/System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions')  
The settings to configure the [Myprysm.Converter.SystemTextJson.ValueObjects.SingleValueObjectConverterFactory](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Converter.SystemTextJson.ValueObjects.SingleValueObjectConverterFactory 'Myprysm.Converter.SystemTextJson.ValueObjects.SingleValueObjectConverterFactory').
  
#### Returns
[System.Text.Json.JsonSerializerOptions](https://docs.microsoft.com/en-us/dotnet/api/System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions')  
The configured settings for fluent APIs.
  
