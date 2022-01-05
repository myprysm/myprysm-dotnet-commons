#### [Myprysm.Converter.SystemTextJson](index.md 'index')
### [Myprysm.Converter.SystemTextJson](index.md#Myprysm_Converter_SystemTextJson 'Myprysm.Converter.SystemTextJson')
## Json Class
Configuration class holding the settings uses for NewtonsoftJson by this [Myprysm.Converter.Abstractions.IConverter](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Converter.Abstractions.IConverter 'Myprysm.Converter.Abstractions.IConverter').  
```csharp
public static class Json
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Json  
### Properties
<a name='Myprysm_Converter_SystemTextJson_Json_DefaultSettings'></a>
## Json.DefaultSettings Property
The default settings used by the converter.  
```csharp
public static System.Text.Json.JsonSerializerOptions DefaultSettings { get; }
```
#### Property Value
[System.Text.Json.JsonSerializerOptions](https://docs.microsoft.com/en-us/dotnet/api/System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions')
  
### Methods
<a name='Myprysm_Converter_SystemTextJson_Json_ConfigureDefaults(System_Text_Json_JsonSerializerOptions)'></a>
## Json.ConfigureDefaults(JsonSerializerOptions) Method
Configure the same defaults as used by this [Myprysm.Converter.Abstractions.IConverter](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Converter.Abstractions.IConverter 'Myprysm.Converter.Abstractions.IConverter') on the given settings.   
```csharp
public static System.Text.Json.JsonSerializerOptions ConfigureDefaults(this System.Text.Json.JsonSerializerOptions settings);
```
#### Parameters
<a name='Myprysm_Converter_SystemTextJson_Json_ConfigureDefaults(System_Text_Json_JsonSerializerOptions)_settings'></a>
`settings` [System.Text.Json.JsonSerializerOptions](https://docs.microsoft.com/en-us/dotnet/api/System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions')  
The settings to configure.
  
#### Returns
[System.Text.Json.JsonSerializerOptions](https://docs.microsoft.com/en-us/dotnet/api/System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions')  
The configured settings for fluent APIs.
  
