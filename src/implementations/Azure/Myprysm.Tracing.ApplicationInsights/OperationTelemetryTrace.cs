namespace Myprysm.Tracing.ApplicationInsights;

using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.ApplicationInsights.Extensibility.Implementation;
using Myprysm.Tracing.Abstractions;

internal class OperationTelemetryTrace : ITrace
{
    private readonly TelemetryClientTracer tracer;

    private ITrace? parent;

    public OperationTelemetryTrace(
        IOperationHolder<OperationTelemetry> operation,
        ITrace? parent,
        TelemetryClientTracer tracer)
    {
        this.Operation = operation;
        this.parent = parent;
        this.tracer = tracer;
    }

    private IOperationHolder<OperationTelemetry> Operation { get; }

    public string Name => this.Operation.Telemetry.Name;

    public string? ParentId => this.Operation.Telemetry.Context.Operation.ParentId;

    public string Id => this.Operation.Telemetry.Id;

    public IReadOnlyDictionary<string, string?> Baggage => this.Operation.Telemetry.Properties.ToImmutableDictionary();

    public IReadOnlyDictionary<string, string?> Tags => this.Operation.Telemetry.Properties.ToImmutableDictionary();

    public void SetParent(ITrace trace)
    {
        this.parent = trace;
        this.SetParentId(trace.Id);
    }

    public void SetParentId(string parentId)
    {
        this.Operation.Telemetry.Context.Operation.ParentId = parentId;
    }

    public void AddBaggage(string key, string? value)
    {
        if (!this.Operation.Telemetry.Properties.ContainsKey(key))
        {
            this.Operation.Telemetry.Properties.Add(key, value);
        }
    }

    public void AddTag(string key, string? value)
    {
        if (!this.Operation.Telemetry.Properties.ContainsKey(key))
        {
            this.Operation.Telemetry.Properties.Add(key, value);
        }
    }

    public ITrace? CreateChild(string name, TraceKind kind = TraceKind.Internal)
    {
        return this.tracer.StartTrace(name, kind, this);
    }

    public void Dispose()
    {
        if (TelemetryClientTracer.CurrentTraceLocal.Value == this)
        {
            TelemetryClientTracer.CurrentTraceLocal.Value = this.parent;
        }

        this.Operation.Dispose();
    }
}
