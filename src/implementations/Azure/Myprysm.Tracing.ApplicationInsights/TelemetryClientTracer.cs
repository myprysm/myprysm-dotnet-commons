namespace Myprysm.Tracing.ApplicationInsights;

using System.Diagnostics;
using System.Threading;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.DataContracts;
using Myprysm.Tracing.Abstractions;

public class TelemetryClientTracer : ITracer
{
    internal static readonly AsyncLocal<ITrace?> CurrentTraceLocal = new();

    private readonly TelemetryClient telemetryClient;

    public TelemetryClientTracer(TracerIdentity identity, TelemetryClient telemetryClient)
    {
        this.Identity = identity;
        this.telemetryClient = telemetryClient;
    }

    public TracerIdentity Identity { get; }

    public ITrace? CurrentTrace => CurrentTraceLocal.Value;

    public ITrace? StartTrace(string name, TraceKind kind = TraceKind.Internal, ITrace? parent = null)
    {
        var trace = this.CreateTrace(name, kind, parent);

        trace?.AddBaggage(nameof(this.Identity.Name), this.Identity.Name);
        trace?.AddBaggage(nameof(this.Identity.Version), this.Identity.Version);

        CurrentTraceLocal.Value = trace;
        return trace;
    }

    private OperationTelemetryTrace? CreateTrace(string name, TraceKind kind, ITrace? parent)
    {
        var parentTrace = parent ?? this.CurrentTrace;
        var parentId = parentTrace?.Id ?? Activity.Current?.Id;
        if (kind is TraceKind.Client or TraceKind.Server)
        {
            var request = this.telemetryClient.StartOperation<RequestTelemetry>(name, null, parentId);
            return request is null
                ? null
                : new OperationTelemetryTrace(
                    OperationTelemetryHolder.FromHolder(request),
                    parentTrace,
                    this);
        }

        var dependency = this.telemetryClient.StartOperation<DependencyTelemetry>(name, null, parentId);
        return dependency is null
            ? null
            : new OperationTelemetryTrace(
                OperationTelemetryHolder.FromHolder(dependency),
                parentTrace,
                this);
    }
}
