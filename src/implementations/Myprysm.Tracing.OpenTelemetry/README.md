# Myprysm Tracing OpenTelemetry

Additional helpers for OpenTelemetry registration
for [Distributed Tracing](https://docs.microsoft.com/en-us/dotnet/core/diagnostics/distributed-tracing-collection-walkthroughs).

## Configuration and usage

You can load the latest version
from [Myprysm Nuget repository](https://baget.myprysm.fr/packages/myprysm.tracing.opentelemetry).

You can register your extensions for the OpenTelemetry `TracerProviderBuilder` the same way as the original.

You should prefer the abstractions if you want to implement a library with tne Myprysm toolkit.

You should prefer this implementation if you would like to use OpenTelemetry in your application runtime.

## Documentation

The API documentation is available [here](documentation/index.md).
