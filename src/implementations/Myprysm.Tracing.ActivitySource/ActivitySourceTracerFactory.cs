namespace Myprysm.Tracing.ActivitySource;

using System.Collections.Concurrent;
using Microsoft.Extensions.Options;
using Myprysm.Tracing.Abstractions;

/// <summary>
/// Factory that manages instances of <see cref="ActivitySourceTracer"/>.
/// </summary>
public class ActivitySourceTracerFactory : ITracerFactory
{
    private readonly ConcurrentDictionary<TracerIdentity, ActivitySourceTracer> tracers = new();

    /// <summary>
    /// Creates a new <see cref="ActivitySourceTracerFactory"/> with the given startup options.
    /// </summary>
    /// <param name="options">The startup options to register <see cref="TracerIdentity"/> on startup.</param>
    public ActivitySourceTracerFactory(IOptions<StartupTracerOptions> options)
    {
        options.Value.OnStartup.ForEach(id => this.GetTracer(id));
    }

    /// <summary>
    /// Gets the registered identities of this <see cref="ActivitySourceTracerFactory"/>.
    /// </summary>
    public IEnumerable<TracerIdentity> RegisteredIdentities => this.tracers.Keys;

    /// <inheritdoc />
    public ITracer GetTracer(TracerIdentity identity)
    {
        return this.tracers.GetOrAdd(identity, id => new ActivitySourceTracer(id));
    }
}
