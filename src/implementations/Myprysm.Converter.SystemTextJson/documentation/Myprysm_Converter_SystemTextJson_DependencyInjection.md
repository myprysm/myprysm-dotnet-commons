#### [Myprysm.Converter.SystemTextJson](index.md 'index')
### [Myprysm.Converter.SystemTextJson](index.md#Myprysm_Converter_SystemTextJson 'Myprysm.Converter.SystemTextJson')
## DependencyInjection Class
Dependency injection extensions.  
```csharp
public static class DependencyInjection
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DependencyInjection  
### Methods
<a name='Myprysm_Converter_SystemTextJson_DependencyInjection_AddSystemTextJsonConverter(Microsoft_Extensions_DependencyInjection_IServiceCollection_Microsoft_Extensions_Configuration_IConfiguration_System_Action_System_Text_Json_JsonSerializerOptions__)'></a>
## DependencyInjection.AddSystemTextJsonConverter(IServiceCollection, IConfiguration, Action&lt;JsonSerializerOptions&gt;?) Method
Adds a SystemTextJson [Myprysm.Converter.Abstractions.IConverter](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Converter.Abstractions.IConverter 'Myprysm.Converter.Abstractions.IConverter') with the provided configuration section  
and customize the [System.Text.Json.JsonSerializerOptions](https://docs.microsoft.com/en-us/dotnet/api/System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions').  
```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddSystemTextJsonConverter(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration configurationSection, System.Action<System.Text.Json.JsonSerializerOptions>? configureJson=null);
```
#### Parameters
<a name='Myprysm_Converter_SystemTextJson_DependencyInjection_AddSystemTextJsonConverter(Microsoft_Extensions_DependencyInjection_IServiceCollection_Microsoft_Extensions_Configuration_IConfiguration_System_Action_System_Text_Json_JsonSerializerOptions__)_services'></a>
`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection.
  
