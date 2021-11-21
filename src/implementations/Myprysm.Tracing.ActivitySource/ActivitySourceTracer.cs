namespace Myprysm.Tracing.ActivitySource;

using System.Diagnostics;
using Myprysm.Tracing.Abstractions;

public class ActivitySourceTracer : ITracer
{
    public ActivitySourceTracer(TracerIdentity identity, ActivitySource activitySource)
    {
        this.Identity = identity;
        this.ActivitySource = activitySource;
    }

    public TracerIdentity Identity { get; }

    public ActivitySource ActivitySource { get; }

    public string Name => this.ActivitySource.Name;

    public ITrace? CurrentTrace => Activity.Current is null
        ? null
        : new ActivityTrace(Activity.Current, this);

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
