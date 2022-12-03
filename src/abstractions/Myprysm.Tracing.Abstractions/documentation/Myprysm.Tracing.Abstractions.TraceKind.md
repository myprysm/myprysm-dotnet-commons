#### [Myprysm.Tracing.Abstractions](index.md 'index')
### [Myprysm.Tracing.Abstractions](index.md#Myprysm.Tracing.Abstractions 'Myprysm.Tracing.Abstractions')

## TraceKind Enum

Adapted from https://github.com/open-telemetry/opentelemetry-specification/blob/main/specification/trace/api.md#spankind  
TraceKind describes the relationship between the Trace, its parents, and its children in a Trace.  
TraceKind describes two independent properties that benefit tracing systems during analysis.

```csharp
public enum TraceKind
```
### Fields

<a name='Myprysm.Tracing.Abstractions.TraceKind.Client'></a>

`Client` 1

Indicates that the trace describes a synchronous request to some remote service.  
This trace is the parent of a remote SERVER trace and waits for its response.

<a name='Myprysm.Tracing.Abstractions.TraceKind.Consumer'></a>

`Consumer` 4

Indicates that the trace describes the child of an asynchronous PRODUCER request.

<a name='Myprysm.Tracing.Abstractions.TraceKind.Internal'></a>

`Internal` 0

Default value. Indicates that the trace represents an internal operation within an application, as opposed to an operations with remote parents or children.

<a name='Myprysm.Tracing.Abstractions.TraceKind.Producer'></a>

`Producer` 3

Indicates that the trace describes the parent of an asynchronous request.  
This parent trace is expected to end before the corresponding child CONSUMER trace, possibly even before the child trace starts.  
In messaging scenarios with batching, tracing individual messages requires a new PRODUCER trace per message to be created.

<a name='Myprysm.Tracing.Abstractions.TraceKind.Server'></a>

`Server` 2

Indicates that the trace covers server-side handling of a synchronous RPC or other remote request.  
This trace is the child of a remote CLIENT trace that was expected to wait for a response.