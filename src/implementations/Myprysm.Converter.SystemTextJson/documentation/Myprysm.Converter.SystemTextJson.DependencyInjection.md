#### [Myprysm.Converter.SystemTextJson](index.md 'index')
### [Myprysm.Converter.SystemTextJson](index.md#Myprysm.Converter.SystemTextJson 'Myprysm.Converter.SystemTextJson')

## DependencyInjection Class

Dependency injection extensions.

```csharp
public static class DependencyInjection
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DependencyInjection
### Methods

<a name='Myprysm.Converter.SystemTextJson.DependencyInjection.AddSystemTextJsonConverter(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.Configuration.IConfiguration,System.Action_System.Text.Json.JsonSerializerOptions_)'></a>

## DependencyInjection.AddSystemTextJsonConverter(this IServiceCollection, IConfiguration, Action<JsonSerializerOptions>) Method

Adds a SystemTextJson [Myprysm.Converter.Abstractions.IConverter](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Converter.Abstractions.IConverter 'Myprysm.Converter.Abstractions.IConverter') with the provided configuration section  
and customize the [System.Text.Json.JsonSerializerOptions](https://docs.microsoft.com/en-us/dotnet/api/System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions').

```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddSystemTextJsonConverter(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration configurationSection, System.Action<System.Text.Json.JsonSerializerOptions>? configureJson=null);
```
#### Parameters

<a name='Myprysm.Converter.SystemTextJson.DependencyInjection.AddSystemTextJsonConverter(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.Configuration.IConfiguration,System.Action_System.Text.Json.JsonSerializerOptions_).services'></a>

`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')

The service collection.

<a name='Myprysm.Converter.SystemTextJson.DependencyInjection.AddSystemTextJsonConverter(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.Configuration.IConfiguration,System.Action_System.Text.Json.JsonSerializerOptions_).configurationSection'></a>

`configurationSection` [Microsoft.Extensions.Configuration.IConfiguration](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Configuration.IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration')

The configuration section.

<a name='Myprysm.Converter.SystemTextJson.DependencyInjection.AddSystemTextJsonConverter(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.Configuration.IConfiguration,System.Action_System.Text.Json.JsonSerializerOptions_).configureJson'></a>

`configureJson` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Text.Json.JsonSerializerOptions](https://docs.microsoft.com/en-us/dotnet/api/System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The [System.Text.Json.JsonSerializerOptions](https://docs.microsoft.com/en-us/dotnet/api/System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') configuration action.

#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection.

<a name='Myprysm.Converter.SystemTextJson.DependencyInjection.AddSystemTextJsonConverter(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Action_Myprysm.Converter.SystemTextJson.SystemTextJsonConverterOptions_,System.Action_System.Text.Json.JsonSerializerOptions_)'></a>

## DependencyInjection.AddSystemTextJsonConverter(this IServiceCollection, Action<SystemTextJsonConverterOptions>, Action<JsonSerializerOptions>) Method

Adds a SystemTextJson [Myprysm.Converter.Abstractions.IConverter](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Converter.Abstractions.IConverter 'Myprysm.Converter.Abstractions.IConverter')

```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddSystemTextJsonConverter(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, System.Action<Myprysm.Converter.SystemTextJson.SystemTextJsonConverterOptions> configureOptions, System.Action<System.Text.Json.JsonSerializerOptions>? configureJson=null);
```
#### Parameters

<a name='Myprysm.Converter.SystemTextJson.DependencyInjection.AddSystemTextJsonConverter(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Action_Myprysm.Converter.SystemTextJson.SystemTextJsonConverterOptions_,System.Action_System.Text.Json.JsonSerializerOptions_).services'></a>

`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')

The service collection.

<a name='Myprysm.Converter.SystemTextJson.DependencyInjection.AddSystemTextJsonConverter(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Action_Myprysm.Converter.SystemTextJson.SystemTextJsonConverterOptions_,System.Action_System.Text.Json.JsonSerializerOptions_).configureOptions'></a>

`configureOptions` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[SystemTextJsonConverterOptions](Myprysm.Converter.SystemTextJson.SystemTextJsonConverterOptions.md 'Myprysm.Converter.SystemTextJson.SystemTextJsonConverterOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The options configuration action.

<a name='Myprysm.Converter.SystemTextJson.DependencyInjection.AddSystemTextJsonConverter(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Action_Myprysm.Converter.SystemTextJson.SystemTextJsonConverterOptions_,System.Action_System.Text.Json.JsonSerializerOptions_).configureJson'></a>

`configureJson` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Text.Json.JsonSerializerOptions](https://docs.microsoft.com/en-us/dotnet/api/System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The serializer options configuration.

#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')

<a name='Myprysm.Converter.SystemTextJson.DependencyInjection.AddSystemTextJsonConverter(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Action_System.Text.Json.JsonSerializerOptions_)'></a>

## DependencyInjection.AddSystemTextJsonConverter(this IServiceCollection, Action<JsonSerializerOptions>) Method

Adds a SystemTextJson [Myprysm.Converter.Abstractions.IConverter](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Converter.Abstractions.IConverter 'Myprysm.Converter.Abstractions.IConverter') and customize the [System.Text.Json.JsonSerializerOptions](https://docs.microsoft.com/en-us/dotnet/api/System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions').

```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddSystemTextJsonConverter(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, System.Action<System.Text.Json.JsonSerializerOptions> configure);
```
#### Parameters

<a name='Myprysm.Converter.SystemTextJson.DependencyInjection.AddSystemTextJsonConverter(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Action_System.Text.Json.JsonSerializerOptions_).services'></a>

`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')

The service collection.

<a name='Myprysm.Converter.SystemTextJson.DependencyInjection.AddSystemTextJsonConverter(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Action_System.Text.Json.JsonSerializerOptions_).configure'></a>

`configure` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[System.Text.Json.JsonSerializerOptions](https://docs.microsoft.com/en-us/dotnet/api/System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The [System.Text.Json.JsonSerializerOptions](https://docs.microsoft.com/en-us/dotnet/api/System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') configuration action.

#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection.

<a name='Myprysm.Converter.SystemTextJson.DependencyInjection.AddSystemTextJsonConverter(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection)'></a>

## DependencyInjection.AddSystemTextJsonConverter(this IServiceCollection) Method

Adds a SystemTextJson [Myprysm.Converter.Abstractions.IConverter](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Converter.Abstractions.IConverter 'Myprysm.Converter.Abstractions.IConverter') with default settings.

```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddSystemTextJsonConverter(this Microsoft.Extensions.DependencyInjection.IServiceCollection services);
```
#### Parameters

<a name='Myprysm.Converter.SystemTextJson.DependencyInjection.AddSystemTextJsonConverter(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection).services'></a>

`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')

The service collection.

#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection.