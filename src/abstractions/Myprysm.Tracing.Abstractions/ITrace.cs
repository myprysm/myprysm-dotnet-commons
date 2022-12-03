namespace Myprysm.Tracing.Abstractions;

using Myprysm.SharedKernel.Exceptions;

/// <summary>
/// An application trace for telemetry.
/// </summary>
public interface ITrace : IDisposable
{
    /// <summary>
    /// Gets the trace name. 
    /// </summary>
    string Name { get; }

    /// <summary>
    /// Gets the trace parent identifier.
    /// </summary>
    string? ParentId { get; }

    /// <summary>
    /// Gets the trace identifier.
    /// </summary>
    string Id { get; }

    /// <summary>
    /// Gets a readonly view of the trace baggage.
    /// </summary>
    IReadOnlyDictionary<string, string?> Baggage { get; }

    /// <summary>
    /// Gets a readonly view of the trace tags.
    /// </summary>
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

    /// <summary>
    /// Adds a baggage item with a key and a value to this trace.
    /// </summary>
    /// <param name="key">The baggage key.</param>
    /// <param name="value">The baggage value.</param>
    void AddBaggage(string key, string? value);


    /// <summary>
    /// Adds a tag item with a key and a value to this trace.
    /// </summary>
    /// <param name="key">The tag key.</param>
    /// <param name="value">The tag value.</param>
    void AddTag(string key, string? value);

    /// <summary>
    /// Creates a child trace with this trace as parent and the given kind.
    /// </summary>
    /// <param name="name">The name of the child trace.</param>
    /// <param name="kind">The kind of the child trace.</param>
    /// <returns></returns>
    ITrace? CreateChild(string name, TraceKind kind = TraceKind.Internal);
}
