namespace Myprysm.Tracing.Abstractions;

public interface ITrace : IDisposable
{
    string Name { get; }
    string? ParentId { get; }
    string Id { get; }

    IReadOnlyDictionary<string, string?> Baggage { get; }

    IReadOnlyDictionary<string, string?> Tags { get; }

    void AddBaggage(string key, string? value);

    void AddTag(string key, string? value);

    ITrace? CreateChild(string name, TraceKind kind = TraceKind.Internal);
}