# Myprysm File Service Abstractions

Myprysm file service abstractions.

This abstraction represents a file service 
that manages file uploads and downloads into dedicated containers at a given path.

## Dependency Injection and Tracing

The abstractions provide a dependency injection extension to automatically enable tracing.

While not required, 
it is strongly advised that you use this extension to register your converter to make it trace-enabled.

You can use a similar construct as below:

```c#
public static IServiceCollection AddYourFileService(
    this IServiceCollection services,
    Action<YourFileServiceOptions> configureOptions)
{
    var tracerIdentity = new TracerIdentity(
        "YourFileService.Library", 
        "your.assembly.version");

    return services
        .Configure<YourFileServiceOptions>(configureOptions)
        .TryAddDefaultTracer()
        .RegisterTracerOnStartup(tracerIdentity)
        .AddSingleton<YourFileService>()
        .AddSingleton(sp => sp.CreateFileService<YourFileServiceOptions>(
            tracerIdentity,
            p => p.GetRequiredService<YourFileService>()));
}
```

## Implementations

The abstraction assumes that when a container does not exist yet, it should be created as part of the request.

The service should provide the ability to **optionally** override content at a given path. 
This behaviour should be disabled by default.

## Testing

You can use the [compatibility test suite](../Myprysm.FileService.Abstractions.Testing/README.md)
to validate your implementation.

## Documentation

The API documentation is available [here](documentation/index.md).
