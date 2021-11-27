namespace Myprysm.Tracing.OpenTelemetry.Tests.Integration;

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using FluentAssertions;
using global::OpenTelemetry.Trace;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.Testing.NUnit;
using Myprysm.Tracing.Abstractions;
using NUnit.Framework;

[TestFixture]
[Category(Categories.Integration)]
public class TracingTests : ServiceTests
{
    private List<Activity> exportedActivities = null!;
    private TracerIdentity firstIdentity = null!;
    private TracerIdentity secondIdentity = null!;

    [SetUp]
    public void LoadOpenTelemetry()
    {
        // This ensures OpenTelemetry SDK is loaded as well as our custom identities.
        this.Services.GetRequiredService<TracerProvider>();
    }

    protected override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        this.firstIdentity = this.A<TracerIdentity>();
        this.secondIdentity = this.A<TracerIdentity>();

        this.exportedActivities = new List<Activity>();
        services
            .AddMyprysmOpenTelemetryTracing((_, builder) => { builder.AddInMemoryExporter(this.exportedActivities); })
            .RegisterTracerOnStartup(this.firstIdentity)
            .RegisterTracerOnStartup(this.secondIdentity);
    }

    [Test]
    public void WhenTraceIsStarted_ThenTraceHasProvidedName()
    {
        // Arrange
        var name = this.A<string>();
        var tracer = this.GetSut(this.firstIdentity);
        using var trace = tracer.StartTrace(name);

        // Act + Assert
        trace!.Name.Should().Be(name);
    }

    [Test]
    public void WhenTagIsAdded_ThenTagIsAvailable()
    {
        // Arrange
        var name = this.A<string>();
        var tracer = this.GetSut(this.firstIdentity);
        using var trace = tracer.StartTrace(name);
        var tagKey = this.A<string>();
        var tagValue = this.A<string>();

        // Act
        trace!.AddTag(tagKey, tagValue);

        // Assert
        trace.Tags.Should().Contain(new KeyValuePair<string, string?>(tagKey, tagValue));
    }

    [Test]
    public void WhenTraceIsStarted_ThenCurrentTraceIsAvailableOnTracer()
    {
        // Arrange
        var name = this.A<string>();
        var tracer = this.GetSut(this.firstIdentity);
        using var trace = tracer.StartTrace(name);

        // Act + Assert
        tracer.CurrentTrace.Should().Be(trace);
    }


    [Test]
    public void WhenTraceIsDisposed_ThenTraceIsExported()
    {
        // Arrange
        var name = this.A<string>();
        var tracer = this.GetSut(this.firstIdentity);
        var trace = tracer.StartTrace(name);

        // Act
        trace!.Dispose();

        // Assert
        this.exportedActivities.Should().HaveCount(1);

        var activity = this.exportedActivities.First();

        activity.DisplayName.Should().Be(name);
    }

    [Test]
    public void WhenTraceIsDisposed_ThenCurrentTraceIsNull()
    {
        // Arrange
        var name = this.A<string>();
        var tracer = this.GetSut(this.firstIdentity);
        var trace = tracer.StartTrace(name);

        // Act
        trace!.Dispose();

        // Assert
        tracer.CurrentTrace.Should().BeNull();
    }

    [Test]
    public void WhenParentTraceIsStartedFromFirstTracer_AndChildTraceIsStartedFromSecondTracer_ThenNewTraceHasParent()
    {
        // Arrange
        var firstName = this.A<string>();
        var firstTracer = this.GetSut(this.firstIdentity);
        var firstTrace = firstTracer.StartTrace(firstName);

        var secondName = this.A<string>();
        var secondTracer = this.GetSut(this.secondIdentity);
        var secondTrace = secondTracer.StartTrace(secondName);

        // Act
        secondTrace!.Dispose();
        firstTrace!.Dispose();


        // Assert
        this.exportedActivities.Should().HaveCount(2);

        var secondActivity = this.exportedActivities.First();
        var firstActivity = this.exportedActivities.Skip(1).First();

        secondActivity.ParentId.Should().Be(firstActivity.Id);
    }

    [Test]
    public void WhenChildTraceIsStartedFromParentTask_ThenNewTraceHasParent()
    {
        // Arrange
        var name = this.A<string>();
        var tracer = this.GetSut(this.firstIdentity);
        using var parentTrace = tracer.StartTrace(name);

        var childName = this.A<string>();

        // Act
        using var childTrace = parentTrace!.CreateChild(childName);

        // Assert
        childTrace!.ParentId.Should().Be(parentTrace.Id);
    }

    [Test]
    public void WhenChildTraceIsStartedFromParentTask_ThenNewTraceHasParentBaggage()
    {
        // Arrange
        var name = this.A<string>();
        var tracer = this.GetSut(this.firstIdentity);
        using var parentTrace = tracer.StartTrace(name);
        var baggageKey = this.A<string>();
        var baggageValue = this.A<string>();
        parentTrace!.AddBaggage(baggageKey, baggageValue);

        var childName = this.A<string>();

        // Act
        using var childTrace = parentTrace.CreateChild(childName);

        // Assert
        childTrace!.Baggage.Should().Contain(new KeyValuePair<string, string?>(baggageKey, baggageValue));
    }

    [Test]
    public void WhenChildTraceIsStartedFromParentTask_ThenNewTraceDoesNotHaveParentTags()
    {
        // Arrange
        var name = this.A<string>();
        var tracer = this.GetSut(this.firstIdentity);
        using var parentTrace = tracer.StartTrace(name);
        var tagKey = this.A<string>();
        var tagValue = this.A<string>();
        parentTrace!.AddTag(tagKey, tagValue);

        var childName = this.A<string>();

        // Act
        using var childTrace = parentTrace.CreateChild(childName);

        // Assert
        childTrace!.Tags.Should().BeEmpty();
    }

    [Test]
    public void WhenTraceHasAlreadyOneParent_ThenSetParentIdDoesNothing()
    {
        // Arrange
        var tracer = this.GetSut(this.firstIdentity);
        using var parentTrace = tracer.StartTrace(this.A<string>());
        using var otherTrace = tracer.StartTrace(this.A<string>());
        using var childTrace = tracer.StartTrace(this.A<string>());


        // Act
        childTrace!.SetParent(parentTrace!);

        // Assert
        childTrace.ParentId.Should().Be(otherTrace!.Id);
    }

    private ITracer GetSut(TracerIdentity tracerIdentity)
    {
        return this.Services
            .GetRequiredService<ITracerFactory>()
            .GetTracer(tracerIdentity);
    }
}
