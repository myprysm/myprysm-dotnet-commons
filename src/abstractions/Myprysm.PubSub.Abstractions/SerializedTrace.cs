namespace Myprysm.PubSub.Abstractions;

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Myprysm.SharedKernel.Exceptions;
using Myprysm.Tracing.Abstractions;

/// <summary>
/// Represents a trace that has been serialized and transmitted from an original publication.
/// </summary>
/// <remarks>
/// This trace should only be used in <see cref="ISubscription"/> to initiate the consumer trace.
/// </remarks>
public sealed record SerializedTrace : ITrace
{
    /// <summary>
    /// Creates a new <see cref="SerializedTrace"/>.
    /// </summary>
    /// <param name="parentId">The optional parent id of the original trace.</param>
    /// <param name="id">The id of the original trace.</param>
    /// <param name="baggage">The optional baggage of the original trace.</param>
    public SerializedTrace(
        string? parentId,
        string id,
        Dictionary<string, string?>? baggage)
    {
        this.ParentId = parentId;
        this.Id = id;
        this.Baggage = baggage ?? new Dictionary<string, string?>();
        this.Tags = new Dictionary<string, string?>();
    }

    /// <inheritdoc />
    public string Name => string.Empty;

    /// <inheritdoc />
    public string? ParentId { get; }

    /// <inheritdoc />
    public string Id { get; }

    /// <inheritdoc />
    public IReadOnlyDictionary<string, string?> Baggage { get; }

    /// <inheritdoc />
    public IReadOnlyDictionary<string, string?> Tags { get; }

    /// <inheritdoc />
    public void SetParentId(string parentId)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    [ExcludeFromCodeCoverage]
    public void AddBaggage(string key, string? value)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    [ExcludeFromCodeCoverage]
    public void AddTag(string key, string? value)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    [ExcludeFromCodeCoverage]
    public ITrace CreateChild(string name, TraceKind kind = TraceKind.Internal)
    {
        throw new IllegalOperationException("Unable to create a child trace from a serialized trace");
    }

    /// <inheritdoc />
    [ExcludeFromCodeCoverage]
    public void Dispose()
    {
        // Do nothing.
    }

    /// <summary>
    /// Create a serialized trace that can be sent over the wire from a given <see cref="ITrace"/>.
    /// </summary>
    /// <param name="trace">The trace to convert.</param>
    /// <returns></returns>
    public static SerializedTrace? GetSerializedTrace(ITrace? trace)
    {
        return trace is null
            ? null
            : new SerializedTrace(
                trace.ParentId,
                trace.Id,
                new Dictionary<string, string?>(trace.Baggage));
    }
}
