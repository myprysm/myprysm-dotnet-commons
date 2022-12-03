#### [Myprysm.Converter.NewtonsoftJson.ValueObjects](index.md 'index')
### [Myprysm.Converter.NewtonsoftJson.ValueObjects](index.md#Myprysm.Converter.NewtonsoftJson.ValueObjects 'Myprysm.Converter.NewtonsoftJson.ValueObjects')

## JsonSerializerSettingsExtensions Class

[Newtonsoft.Json.JsonSerializerSettings](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.JsonSerializerSettings 'Newtonsoft.Json.JsonSerializerSettings') extensions.

```csharp
public static class JsonSerializerSettingsExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; JsonSerializerSettingsExtensions
### Methods

<a name='Myprysm.Converter.NewtonsoftJson.ValueObjects.JsonSerializerSettingsExtensions.ConfigureValueObjectConverters(thisNewtonsoft.Json.JsonSerializerSettings)'></a>

## JsonSerializerSettingsExtensions.ConfigureValueObjectConverters(this JsonSerializerSettings) Method

Configure the [Myprysm.Converter.NewtonsoftJson.ValueObjects.SingleValueObjectConverter](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Converter.NewtonsoftJson.ValueObjects.SingleValueObjectConverter 'Myprysm.Converter.NewtonsoftJson.ValueObjects.SingleValueObjectConverter') on the given [Newtonsoft.Json.JsonSerializerSettings](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.JsonSerializerSettings 'Newtonsoft.Json.JsonSerializerSettings').

```csharp
public static Newtonsoft.Json.JsonSerializerSettings ConfigureValueObjectConverters(this Newtonsoft.Json.JsonSerializerSettings settings);
```
#### Parameters

<a name='Myprysm.Converter.NewtonsoftJson.ValueObjects.JsonSerializerSettingsExtensions.ConfigureValueObjectConverters(thisNewtonsoft.Json.JsonSerializerSettings).settings'></a>

`settings` [Newtonsoft.Json.JsonSerializerSettings](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.JsonSerializerSettings 'Newtonsoft.Json.JsonSerializerSettings')

The settings to configure the [Myprysm.Converter.NewtonsoftJson.ValueObjects.SingleValueObjectConverter](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Converter.NewtonsoftJson.ValueObjects.SingleValueObjectConverter 'Myprysm.Converter.NewtonsoftJson.ValueObjects.SingleValueObjectConverter').

#### Returns
[Newtonsoft.Json.JsonSerializerSettings](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.JsonSerializerSettings 'Newtonsoft.Json.JsonSerializerSettings')  
The configured settings for fluent APIs.