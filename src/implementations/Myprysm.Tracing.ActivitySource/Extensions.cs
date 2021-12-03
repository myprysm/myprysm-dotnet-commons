namespace Myprysm.Tracing.ActivitySource;

using System.Diagnostics;
using Myprysm.Tracing.Abstractions;

internal static class Extensions
{
    public static ActivityKind MapTraceKind(this TraceKind kind) => kind switch
    {
        TraceKind.Internal => ActivityKind.Internal,
        TraceKind.Client => ActivityKind.Client,
        TraceKind.Server => ActivityKind.Server,
        TraceKind.Producer => ActivityKind.Producer,
        TraceKind.Consumer => ActivityKind.Consumer,
        _ => throw new ArgumentOutOfRangeException(nameof(kind), kind, null)
    };
}
