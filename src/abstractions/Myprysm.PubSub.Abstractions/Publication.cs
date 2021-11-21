namespace Myprysm.PubSub.Abstractions;

using Myprysm.Tracing.Abstractions;

public record Publication(
    Topic Topic,
    byte[] Message,
    bool IsVolatile = true,
    ITrace? Trace = null);
