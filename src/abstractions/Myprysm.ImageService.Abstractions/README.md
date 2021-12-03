# Myprysm Image Service Abstractions

Myprysm image service abstractions.

This abstraction represents an image service that allows processing on an image stream..

## Dependency Injection and Tracing

The abstractions provide a dependency injection extension to automatically enable tracing.

While not required, it is strongly advised that you use this extension to register your converter to make it trace-enabled.

You can use a similar construct as below:

```c#
public static IServiceCollection AddYourImageService(
    this IServiceCollection services,
    Action<YourImageServiceOptions> configureOptions)
{
    var tracerIdentity = new TracerIdentity(
        "YourImageService.Library", 
        "your.assembly.version");

    return services
        .Configure<YourImageServiceOptions>(configureOptions)
        .TryAddDefaultTracer()
        .RegisterTracerOnStartup(tracerIdentity)
        .AddSingleton<YourImageService>()
        .AddSingleton(sp => sp.CreateImageService<YourImageServiceOptions>(
            tracerIdentity,
            p => p.GetRequiredService<YourImageService>()));
}
```

## Implementations

There is not specific detail about the implementation except that you should prefer `ImageProcessingException`
when an error is well known.

## Testing

You can use the [compatibility test suite](../Myprysm.ImageService.Abstractions.Testing/README.md)
to validate your implementation.

## Documentation

The API documentation is available [here](documentation/index.md).
