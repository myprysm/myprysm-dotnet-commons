namespace Myprysm.PubSub.Abstractions;

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Myprysm.SharedKernel.Exceptions;
using Myprysm.Tracing.Abstractions;

public sealed record SerializedTrace : ITrace
{
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

    public string Name => string.Empty;

    public string? ParentId { get; }

    public string Id { get; }

    public IReadOnlyDictionary<string, string?> Baggage { get; }

    public IReadOnlyDictionary<string, string?> Tags { get; }

    public void SetParentId(string parentId)
    {
        throw new NotImplementedException();
    }

    [ExcludeFromCodeCoverage]
    public void AddBaggage(string key, string? value)
    {
        throw new NotImplementedException();
    }

    [ExcludeFromCodeCoverage]
    public void AddTag(string key, string? value)
    {
        throw new NotImplementedException();
    }

    [ExcludeFromCodeCoverage]
    public ITrace CreateChild(string name, TraceKind kind = TraceKind.Internal)
    {
        throw new IllegalOperationException("Unable to create a child trace from a serialized trace");
    }

    [ExcludeFromCodeCoverage]
    public void Dispose()
    {
        // Do nothing.
    }

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
