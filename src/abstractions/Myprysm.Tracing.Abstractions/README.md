# Myprysm Tracing Abstractions

Myprysm tracing abstractions.

This abstraction represents a tracer that allows telemetry recording in a library or an application.

This abstraction also provides a default nearly-noop implementation useful for testing or when no real implementation is provided in an application.

A `ITracerFactory` should provide a `ITracer` that can create `ITrace`s for a given `TracerIdentity`. Those traces can be collected by the underlying
implementation for distributed tracing and application telemetry.

This abstraction tries to stick to what is set as standard in the dotnet world (`System.Diagnostics.DiagnosticSource`) and in the OpenTelemetry
specification, although some names are changed voluntarily to avoid confusion on what is the real implementation.

## Dependency Injection and Tracing

The abstraction provides a common mechanism to register multiple `TracerIdentity` in a `StartupTracerOptions` that
an implementation can consume if those identities must be registered during application startup.

The abstraction provides also a way for other abstractions and libraries to optionally register a default tracer if no implementation is provided.

## Implementations

The implementations should ensure that the `ITracer.CurrentTrace` is `AsyncLocal` (local to an asynchronous flow, see [`AsyncLocal<T>` documentation](https://docs.microsoft.com/en-us/dotnet/api/system.threading.asynclocal-1?view=net-6.0)) 

## Testing

There is no compatibility test suite available yet.

## Documentation

The API documentation is available [here](documentation/index.md).
