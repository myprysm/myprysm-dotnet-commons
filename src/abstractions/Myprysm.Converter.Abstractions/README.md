# Myprysm Converter Abstractions

Myprysm conversion/serde abstractions.

This abstraction represents a synchronous converter 
that reads and writes objects from/to a Stream, a byte array or a string.

## Dependency Injection and Tracing

The abstractions provide a dependency injection extension to automatically enable tracing.

While not required, 
it is strongly advised that you use this extension to register your converter to make it trace-enabled.

You can use a similar construct as below:

```c#
public static IServiceCollection AddYourJsonConverter(
    this IServiceCollection services,
    Action<YourJsonConverterOptions> configureOptions,
    Action<JsonSerializerSettings>? configureJson = null)
{
    var tracerIdentity = new TracerIdentity(
        "YourJsonConverter.Library", 
        "your.assembly.version");

    return services
        .Configure<YourJsonConverterOptions>(options =>
        {
            configureOptions(options);
            configureJson?.Invoke(options.JsonSerializerSettings);
        })
        .TryAddDefaultTracer()
        .RegisterTracerOnStartup(tracerIdentity)
        .AddSingleton<YourJsonConverter>()
        .AddSingleton(sp => sp.CreateConverter<YourJsonConverterOptions>(
            tracerIdentity,
            p => p.GetRequiredService<YourJsonConverter>()));
}
```

## Implementations

The abstraction assumes that a `Stream` is the base medium exchange for serialization and deserialization.
Therefore the `IConverter` interface provides defaults for `byte[]` and `string` methods 
that forward the conversion to the `Stream` implementation. 
Type conversion through serialization assumes the same and provides its own default too.

With those assumptions in mind, it means that a basic `IConverter` only needs to implement
the `object? Read(Stream data, Type type)` and `void WriteToStream(object? data, Stream stream)` methods 
to work appropriately.

If you have more specific requirements you can also provide your own implementations.

## Testing

You can use the [compatibility test suite](../Myprysm.Converter.Abstractions.Testing/README.md)
to validate your implementation.

## Documentation

The API documentation is available [here](documentation/index.md).