<a name='Myprysm_Converter_SystemTextJson_DependencyInjection_AddSystemTextJsonConverter(Microsoft_Extensions_DependencyInjection_IServiceCollection_Microsoft_Extensions_Configuration_IConfiguration_System_Action_System_Text_Json_JsonSerializerOptions__)_configurationSection'></a>
`configurationSection` [Microsoft.Extensions.Configuration.IConfiguration](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Configuration.IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration')  
The configuration section.
  
<a name='Myprysm_Converter_SystemTextJson_DependencyInjection_AddSystemTextJsonConverter(Microsoft_Extensions_DependencyInjection_IServiceCollection_Microsoft_Extensions_Configuration_IConfiguration_System_Action_System_Text_Json_JsonSerializerOptions__)_configureJson'></a>
`configureJson` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Text.Json.JsonSerializerOptions](https://docs.microsoft.com/en-us/dotnet/api/System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The [System.Text.Json.JsonSerializerOptions](https://docs.microsoft.com/en-us/dotnet/api/System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') configuration action.
  
#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection.
  
<a name='Myprysm_Converter_SystemTextJson_DependencyInjection_AddSystemTextJsonConverter(Microsoft_Extensions_DependencyInjection_IServiceCollection_System_Action_Myprysm_Converter_SystemTextJson_SystemTextJsonConverterOptions__System_Action_System_Text_Json_JsonSerializerOptions__)'></a>
## DependencyInjection.AddSystemTextJsonConverter(IServiceCollection, Action&lt;SystemTextJsonConverterOptions&gt;, Action&lt;JsonSerializerOptions&gt;?) Method
Adds a SystemTextJson [Myprysm.Converter.Abstractions.IConverter](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Converter.Abstractions.IConverter 'Myprysm.Converter.Abstractions.IConverter')
```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddSystemTextJsonConverter(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, System.Action<Myprysm.Converter.SystemTextJson.SystemTextJsonConverterOptions> configureOptions, System.Action<System.Text.Json.JsonSerializerOptions>? configureJson=null);
```
#### Parameters
<a name='Myprysm_Converter_SystemTextJson_DependencyInjection_AddSystemTextJsonConverter(Microsoft_Extensions_DependencyInjection_IServiceCollection_System_Action_Myprysm_Converter_SystemTextJson_SystemTextJsonConverterOptions__System_Action_System_Text_Json_JsonSerializerOptions__)_services'></a>
`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection.
  
<a name='Myprysm_Converter_SystemTextJson_DependencyInjection_AddSystemTextJsonConverter(Microsoft_Extensions_DependencyInjection_IServiceCollection_System_Action_Myprysm_Converter_SystemTextJson_SystemTextJsonConverterOptions__System_Action_System_Text_Json_JsonSerializerOptions__)_configureOptions'></a>
`configureOptions` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[SystemTextJsonConverterOptions](Myprysm_Converter_SystemTextJson_SystemTextJsonConverterOptions.md 'Myprysm.Converter.SystemTextJson.SystemTextJsonConverterOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The options configuration action.
  
<a name='Myprysm_Converter_SystemTextJson_DependencyInjection_AddSystemTextJsonConverter(Microsoft_Extensions_DependencyInjection_IServiceCollection_System_Action_Myprysm_Converter_SystemTextJson_SystemTextJsonConverterOptions__System_Action_System_Text_Json_JsonSerializerOptions__)_configureJson'></a>
`configureJson` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Text.Json.JsonSerializerOptions](https://docs.microsoft.com/en-us/dotnet/api/System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The serializer options configuration.
  
#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
  
<a name='Myprysm_Converter_SystemTextJson_DependencyInjection_AddSystemTextJsonConverter(Microsoft_Extensions_DependencyInjection_IServiceCollection_System_Action_System_Text_Json_JsonSerializerOptions_)'></a>
## DependencyInjection.AddSystemTextJsonConverter(IServiceCollection, Action&lt;JsonSerializerOptions&gt;) Method
Adds a SystemTextJson [Myprysm.Converter.Abstractions.IConverter](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Converter.Abstractions.IConverter 'Myprysm.Converter.Abstractions.IConverter') and customize the [System.Text.Json.JsonSerializerOptions](https://docs.microsoft.com/en-us/dotnet/api/System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions').  
```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddSystemTextJsonConverter(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, System.Action<System.Text.Json.JsonSerializerOptions> configure);
```
#### Parameters
<a name='Myprysm_Converter_SystemTextJson_DependencyInjection_AddSystemTextJsonConverter(Microsoft_Extensions_DependencyInjection_IServiceCollection_System_Action_System_Text_Json_JsonSerializerOptions_)_services'></a>
`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection.
  
<a name='Myprysm_Converter_SystemTextJson_DependencyInjection_AddSystemTextJsonConverter(Microsoft_Extensions_DependencyInjection_IServiceCollection_System_Action_System_Text_Json_JsonSerializerOptions_)_configure'></a>
`configure` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Text.Json.JsonSerializerOptions](https://docs.microsoft.com/en-us/dotnet/api/System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The [System.Text.Json.JsonSerializerOptions](https://docs.microsoft.com/en-us/dotnet/api/System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') configuration action.
  
#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection.
  
<a name='Myprysm_Converter_SystemTextJson_DependencyInjection_AddSystemTextJsonConverter(Microsoft_Extensions_DependencyInjection_IServiceCollection)'></a>
## DependencyInjection.AddSystemTextJsonConverter(IServiceCollection) Method
Adds a SystemTextJson [Myprysm.Converter.Abstractions.IConverter](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Converter.Abstractions.IConverter 'Myprysm.Converter.Abstractions.IConverter') with default settings.  
```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddSystemTextJsonConverter(this Microsoft.Extensions.DependencyInjection.IServiceCollection services);
```
#### Parameters
<a name='Myprysm_Converter_SystemTextJson_DependencyInjection_AddSystemTextJsonConverter(Microsoft_Extensions_DependencyInjection_IServiceCollection)_services'></a>
`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection.
  
#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection.
  
