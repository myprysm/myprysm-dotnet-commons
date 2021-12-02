namespace Myprysm.Tracing.Abstractions;

using System.Diagnostics.CodeAnalysis;

/// <summary>
/// Options used to register tracer identities on startup.
/// This can be useful when using specific implementations (e.g. OpenTelemetry).
/// </summary>
public class StartupTracerOptions
{
    /// <summary>
    /// The list of identities to register on startup.
    /// </summary>
    public List<TracerIdentity> OnStartup { get; [ExcludeFromCodeCoverage] set; } = new();
}
