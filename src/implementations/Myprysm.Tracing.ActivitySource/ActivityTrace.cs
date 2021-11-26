namespace Myprysm.Tracing.ActivitySource;

using System.Collections.Immutable;
using System.Diagnostics;
using Myprysm.Tracing.Abstractions;

internal sealed class ActivityTrace : ITrace, IEquatable<ActivityTrace>
{
    public bool Equals(ActivityTrace? other)
    {
        if (ReferenceEquals(null, other))
        {
            return false;
        }

        if (ReferenceEquals(this, other))
        {
            return true;
        }

        return this.Activity.Equals(other.Activity);
    }

    public override bool Equals(object? obj)
    {
        return ReferenceEquals(this, obj) || obj is ActivityTrace other && Equals(other);
    }

    public override int GetHashCode()
    {
        return this.Activity.GetHashCode();
    }

    public Activity Activity { get; }

    private readonly ActivitySourceTracer tracer;

    public ActivityTrace(Activity activity, ActivitySourceTracer tracer)
    {
        this.Activity = activity;
        this.tracer = tracer;
    }

    public string Name => this.Activity.OperationName;

    public string? ParentId => this.Activity.ParentId;

    public string Id => this.Activity.Id ?? string.Empty;

    public IReadOnlyDictionary<string, string?> Baggage => this.Activity.Baggage
        .ToImmutableDictionary(i => i.Key, i => i.Value);

    public IReadOnlyDictionary<string, string?> Tags => this.Activity.Tags
        .ToImmutableDictionary(i => i.Key, i => i.Value);

    public void SetParentId(string parentId)
    {
        this.Activity.SetParentId(parentId);
    }

    /// <inheritdoc />
    public void AddBaggage(string key, string? value)
    {
        this.Activity.AddBaggage(key, value);
    }

    /// <inheritdoc />
    public void AddTag(string key, string? value)
    {
        this.Activity.AddTag(key, value);
    }

    /// <inheritdoc />
    public ITrace? CreateChild(string name, TraceKind kind = TraceKind.Internal)
    {
        return this.tracer.StartTrace(name, kind, this);
    }

    public void Dispose()
    {
        this.Activity.Dispose();
    }
}
