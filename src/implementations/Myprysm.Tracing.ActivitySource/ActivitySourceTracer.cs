namespace Myprysm.Tracing.ActivitySource;

using System.Diagnostics;
using Myprysm.Tracing.Abstractions;

/// <summary>
/// A tracer wrapping an <see cref="System.Diagnostics.ActivitySource"/> for application telemetry.
/// </summary>
public sealed class ActivitySourceTracer : ITracer
{
    /// <summary>
    /// Creates a new <see cref="ActivitySourceTracer"/>.
    /// </summary>
    /// <param name="identity">The tracer identity.</param>
    public ActivitySourceTracer(TracerIdentity identity)
    {
        this.Identity = identity;
        this.ActivitySource = new ActivitySource(identity.Name, identity.Version);
    }

    /// <inheritdoc />
    public TracerIdentity Identity { get; }


    /// <summary>
    /// Gets the underlying <see cref="ActivitySource"/> of this tracer.
    /// </summary>
    public ActivitySource ActivitySource { get; }

    /// <inheritdoc />
    public ITrace? CurrentTrace => Activity.Current switch
    {
        null => null,
        _ => new ActivityTrace(Activity.Current, this),
    };

    /// <inheritdoc />
    public ITrace? StartTrace(string name, TraceKind kind = TraceKind.Internal, ITrace? parent = null)
    {
        var parentContext = this.GetParentContext(parent);

        var activityKind = kind.MapTraceKind();
        var activity = this.ActivitySource.StartActivity(name, activityKind, parentContext);

        if (activity is null)
        {
            return null;
        }

        if (parent is not null)
        {
            if (parent.Baggage.Any())
            {
                foreach (var (key, value) in parent.Baggage)
                {
                    activity.AddBaggage(key, value);
                }
            }
        }


        activity.Start();
        return new ActivityTrace(activity, this);
    }

    private ActivityContext GetParentContext(ITrace? parent)
    {
        if (parent is ActivityTrace activityParent)
        {
            return activityParent.Activity.Context;
        }

        if (this.CurrentTrace is ActivityTrace activityCurrent)
        {
            return activityCurrent.Activity.Context;
        }

        return ActivityContext.TryParse(parent?.Id, null, out var context)
            ? context
            : default;
    }
}
