namespace Myprysm.Tracing.Abstractions;

public interface ITracer
{
    TracerIdentity Identity { get; }

    ITrace? CurrentTrace { get; }

    ITrace? StartTrace(string name, TraceKind kind = TraceKind.Internal, ITrace? parent = null);
}
