namespace Myprysm.Tracing.Abstractions;

public class DefaultTracer : ITracer
{
    internal static readonly AsyncLocal<ITrace?> CurrentTraceLocal = new();

    public DefaultTracer(
        TracerIdentity identity)
    {
        this.Identity = identity;
    }

    public TracerIdentity Identity { get; }

    public ITrace? CurrentTrace => CurrentTraceLocal.Value;

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
