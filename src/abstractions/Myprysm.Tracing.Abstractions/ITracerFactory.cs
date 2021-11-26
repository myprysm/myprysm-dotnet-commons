namespace Myprysm.Tracing.Abstractions;

public interface ITracerFactory
{
    ITracer GetTracer(TracerIdentity identity);
}
