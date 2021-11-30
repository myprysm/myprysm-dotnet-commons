namespace Myprysm.Testing.NUnit;

using Myprysm.Tracing.Abstractions;

/// <summary>
/// Tracer decorator that collects the generated traces from the delegated tracer.
/// </summary>
public class CollectorTracer : ITracer
{
    private readonly List<ITrace> traces = new();
    private readonly ITracer @delegate;

    /// <summary>
    /// Creates a new <see cref="CollectorTracer"/>.
    /// </summary>
    /// <param name="delegate">The delegated tracer</param>
    public CollectorTracer(
        ITracer @delegate)
    {
        this.@delegate = @delegate;
    }

    /// <summary>
    /// The collected traces.
    /// </summary>
    public IEnumerable<ITrace> Traces => this.traces.AsReadOnly();

    /// <summary>
    /// The delegated identity.
    /// </summary>
    public TracerIdentity Identity => this.@delegate.Identity;

    /// <summary>
    /// The delegated current trace.
    /// </summary>
    public ITrace? CurrentTrace => this.@delegate.CurrentTrace;


    /// <inheritdoc />
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
