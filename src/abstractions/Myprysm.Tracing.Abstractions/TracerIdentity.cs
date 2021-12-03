namespace Myprysm.Tracing.Abstractions;

/// <summary>
/// Represents the identity of a <see cref="ITracer"/>, usually for a single library.
/// </summary>
/// <param name="Name">The name of the library.</param>
/// <param name="Version">The version of the library.</param>
public record TracerIdentity(
    string Name,
    string? Version);
