namespace Myprysm.Testing.NUnit;

using Myprysm.Tracing.Abstractions;

public class CollectorTracer : ITracer
{
    private readonly List<ITrace> traces = new();
    private readonly ITracer @delegate;

    public CollectorTracer(
        ITracer @delegate)
    {
        this.@delegate = @delegate;
    }

    public IEnumerable<ITrace> Traces => this.traces.AsReadOnly();
    public TracerIdentity Identity => this.@delegate.Identity;

    public ITrace? CurrentTrace => this.@delegate.CurrentTrace;

    public ITrace? StartTrace(string name, TraceKind kind = TraceKind.Internal, ITrace? parent = null)
    {
        var trace = this.@delegate.StartTrace(name, kind, parent);

        if (trace is not null)
        {
            this.traces.Add(trace);
        }

        return trace;
    }
}
