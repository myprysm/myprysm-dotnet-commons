# Myprysm Tracing ActivitySource

Implementation of an [ITracer](../../abstractions/Myprysm.Tracing.Abstractions/README.md)
with `System.Diagnostics.DiagnosticSource`
for [Distributed Tracing](https://docs.microsoft.com/en-us/dotnet/core/diagnostics/distributed-tracing-collection-walkthroughs).

## Configuration and usage

You can load the latest version of this tracer implementation
from [Myprysm Nuget repository](https://baget.myprysm.fr/packages/myprysm.tracing.activitysource).

You can inject the `ITracer` and `ITracerFactory` in your application by using the `DependencyInjectionExtensions`.

You should preferably provide one `TracerIdentity` per library if you want fine-grained tracing.

This implementation is fully `AsyncLocal` compatible as it is using the raw underlying dotnet components from `System.Diagnostics.DiagnosticSource`.

This implementation provides the required components for `Myprysm.Tracing.OpenTelemetry` to work.

You should prefer the abstractions if you want to implement a library with tne Myprysm toolkit.

## Documentation

The API documentation is available [here](documentation/index.md).
