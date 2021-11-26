namespace Myprysm.Tracing.ApplicationInsights.Tests.Integration;

using System.Collections.Generic;
using Microsoft.ApplicationInsights.Channel;

public class CollectorTelemetryChannel : ITelemetryChannel
{
    private readonly List<ITelemetry> exportedTelemetry;

    public CollectorTelemetryChannel(List<ITelemetry> exportedTelemetry)
    {
        this.exportedTelemetry = exportedTelemetry;
    }

    public void Dispose()
    {
        // Does nothing
    }

    public void Send(ITelemetry item)
    {
        this.exportedTelemetry.Add(item);
    }

    public void Flush()
    {
        // Does nothing
    }

    public bool? DeveloperMode { get; set; }

    public string EndpointAddress { get; set; } = string.Empty;
}
