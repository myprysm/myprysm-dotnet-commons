namespace Myprysm.Tracing.ApplicationInsights;

using System.Diagnostics;
using System.Threading;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.DataContracts;
using Myprysm.Tracing.Abstractions;

/// <summary>
/// A tracer wrapping an <see cref="Microsoft.ApplicationInsights.TelemetryClient"/> for application telemetry.
/// </summary>
public class TelemetryClientTracer : ITracer
{
    internal static readonly AsyncLocal<ITrace?> CurrentTraceLocal = new();

    private readonly TelemetryClient telemetryClient;

    /// <summary>
    /// Creates a new <see cref="TelemetryClientTracer"/> with the given identity and <see cref="Microsoft.ApplicationInsights.TelemetryClient"/>.
    /// </summary>
    /// <param name="identity">The tracer identity.</param>
    /// <param name="telemetryClient">The Application Insights telemetry client.</param>
    public TelemetryClientTracer(
        TracerIdentity identity,
        TelemetryClient telemetryClient)
    {
        this.Identity = identity;
        this.telemetryClient = telemetryClient;
    }

    /// <inheritdoc />
    public TracerIdentity Identity { get; }

    /// <inheritdoc />
    public ITrace? CurrentTrace => CurrentTraceLocal.Value;

    /// <inheritdoc />
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
