namespace Myprysm.Tracing.ApplicationInsights;

using System.Collections.Concurrent;
using System.Collections.Generic;
using Microsoft.ApplicationInsights;
using Myprysm.Tracing.Abstractions;

public class TelemetryClientTracerFactory : ITracerFactory
{
    private readonly ConcurrentDictionary<TracerIdentity, TelemetryClientTracer> tracers = new();

    private readonly TelemetryClient telemetryClient;

    public TelemetryClientTracerFactory(TelemetryClient telemetryClient)
    {
        this.telemetryClient = telemetryClient;
    }

    public ITracer GetTracer(TracerIdentity identity)
    {
        return this.tracers.GetOrAdd(identity,
            id => new TelemetryClientTracer(id, this.telemetryClient));
    }
}
