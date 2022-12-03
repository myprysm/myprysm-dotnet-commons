namespace Myprysm.PubSub.Nats;

using System.Diagnostics;
using System.Reflection;
using Myprysm.Tracing.Abstractions;

internal static class PubSubNatsConstants
{
    internal const string TraceIdHeader = "mpm-trace-id";
    internal const string TraceBaggageHeader = "mpm-trace-baggage";

    internal static readonly IEnumerable<string> ProtectedHeaders = new[]
    {
        TraceIdHeader,
        TraceBaggageHeader,
    };

    private static readonly Assembly Assembly = typeof(PubSubNatsConstants).Assembly;
    private static readonly FileVersionInfo FileVersionInfo = FileVersionInfo.GetVersionInfo(Assembly.Location);
    private static readonly string Version = FileVersionInfo.ProductVersion ?? "0.1.0";
    private static readonly string TracerName = typeof(PubSubNatsConstants).Assembly.FullName ?? "Myprysm.PubSub.Nats";

    public static readonly TracerIdentity TracerIdentity = new(TracerName, Version);
}
