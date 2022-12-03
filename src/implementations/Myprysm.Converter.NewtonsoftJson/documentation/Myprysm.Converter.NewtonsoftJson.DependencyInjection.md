#### [Myprysm.Converter.NewtonsoftJson](index.md 'index')
### [Myprysm.Converter.NewtonsoftJson](index.md#Myprysm.Converter.NewtonsoftJson 'Myprysm.Converter.NewtonsoftJson')

## DependencyInjection Class

Dependency injection extensions.

```csharp
public static class DependencyInjection
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DependencyInjection
### Methods

<a name='Myprysm.Converter.NewtonsoftJson.DependencyInjection.AddNewtonsoftJsonConverter(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.Configuration.IConfiguration,System.Action_Newtonsoft.Json.JsonSerializerSettings_)'></a>

## DependencyInjection.AddNewtonsoftJsonConverter(this IServiceCollection, IConfiguration, Action<JsonSerializerSettings>) Method

Adds a NewtonsoftJson [Myprysm.Converter.Abstractions.IConverter](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Converter.Abstractions.IConverter 'Myprysm.Converter.Abstractions.IConverter') with the provided configuration section  
and customize the [Newtonsoft.Json.JsonSerializerSettings](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.JsonSerializerSettings 'Newtonsoft.Json.JsonSerializerSettings').

```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddNewtonsoftJsonConverter(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration configurationSection, System.Action<Newtonsoft.Json.JsonSerializerSettings>? configureJson=null);
```
#### Parameters

<a name='Myprysm.Converter.NewtonsoftJson.DependencyInjection.AddNewtonsoftJsonConverter(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.Configuration.IConfiguration,System.Action_Newtonsoft.Json.JsonSerializerSettings_).services'></a>

`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')

The service collection.

<a name='Myprysm.Converter.NewtonsoftJson.DependencyInjection.AddNewtonsoftJsonConverter(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.Configuration.IConfiguration,System.Action_Newtonsoft.Json.JsonSerializerSettings_).configurationSection'></a>

`configurationSection` [Microsoft.Extensions.Configuration.IConfiguration](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Configuration.IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration')

The configuration section.

<a name='Myprysm.Converter.NewtonsoftJson.DependencyInjection.AddNewtonsoftJsonConverter(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.Configuration.IConfiguration,System.Action_Newtonsoft.Json.JsonSerializerSettings_).configureJson'></a>

`configureJson` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[Newtonsoft.Json.JsonSerializerSettings](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.JsonSerializerSettings 'Newtonsoft.Json.JsonSerializerSettings')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The [Newtonsoft.Json.JsonSerializerSettings](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.JsonSerializerSettings 'Newtonsoft.Json.JsonSerializerSettings') configuration action.

#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection.

<a name='Myprysm.Converter.NewtonsoftJson.DependencyInjection.AddNewtonsoftJsonConverter(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Action_Myprysm.Converter.NewtonsoftJson.NewtonsoftJsonConverterOptions_,System.Action_Newtonsoft.Json.JsonSerializerSettings_)'></a>

## DependencyInjection.AddNewtonsoftJsonConverter(this IServiceCollection, Action<NewtonsoftJsonConverterOptions>, Action<JsonSerializerSettings>) Method

Adds a NewtonsoftJson [Myprysm.Converter.Abstractions.IConverter](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Converter.Abstractions.IConverter 'Myprysm.Converter.Abstractions.IConverter')

```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddNewtonsoftJsonConverter(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, System.Action<Myprysm.Converter.NewtonsoftJson.NewtonsoftJsonConverterOptions> configureOptions, System.Action<Newtonsoft.Json.JsonSerializerSettings>? configureJson=null);
```
#### Parameters

<a name='Myprysm.Converter.NewtonsoftJson.DependencyInjection.AddNewtonsoftJsonConverter(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Action_Myprysm.Converter.NewtonsoftJson.NewtonsoftJsonConverterOptions_,System.Action_Newtonsoft.Json.JsonSerializerSettings_).services'></a>

`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')

The service collection.

<a name='Myprysm.Converter.NewtonsoftJson.DependencyInjection.AddNewtonsoftJsonConverter(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Action_Myprysm.Converter.NewtonsoftJson.NewtonsoftJsonConverterOptions_,System.Action_Newtonsoft.Json.JsonSerializerSettings_).configureOptions'></a>

`configureOptions` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[NewtonsoftJsonConverterOptions](Myprysm.Converter.NewtonsoftJson.NewtonsoftJsonConverterOptions.md 'Myprysm.Converter.NewtonsoftJson.NewtonsoftJsonConverterOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The options configuration action.

<a name='Myprysm.Converter.NewtonsoftJson.DependencyInjection.AddNewtonsoftJsonConverter(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Action_Myprysm.Converter.NewtonsoftJson.NewtonsoftJsonConverterOptions_,System.Action_Newtonsoft.Json.JsonSerializerSettings_).configureJson'></a>

`configureJson` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[Newtonsoft.Json.JsonSerializerSettings](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.JsonSerializerSettings 'Newtonsoft.Json.JsonSerializerSettings')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The serializer options configuration.

#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')

<a name='Myprysm.Converter.NewtonsoftJson.DependencyInjection.AddNewtonsoftJsonConverter(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Action_Newtonsoft.Json.JsonSerializerSettings_)'></a>

## DependencyInjection.AddNewtonsoftJsonConverter(this IServiceCollection, Action<JsonSerializerSettings>) Method

Adds a NewtonsoftJson [Myprysm.Converter.Abstractions.IConverter](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Converter.Abstractions.IConverter 'Myprysm.Converter.Abstractions.IConverter') and customize the [Newtonsoft.Json.JsonSerializerSettings](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.JsonSerializerSettings 'Newtonsoft.Json.JsonSerializerSettings').

```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddNewtonsoftJsonConverter(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, System.Action<Newtonsoft.Json.JsonSerializerSettings> configure);
```
#### Parameters

<a name='Myprysm.Converter.NewtonsoftJson.DependencyInjection.AddNewtonsoftJsonConverter(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Action_Newtonsoft.Json.JsonSerializerSettings_).services'></a>

`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')

The service collection.

<a name='Myprysm.Converter.NewtonsoftJson.DependencyInjection.AddNewtonsoftJsonConverter(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Action_Newtonsoft.Json.JsonSerializerSettings_).configure'></a>

`configure` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[Newtonsoft.Json.JsonSerializerSettings](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.JsonSerializerSettings 'Newtonsoft.Json.JsonSerializerSettings')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The [Newtonsoft.Json.JsonSerializerSettings](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.JsonSerializerSettings 'Newtonsoft.Json.JsonSerializerSettings') configuration action.

#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection.

<a name='Myprysm.Converter.NewtonsoftJson.DependencyInjection.AddNewtonsoftJsonConverter(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection)'></a>

## DependencyInjection.AddNewtonsoftJsonConverter(this IServiceCollection) Method

Adds a NewtonsoftJson [Myprysm.Converter.Abstractions.IConverter](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Converter.Abstractions.IConverter 'Myprysm.Converter.Abstractions.IConverter') with default settings.

```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddNewtonsoftJsonConverter(this Microsoft.Extensions.DependencyInjection.IServiceCollection services);
```
#### Parameters

<a name='Myprysm.Converter.NewtonsoftJson.DependencyInjection.AddNewtonsoftJsonConverter(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection).services'></a>

`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')

The service collection.

#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection.