namespace Myprysm.PubSub.Nats;

using Myprysm.PubSub.Abstractions;

internal sealed record Envelope(
    byte[] Payload,
    SerializedTrace? Trace = null);
