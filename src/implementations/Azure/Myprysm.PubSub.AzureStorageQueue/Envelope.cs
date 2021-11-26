namespace Myprysm.PubSub.AzureStorageQueue;

using Myprysm.PubSub.Abstractions;

internal sealed record Envelope(
    byte[] Payload,
    SerializedTrace? Trace = null);
