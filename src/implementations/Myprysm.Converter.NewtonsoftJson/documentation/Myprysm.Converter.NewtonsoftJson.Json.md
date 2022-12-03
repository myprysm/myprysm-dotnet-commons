#### [Myprysm.Converter.NewtonsoftJson](index.md 'index')
### [Myprysm.Converter.NewtonsoftJson](index.md#Myprysm.Converter.NewtonsoftJson 'Myprysm.Converter.NewtonsoftJson')

## Json Class

Configuration class holding the settings uses for NewtonsoftJson by this [Myprysm.Converter.Abstractions.IConverter](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Converter.Abstractions.IConverter 'Myprysm.Converter.Abstractions.IConverter').

```csharp
public static class Json
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Json
### Properties

<a name='Myprysm.Converter.NewtonsoftJson.Json.DefaultSettings'></a>

## Json.DefaultSettings Property

The default settings used by the converter.

```csharp
public static Newtonsoft.Json.JsonSerializerSettings DefaultSettings { get; }
```

#### Property Value
[Newtonsoft.Json.JsonSerializerSettings](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.JsonSerializerSettings 'Newtonsoft.Json.JsonSerializerSettings')
### Methods

<a name='Myprysm.Converter.NewtonsoftJson.Json.ConfigureDefaults(thisNewtonsoft.Json.JsonSerializerSettings)'></a>

## Json.ConfigureDefaults(this JsonSerializerSettings) Method

Configure the same defaults as used by this [Myprysm.Converter.Abstractions.IConverter](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Converter.Abstractions.IConverter 'Myprysm.Converter.Abstractions.IConverter') on the given settings.

```csharp
public static Newtonsoft.Json.JsonSerializerSettings ConfigureDefaults(this Newtonsoft.Json.JsonSerializerSettings settings);
```
#### Parameters

<a name='Myprysm.Converter.NewtonsoftJson.Json.ConfigureDefaults(thisNewtonsoft.Json.JsonSerializerSettings).settings'></a>

`settings` [Newtonsoft.Json.JsonSerializerSettings](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.JsonSerializerSettings 'Newtonsoft.Json.JsonSerializerSettings')

The settings to configure.

#### Returns
[Newtonsoft.Json.JsonSerializerSettings](https://docs.microsoft.com/en-us/dotnet/api/Newtonsoft.Json.JsonSerializerSettings 'Newtonsoft.Json.JsonSerializerSettings')  
The configured settings for fluent APIs.