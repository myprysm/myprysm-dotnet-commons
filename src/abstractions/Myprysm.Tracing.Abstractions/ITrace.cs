namespace Myprysm.Tracing.Abstractions;

using Myprysm.SharedKernel.Exceptions;

public interface ITrace : IDisposable
{
    string Name { get; }

    string? ParentId { get; }

    string Id { get; }

    IReadOnlyDictionary<string, string?> Baggage { get; }

    IReadOnlyDictionary<string, string?> Tags { get; }

    /// <summary>
    /// Sets the parent trace.
    /// </summary>
    /// <exception cref="IllegalOperationException">When the trace already has a parent.</exception>
    /// <param name="parent">The parent trace.</param>
    void SetParent(ITrace parent)
    {
        this.SetParentId(parent.Id);
    }

    /// <summary>
    /// Sets the parent trace id.
    /// </summary>
    /// <exception cref="IllegalOperationException">When the trace already has a parent.</exception>
    /// <param name="parentId">The parent trace id.</param>
    void SetParentId(string parentId);

    void AddBaggage(string key, string? value);

    void AddTag(string key, string? value);

    ITrace? CreateChild(string name, TraceKind kind = TraceKind.Internal);
}
