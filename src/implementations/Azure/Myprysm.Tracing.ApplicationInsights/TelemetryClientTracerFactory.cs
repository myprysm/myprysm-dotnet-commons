namespace Myprysm.Tracing.ApplicationInsights;

using System.Collections.Concurrent;
using Microsoft.ApplicationInsights;
using Myprysm.Tracing.Abstractions;

/// <summary>
/// Factory that manages instances of <see cref="TelemetryClientTracer"/>.
/// </summary>
public class TelemetryClientTracerFactory : ITracerFactory
{
    private readonly ConcurrentDictionary<TracerIdentity, TelemetryClientTracer> tracers = new();

    private readonly TelemetryClient telemetryClient;

    /// <summary>
    /// Creates a new <see cref="TelemetryClientTracerFactory"/> with the given <see cref="Microsoft.ApplicationInsights.TelemetryClient"/>.
    /// </summary>
    /// <param name="telemetryClient">The telemetry client.</param>
    public TelemetryClientTracerFactory(TelemetryClient telemetryClient)
    {
        this.telemetryClient = telemetryClient;
    }


    /// <inheritdoc />
    public ITracer GetTracer(TracerIdentity identity)
    {
        return this.tracers.GetOrAdd(identity,
            id => new TelemetryClientTracer(id, this.telemetryClient));
    }
}
