namespace Myprysm.Tracing.Abstractions;

using System.Collections.Concurrent;
using System.Collections.Immutable;
using Microsoft.Extensions.Options;

public class DefaultTracerFactory : ITracerFactory
{
    private readonly ConcurrentDictionary<TracerIdentity, DefaultTracer> tracers = new();

    public DefaultTracerFactory(IOptions<StartupTracerOptions> options)
    {
        options.Value.OnStartup.ForEach(id => this.GetTracer(id));
    }

    public IEnumerable<TracerIdentity> RegisteredIdentities => this.tracers.Keys.ToImmutableList();

    public ITracer GetTracer(TracerIdentity identity)
    {
        return this.tracers.GetOrAdd(identity, id => new DefaultTracer(id));
    }
}
