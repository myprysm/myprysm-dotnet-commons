#### [Myprysm.Converter.NewtonsoftJson](index.md 'index')
### [Myprysm.Converter.NewtonsoftJson](index.md#Myprysm_Converter_NewtonsoftJson 'Myprysm.Converter.NewtonsoftJson')
## DependencyInjection Class
Dependency injection extensions.  
```csharp
public static class DependencyInjection
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DependencyInjection  
### Methods
<a name='Myprysm_Converter_NewtonsoftJson_DependencyInjection_AddNewtonsoftJsonConverter(Microsoft_Extensions_DependencyInjection_IServiceCollection_Microsoft_Extensions_Configuration_IConfiguration_System_Action_Newtonsoft_Json_JsonSerializerSettings__)'></a>
## DependencyInjection.AddNewtonsoftJsonConverter(IServiceCollection, IConfiguration, Action&lt;JsonSerializerSettings&gt;?) Method
Adds a NewtonsoftJson [Myprysm.Converter.Abstractions.IConverter](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Converter.Abstractions.IConverter 'Myprysm.Converter.Abstractions.IConverter') with the provided configuration section  
and customize the [Newtonsoft.Json.JsonSerializerSettings](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.JsonSerializerSettings 'Newtonsoft.Json.JsonSerializerSettings').  
```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddNewtonsoftJsonConverter(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration configurationSection, System.Action<Newtonsoft.Json.JsonSerializerSettings>? configureJson=null);
```
#### Parameters
<a name='Myprysm_Converter_NewtonsoftJson_DependencyInjection_AddNewtonsoftJsonConverter(Microsoft_Extensions_DependencyInjection_IServiceCollection_Microsoft_Extensions_Configuration_IConfiguration_System_Action_Newtonsoft_Json_JsonSerializerSettings__)_services'></a>
`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection.
  
