namespace Myprysm.Tracing.Abstractions;

/// <summary>
/// A tracer factory that produces a <see cref="ITracer"/> for a <see cref="TracerIdentity"/>.
///
/// Although not required, it may be preferable to cache instances for a given identity.
/// </summary>
public interface ITracerFactory
{
    /// <summary>
    /// Gets a tracer for the given identity.
    /// </summary>
    /// <param name="identity">The identity of the tracer.</param>
    /// <returns>The tracer for the identity.</returns>
    ITracer GetTracer(TracerIdentity identity);
}
