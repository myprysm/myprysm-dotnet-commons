namespace Myprysm.Tracing.Abstractions;

/// <summary>
/// Adapted from https://github.com/open-telemetry/opentelemetry-specification/blob/main/specification/trace/api.md#spankind
/// TraceKind describes the relationship between the Trace, its parents, and its children in a Trace.
/// TraceKind describes two independent properties that benefit tracing systems during analysis.
/// </summary>
public enum TraceKind
{
    /// <summary>
    /// Default value. Indicates that the trace represents an internal operation within an application, as opposed to an operations with remote parents or children.
    /// </summary>
    Internal,

    /// <summary>
    /// Indicates that the trace describes a synchronous request to some remote service.
    /// This trace is the parent of a remote SERVER trace and waits for its response.
    /// </summary>
    Client,

    /// <summary>
    /// Indicates that the trace covers server-side handling of a synchronous RPC or other remote request.
    /// This trace is the child of a remote CLIENT trace that was expected to wait for a response.
    /// </summary>
    Server,

    /// <summary>
    /// Indicates that the trace describes the parent of an asynchronous request.
    /// This parent trace is expected to end before the corresponding child CONSUMER trace, possibly even before the child trace starts.
    /// In messaging scenarios with batching, tracing individual messages requires a new PRODUCER trace per message to be created.
    /// </summary>
    Producer,

    /// <summary>
    /// Indicates that the trace describes the child of an asynchronous PRODUCER request.
    /// </summary>
    Consumer,
}