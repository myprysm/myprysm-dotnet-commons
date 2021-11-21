namespace Myprysm.PubSub.Abstractions;

public enum Transport
{
    /// <summary>
    /// Messages can be lost when there is no subscription bound to a topic.
    /// </summary>
    Transient,

    /// <summary>
    /// Messages are persisted until a subscription is made to a topic.
    /// </summary>
    Persistent,

    /// <summary>
    /// Supports both <see cref="Transient"/> and <see cref="Persistent"/> transports.
    /// </summary>
    Both,
}

/// <summary>
/// Capabilities provided by a broker.
/// </summary>
/// <param name="Transport">The type of transport.</param>
/// <param name="Replay">Indicates whether the broker supports replays (API not specified yet).</param>
/// <param name="SubscriptionGroups">Indicates whether the broker supports subscription groups a.k.a. competing consumers.</param>
public sealed record BrokerCapabilities(
    Transport Transport,
    bool Replay,
    bool SubscriptionGroups)
{
    /// <summary>
    /// Indicates the supported transport kinds.
    /// </summary>
    public Transport Transport { get; } = Transport;

    /// <summary>
    /// Indicates whether the broker has replay capabilities 
    /// </summary>
    public bool Replay { get; } = Replay;

    /// <summary>
    /// Indicates whether the broker supports grouped subscriptions (group of competing consumers).
    /// </summary>
    public bool SubscriptionGroups { get; } = SubscriptionGroups;
}
