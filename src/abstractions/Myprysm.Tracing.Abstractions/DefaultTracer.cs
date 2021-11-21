namespace Myprysm.Tracing.Abstractions;

public class DefaultTracer : ITracer
{
    private readonly AsyncLocal<DefaultTrace?> currentTrace;
    
    public DefaultTracer(
        TracerIdentity identity)
    {
        this.Identity = identity;
        this.currentTrace = new AsyncLocal<DefaultTrace?>();
    }

    public TracerIdentity Identity { get; }

    public ITrace? CurrentTrace => this.currentTrace.Value;

    public ITrace StartTrace(string name, TraceKind kind = TraceKind.Internal, ITrace? parent = null)
    {
        var trace = new DefaultTrace(name, parent ?? this.CurrentTrace, this);
        trace.AddTag(nameof(this.Identity.Name), this.Identity.Name);
        trace.AddTag(nameof(this.Identity.Version), this.Identity.Version);
        this.currentTrace.Value = trace;

        return trace;
    }
}
