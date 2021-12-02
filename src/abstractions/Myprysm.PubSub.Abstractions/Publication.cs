namespace Myprysm.PubSub.Abstractions;

using Myprysm.Tracing.Abstractions;

/// <summary>
/// Represents a publication to send to any unknown <see cref="ISubscription"/> handled by an <see cref="IBrokerConnection"/>.
/// </summary>
/// <param name="Topic">The topic to send the publication.</param>
/// <param name="Message">The content of the publication.</param>
/// <param name="IsVolatile">
/// Whether this publication is volatile or persistent.
/// Some brokers only support volatile or persistent publications. You should verify the underlying <see cref="IBrokerConnection.Capabilities"/>.
/// </param>
/// <param name="Trace">
/// The trace used as a parent. You should not have to provide one as the <see cref="IBrokerConnection"/> should try to
/// obtain the <see cref="ITracer.CurrentTrace"/> by itself. This can be useful for testing purpose.
/// </param>
public record Publication(
    Topic Topic,
    byte[] Message,
    bool IsVolatile = true,
    ITrace? Trace = null);
