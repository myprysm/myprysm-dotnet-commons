﻿namespace Myprysm.Tracing.ApplicationInsights.Tests.Integration;

using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.Testing;
using Myprysm.Tracing.Abstractions;
using NUnit.Framework;

[TestFixture]
[Category(Categories.Integration)]
public class TracingTests : ServiceTests
{
    private List<ITelemetry> exportedTelemetry = null!;
    private TracerIdentity firstIdentity = null!;
    private TracerIdentity secondIdentity = null!;

    protected override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        this.firstIdentity = this.A<TracerIdentity>();
        this.secondIdentity = this.A<TracerIdentity>();

        this.exportedTelemetry = new List<ITelemetry>();

        var telemetryClient = new TelemetryClient(new TelemetryConfiguration
        {
            TelemetryChannel = new CollectorTelemetryChannel(this.exportedTelemetry),
        });

        services
            .AddSingleton(telemetryClient)
            .AddApplicationInsightsTracer();
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
        this.exportedTelemetry.Should().HaveCount(1);

        var telemetry = this.exportedTelemetry.First();

        telemetry.Context.Operation.Name.Should().Be(name);
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
        this.exportedTelemetry.Should().HaveCount(2);

        var secondTelemetry = this.exportedTelemetry.First();
        var firstTelemetry = this.exportedTelemetry.Skip(1).First();

        secondTelemetry.Context.Operation.ParentId.Should().Be(((DependencyTelemetry)firstTelemetry).Id);
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
    public void WhenChildTraceIsStartedFromParentTask_ThenNewTraceDoesNotHaveParentBaggage()
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
        FilterOutTracerIdentity(childTrace!.Baggage).Should().BeEmpty();
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
        FilterOutTracerIdentity(childTrace!.Tags).Should().BeEmpty();
    }

    [Test]
    public void WhenTraceHasAlreadyOneParent_ThenSetParentIdChangesParent()
    {
        // Arrange
        var tracer = this.GetSut(this.firstIdentity);
        using var parentTrace = tracer.StartTrace(this.A<string>());
        using var otherTrace = tracer.StartTrace(this.A<string>());
        using var childTrace = tracer.StartTrace(this.A<string>());


        // Act
        childTrace!.SetParent(parentTrace!);

        // Assert
        childTrace.ParentId.Should().Be(parentTrace!.Id);
    }

    private static IEnumerable<KeyValuePair<string, string?>> FilterOutTracerIdentity(IEnumerable<KeyValuePair<string, string?>> entries)
        => entries
            .Where(e => e.Key != nameof(TracerIdentity.Name))
            .Where(e => e.Key != nameof(TracerIdentity.Version))
            .Where(e => e.Key != nameof(CollectorTelemetryChannel.DeveloperMode));

    private ITracer GetSut(TracerIdentity tracerIdentity)
    {
        return this.Services
            .GetRequiredService<ITracerFactory>()
            .GetTracer(tracerIdentity);
    }
}
