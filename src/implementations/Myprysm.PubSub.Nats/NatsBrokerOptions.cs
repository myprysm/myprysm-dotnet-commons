namespace Myprysm.PubSub.Nats;

public class NatsBrokerOptions
{
    public bool WithSsl { get; set; }

    public string Url { get; set; } = string.Empty;

    public string KeyStorePath { get; set; } = string.Empty;

    public string KeyStorePassword { get; set; } = string.Empty;

    public string TrustStorePath { get; set; } = string.Empty;

    public string TrustStorePassword { get; set; } = string.Empty;

    public bool TrustAllCertificates { get; set; }

    public string User { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;
}