<a name='Myprysm_Converter_NewtonsoftJson_DependencyInjection_AddNewtonsoftJsonConverter(Microsoft_Extensions_DependencyInjection_IServiceCollection_Microsoft_Extensions_Configuration_IConfiguration_System_Action_Newtonsoft_Json_JsonSerializerSettings__)_configurationSection'></a>
`configurationSection` [Microsoft.Extensions.Configuration.IConfiguration](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Configuration.IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration')  
The configuration section.
  
<a name='Myprysm_Converter_NewtonsoftJson_DependencyInjection_AddNewtonsoftJsonConverter(Microsoft_Extensions_DependencyInjection_IServiceCollection_Microsoft_Extensions_Configuration_IConfiguration_System_Action_Newtonsoft_Json_JsonSerializerSettings__)_configureJson'></a>
`configureJson` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[Newtonsoft.Json.JsonSerializerSettings](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.JsonSerializerSettings 'Newtonsoft.Json.JsonSerializerSettings')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The [Newtonsoft.Json.JsonSerializerSettings](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.JsonSerializerSettings 'Newtonsoft.Json.JsonSerializerSettings') configuration action.
  
#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection.
  
<a name='Myprysm_Converter_NewtonsoftJson_DependencyInjection_AddNewtonsoftJsonConverter(Microsoft_Extensions_DependencyInjection_IServiceCollection_System_Action_Myprysm_Converter_NewtonsoftJson_NewtonsoftJsonConverterOptions__System_Action_Newtonsoft_Json_JsonSerializerSettings__)'></a>
## DependencyInjection.AddNewtonsoftJsonConverter(IServiceCollection, Action&lt;NewtonsoftJsonConverterOptions&gt;, Action&lt;JsonSerializerSettings&gt;?) Method
Adds a NewtonsoftJson [Myprysm.Converter.Abstractions.IConverter](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Converter.Abstractions.IConverter 'Myprysm.Converter.Abstractions.IConverter')
```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddNewtonsoftJsonConverter(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, System.Action<Myprysm.Converter.NewtonsoftJson.NewtonsoftJsonConverterOptions> configureOptions, System.Action<Newtonsoft.Json.JsonSerializerSettings>? configureJson=null);
```
#### Parameters
<a name='Myprysm_Converter_NewtonsoftJson_DependencyInjection_AddNewtonsoftJsonConverter(Microsoft_Extensions_DependencyInjection_IServiceCollection_System_Action_Myprysm_Converter_NewtonsoftJson_NewtonsoftJsonConverterOptions__System_Action_Newtonsoft_Json_JsonSerializerSettings__)_services'></a>
`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
  
<a name='Myprysm_Converter_NewtonsoftJson_DependencyInjection_AddNewtonsoftJsonConverter(Microsoft_Extensions_DependencyInjection_IServiceCollection_System_Action_Myprysm_Converter_NewtonsoftJson_NewtonsoftJsonConverterOptions__System_Action_Newtonsoft_Json_JsonSerializerSettings__)_configureOptions'></a>
`configureOptions` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[NewtonsoftJsonConverterOptions](Myprysm_Converter_NewtonsoftJson_NewtonsoftJsonConverterOptions.md 'Myprysm.Converter.NewtonsoftJson.NewtonsoftJsonConverterOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
  
<a name='Myprysm_Converter_NewtonsoftJson_DependencyInjection_AddNewtonsoftJsonConverter(Microsoft_Extensions_DependencyInjection_IServiceCollection_System_Action_Myprysm_Converter_NewtonsoftJson_NewtonsoftJsonConverterOptions__System_Action_Newtonsoft_Json_JsonSerializerSettings__)_configureJson'></a>
`configureJson` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[Newtonsoft.Json.JsonSerializerSettings](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.JsonSerializerSettings 'Newtonsoft.Json.JsonSerializerSettings')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
  
#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
  
<a name='Myprysm_Converter_NewtonsoftJson_DependencyInjection_AddNewtonsoftJsonConverter(Microsoft_Extensions_DependencyInjection_IServiceCollection_System_Action_Newtonsoft_Json_JsonSerializerSettings_)'></a>
## DependencyInjection.AddNewtonsoftJsonConverter(IServiceCollection, Action&lt;JsonSerializerSettings&gt;) Method
Adds a NewtonsoftJson [Myprysm.Converter.Abstractions.IConverter](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Converter.Abstractions.IConverter 'Myprysm.Converter.Abstractions.IConverter') and customize the [Newtonsoft.Json.JsonSerializerSettings](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.JsonSerializerSettings 'Newtonsoft.Json.JsonSerializerSettings').  
```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddNewtonsoftJsonConverter(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, System.Action<Newtonsoft.Json.JsonSerializerSettings> configure);
```
#### Parameters
<a name='Myprysm_Converter_NewtonsoftJson_DependencyInjection_AddNewtonsoftJsonConverter(Microsoft_Extensions_DependencyInjection_IServiceCollection_System_Action_Newtonsoft_Json_JsonSerializerSettings_)_services'></a>
`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection.
  
<a name='Myprysm_Converter_NewtonsoftJson_DependencyInjection_AddNewtonsoftJsonConverter(Microsoft_Extensions_DependencyInjection_IServiceCollection_System_Action_Newtonsoft_Json_JsonSerializerSettings_)_configure'></a>
`configure` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[Newtonsoft.Json.JsonSerializerSettings](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.JsonSerializerSettings 'Newtonsoft.Json.JsonSerializerSettings')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The [Newtonsoft.Json.JsonSerializerSettings](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.JsonSerializerSettings 'Newtonsoft.Json.JsonSerializerSettings') configuration action.
  
#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection.
  
<a name='Myprysm_Converter_NewtonsoftJson_DependencyInjection_AddNewtonsoftJsonConverter(Microsoft_Extensions_DependencyInjection_IServiceCollection)'></a>
## DependencyInjection.AddNewtonsoftJsonConverter(IServiceCollection) Method
Adds a NewtonsoftJson [Myprysm.Converter.Abstractions.IConverter](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Converter.Abstractions.IConverter 'Myprysm.Converter.Abstractions.IConverter') with default settings.  
```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddNewtonsoftJsonConverter(this Microsoft.Extensions.DependencyInjection.IServiceCollection services);
```
#### Parameters
<a name='Myprysm_Converter_NewtonsoftJson_DependencyInjection_AddNewtonsoftJsonConverter(Microsoft_Extensions_DependencyInjection_IServiceCollection)_services'></a>
`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection.
  
#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection.
  
