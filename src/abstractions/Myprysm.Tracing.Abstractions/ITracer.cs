namespace Myprysm.Tracing.Abstractions;

/// <summary>
/// A tracer that can start an application trace and get the current application trace for monitoring.
/// </summary>
public interface ITracer
{
    /// <summary>
    /// The identity of the tracer.
    /// </summary>
    TracerIdentity Identity { get; }

    /// <summary>
    /// The current application trace at the moment of the request.
    /// </summary>
    ITrace? CurrentTrace { get; }

    /// <summary>
    /// Start an application trace with the provided name, optional kind and parent.
    /// </summary>
    /// <remarks>
    /// When a parent is not provided,
    /// the tracer implementation should try to determine the appropriate parent by itself.
    /// </remarks>
    /// <param name="name">The name of the trace.</param>
    /// <param name="kind">The optional kind of the trace.</param>
    /// <param name="parent">The optional parent of the trace.</param>
    /// <returns></returns>
    ITrace? StartTrace(string name, TraceKind kind = TraceKind.Internal, ITrace? parent = null);
}
