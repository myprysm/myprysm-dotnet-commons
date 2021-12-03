namespace Myprysm.Tracing.Abstractions;

/// <summary>
/// Default tracer implementation with minimal operations.
/// Useful for testing or when no real <see cref="ITracerFactory"/> is provided.
/// </summary>
public class DefaultTracer : ITracer
{
    internal static readonly AsyncLocal<ITrace?> CurrentTraceLocal = new();

    /// <summary>
    /// Creates a new <see cref="DefaultTracer"/> with the given identity.
    /// </summary>
    /// <param name="identity">The tracer identity.</param>
    public DefaultTracer(
        TracerIdentity identity)
    {
        this.Identity = identity;
    }

    /// <inheritdoc />
    public TracerIdentity Identity { get; }

    /// <inheritdoc />
    public ITrace? CurrentTrace => CurrentTraceLocal.Value;

    /// <inheritdoc />
    public ITrace StartTrace(string name, TraceKind kind = TraceKind.Internal, ITrace? parent = null)
    {
        var id = Guid.NewGuid().ToString();
        var trace = new DefaultTrace(id, name, parent ?? this.CurrentTrace, this);
        trace.AddTag(nameof(this.Identity.Name), this.Identity.Name);
        trace.AddTag(nameof(this.Identity.Version), this.Identity.Version);
        CurrentTraceLocal.Value = trace;

        return trace;
    }
}
