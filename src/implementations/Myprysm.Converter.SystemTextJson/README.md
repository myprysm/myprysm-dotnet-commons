# Myprysm Converter System.Text.Json

Implementation of an [IConverter](../../abstractions/Myprysm.Converter.Abstractions/README.md)
with [System.Text.Json](https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-how-to).

## Configuration and usage

You can load the latest version of this converter from [Myprysm Nuget repository](https://baget.myprysm.fr/packages/myprysm.converter.newtonsoftjson).

You can inject the `IConverter` in your application by using the `DependencyInjectionExtensions`.

The default configuration should suit most of your use cases and a simple `services.AddSystemTextJsonConverter()` may be enough.

If you want more fine grained control on the configuration or the underlying `JsonSerializerOptions`
(e.g. adding some custom converters), check the API Documentation.

## Documentation

The API documentation is available [here](documentation/index.md).
