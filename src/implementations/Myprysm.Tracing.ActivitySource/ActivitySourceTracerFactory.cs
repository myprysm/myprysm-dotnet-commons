namespace Myprysm.Tracing.ActivitySource;

using System.Collections.Concurrent;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.Extensions.Options;
using Myprysm.Tracing.Abstractions;

public class ActivitySourceTracerFactory : ITracerFactory
{
    private readonly ConcurrentDictionary<TracerIdentity, ActivitySourceTracer> tracers = new();

    public ActivitySourceTracerFactory(IOptions<StartupTracerOptions> options)
    {
        options.Value.OnStartup.ForEach(id => this.GetTracer(id));
    }

    public IEnumerable<TracerIdentity> RegisteredIdentities => this.tracers.Keys.ToImmutableList();

    public ITracer GetTracer(TracerIdentity identity)
    {
        return this.tracers.GetOrAdd(identity,
            id =>
            {
                var source = new ActivitySource(id.Name, id.Version);
                return new ActivitySourceTracer(id, source);
            });
    }
}
