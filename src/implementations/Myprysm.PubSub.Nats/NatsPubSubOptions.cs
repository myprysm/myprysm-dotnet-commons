namespace Myprysm.PubSub.Nats;

using Myprysm.PubSub.Abstractions;

/// <summary>
/// <see cref="NatsBrokerConnection"/> options to send and receive <see cref="Publication"/>.
/// </summary>
public class NatsPubSubOptions : PubSubOptions
{
    /// <summary>
    /// Enables TLS/SSL for the underlying NATS connection.
    /// </summary>
    public bool WithSsl { get; set; }

    /// <summary>
    /// Gets or sets the URL for the underlying NATS connection.
    /// </summary>
    public string Url { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the keystore path for the underlying NATS connection.
    /// </summary>
    public string KeyStorePath { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the keystore password for the underlying NATS connection.
    /// </summary>
    public string KeyStorePassword { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the truststore path for the underlying NATS connection.
    /// </summary>
    public string TrustStorePath { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the truststore password for the underlying NATS connection.
    /// </summary>
    public string TrustStorePassword { get; set; } = string.Empty;

    /// <summary>
    /// Disables TLS/SSL certificates validation.
    /// </summary>
    /// <remarks>
    /// Use only for development or at your own risks.
    /// </remarks>
    public bool TrustAllCertificates { get; set; }

    /// <summary>
    /// Gets or sets the user for the underlying NATS connection.
    /// </summary>
    public string User { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the password for the underlying NATS connection.
    /// </summary>
    public string Password { get; set; } = string.Empty;
}
