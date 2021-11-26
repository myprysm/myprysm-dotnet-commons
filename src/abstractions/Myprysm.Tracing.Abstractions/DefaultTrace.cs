namespace Myprysm.Tracing.Abstractions;

using System.Collections.Concurrent;

public sealed class DefaultTrace : ITrace
{
    private readonly DefaultTracer tracer;
    private readonly ConcurrentDictionary<string, string?> baggage;
    private readonly ConcurrentDictionary<string, string?> tags;

    private ITrace? parent;

    public DefaultTrace(string id, string name, ITrace? parent, DefaultTracer tracer)
    {
        this.Id = id;
        this.Name = name;
        this.parent = parent;
        this.tracer = tracer;
        this.baggage = new ConcurrentDictionary<string, string?>();
        this.tags = new ConcurrentDictionary<string, string?>();

        if (this.parent is null)
        {
            return;
        }

        foreach (var (key, value) in this.parent.Baggage)
        {
            this.AddBaggage(key, value);
        }
    }

    public void Dispose()
    {
        if (DefaultTracer.CurrentTraceLocal.Value == this)
        {
            DefaultTracer.CurrentTraceLocal.Value = this.parent;
        }
    }

    public string Name { get; }

    public string? ParentId => this.parent?.Id;

    public string Id { get; }

    public IReadOnlyDictionary<string, string?> Baggage => this.baggage;

    public IReadOnlyDictionary<string, string?> Tags => this.tags;

    /// <inheritdoc cref="ITrace"/>
    public void SetParentId(string parentId)
    {
        this.parent = new DefaultTrace(parentId, string.Empty, null, this.tracer);
    }

    public void AddBaggage(string key, string? value)
    {
        if (this.baggage.TryAdd(key, value))
        {
            return;
        }

        if (this.baggage.TryGetValue(key, out var oldValue))
        {
            this.baggage.TryUpdate(key, value, oldValue);
        }
    }

    public void AddTag(string key, string? value)
    {
        if (this.tags.TryAdd(key, value))
        {
            return;
        }

        if (this.tags.TryGetValue(key, out var oldValue))
        {
            this.tags.TryUpdate(key, value, oldValue);
        }
    }

    public ITrace CreateChild(string name, TraceKind kind = TraceKind.Internal)
    {
        return this.tracer.StartTrace(name, kind, this);
    }
}
