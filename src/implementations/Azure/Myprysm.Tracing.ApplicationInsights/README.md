# Myprysm Tracing ActivitySource

Implementation of an [ITracer](../../../abstractions/Myprysm.Tracing.Abstractions/README.md)
with `Application Insights`
for [Distributed Tracing](https://docs.microsoft.com/en-us/dotnet/core/diagnostics/distributed-tracing-collection-walkthroughs).

## Configuration and usage

You can load the latest version of this tracer implementation
from [Myprysm Nuget repository](https://baget.myprysm.fr/packages/myprysm.tracing.applicationinsights).

You can inject the `ITracer` and `ITracerFactory` in your application by using the `DependencyInjectionExtensions`.

You should preferably provide one `TracerIdentity` per library if you want fine-grained tracing.

This implementation is not certified fully `AsyncLocal` compatible. Only some activity sources are listened by the telemetry client and this
implementation cannot be aware of those sources. Instead it tries to provide the parent relationship from the current activity when no trace has been
started yet in the current context.

You should prefer the abstractions if you want to implement a library with tne Myprysm toolkit.

## Documentation

The API documentation is available [here](documentation/index.md).
