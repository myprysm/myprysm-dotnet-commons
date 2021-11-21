namespace Myprysm.Tracing.Abstractions;

using System.Collections.Concurrent;

public sealed class DefaultTrace : ITrace
{
    private readonly ITrace? parent;
    private readonly DefaultTracer tracer;
    private readonly ConcurrentDictionary<string, string?> baggage;
    private readonly ConcurrentDictionary<string, string?> tags;

    public DefaultTrace(string name, ITrace? parent, DefaultTracer tracer)
    {
        this.Id = Guid.NewGuid().ToString();
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
        // Do nothing.
    }

    public string Name { get; }

    public string? ParentId => this.parent?.Id;

    public string Id { get; }

    public IReadOnlyDictionary<string, string?> Baggage => this.baggage;

    public IReadOnlyDictionary<string, string?> Tags => this.tags;

    public void AddBaggage(string key, string? value)
    {
        this.baggage.TryAdd(key, value);
    }

    public void AddTag(string key, string? value)
    {
        this.tags.TryAdd(key, value);
    }

    public ITrace CreateChild(string name, TraceKind kind = TraceKind.Internal)
    {
        return this.tracer.StartTrace(name, kind, this);
    }
}
