namespace Myprysm.Tracing.ActivitySource;

using System.Collections.Concurrent;
using Microsoft.Extensions.Options;
using Myprysm.Tracing.Abstractions;

public class ActivitySourceTracerFactory : ITracerFactory
{
    private readonly ConcurrentDictionary<TracerIdentity, ActivitySourceTracer> tracers = new();

    public ActivitySourceTracerFactory(IOptions<StartupTracerOptions> options)
    {
        options.Value.OnStartup.ForEach(id => this.GetTracer(id));
    }

    public IEnumerable<TracerIdentity> RegisteredIdentities => this.tracers.Keys;

    public ITracer GetTracer(TracerIdentity identity)
    {
        return this.tracers.GetOrAdd(identity, id => new ActivitySourceTracer(id));
    }
}
