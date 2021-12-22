namespace Myprysm.PubSub.AzureStorageQueue;

using Myprysm.PubSub.Abstractions;

internal sealed record Envelope(
    byte[] Payload,
    IDictionary<string, string?>? Headers = null,
    SerializedTrace? Trace = null);
