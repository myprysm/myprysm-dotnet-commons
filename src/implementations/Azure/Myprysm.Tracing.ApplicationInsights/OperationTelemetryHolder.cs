namespace Myprysm.Tracing.ApplicationInsights;

using System;
using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.ApplicationInsights.Extensibility.Implementation;

internal class OperationTelemetryHolder : IOperationHolder<OperationTelemetry>
{
    private readonly Action dispose;

    private OperationTelemetryHolder(Action dispose, OperationTelemetry operation)
    {
        this.dispose = dispose;
        this.Telemetry = operation;
    }

    public void Dispose()
    {
        this.dispose();
    }

    public OperationTelemetry Telemetry { get; }

    internal static OperationTelemetryHolder FromHolder<T>(IOperationHolder<T> request)
        where T : OperationTelemetry
        => new(() => request.Dispose(), request.Telemetry);
}
