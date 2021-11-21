namespace Myprysm.Tracing.Abstractions;

public interface ITracerFactory
{
    IEnumerable<TracerIdentity> RegisteredIdentities { get; }

    ITracer GetTracer(TracerIdentity identity);
}
