namespace Myprysm.PubSub.Nats;

using System.Diagnostics;
using System.Reflection;
using Myprysm.Tracing.Abstractions;

public static class PubSubNatsConstants
{
    public static readonly Assembly Assembly = typeof(PubSubNatsConstants).Assembly;
    public static readonly FileVersionInfo FileVersionInfo = FileVersionInfo.GetVersionInfo(Assembly.Location);
    public static readonly string Version = FileVersionInfo.ProductVersion ?? "0.1.0";
    public static readonly string TracerName = typeof(PubSubNatsConstants).Assembly.FullName ?? "Myprysm.PubSub.Nats";

    public static readonly TracerIdentity TracerIdentity = new(TracerName, Version);
}
