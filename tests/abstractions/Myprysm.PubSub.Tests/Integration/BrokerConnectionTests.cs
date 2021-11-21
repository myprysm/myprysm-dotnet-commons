namespace Myprysm.PubSub.Tests.Integration;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.Converter.NewtonsoftJson;
using Myprysm.Converter.NewtonsoftJson.ValueObjects;
using Myprysm.PubSub.Abstractions;
using Myprysm.Testing;
using Myprysm.Tracing.Abstractions;
using NUnit.Framework;

public abstract class BrokerConnectionTests : ServiceTests
{
    protected IBrokerConnection BrokerConnection => this.Services.GetRequiredService<IBrokerConnection>();

    protected ITracer Tracer => this.Services.GetRequiredService<ITracerFactory>().GetTracer(new TracerIdentity("tests", "a version"));

    protected override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddSingleton<ITracerFactory, DefaultTracerFactory>()
            .AddNewtonsoftJsonConverter(settings => settings.ConfigureValueObjectConverters());
    }

    [Test]
    public async Task When_trace_is_provided_then_subscribers_should_have_new_trace_with_parent()
    {
        // Arrange
        var connection = this.BrokerConnection;
        var topic = this.A<Topic>();
        var message = this.A<string>();
        var encodedMessage = EncodeString(message);
        var trace = this.Tracer.StartTrace("trace");
        var publication = new Publication(topic, encodedMessage, Trace: trace);
        var handler = new PublicationCollectorHandler();
        await connection.Subscribe(topic, handler);

        // Act
        await connection.Publish(publication);

        // Assert
        var publications = handler.GetMessages(TimeSpan.FromSeconds(1));

        publications.Should().HaveCount(1);

        var actualTrace = publications.First().Trace;
        actualTrace.Should().NotBeNull();
        actualTrace!.Id.Should().NotBeNullOrEmpty();
        actualTrace.ParentId.Should().Be(trace!.Id);
    }

    [Test]
    public async Task When_trace_is_provided_with_baggage_then_subscribers_should_have_baggage()
    {
        // Arrange
        var connection = this.BrokerConnection;
        var topic = this.A<Topic>();
        var message = this.A<string>();
        var encodedMessage = EncodeString(message);
        var trace = this.Tracer.StartTrace("trace");
        trace!.AddBaggage("a", "value");
            
        var publication = new Publication(topic, encodedMessage, Trace: trace);
        var handler = new PublicationCollectorHandler();
        await connection.Subscribe(topic, handler);

        // Act
        await connection.Publish(publication);

        // Assert
        var publications = handler.GetMessages(TimeSpan.FromSeconds(1));

        publications.Should().HaveCount(1);

        var actualTrace = publications.First().Trace;
        actualTrace.Should().NotBeNull();
        actualTrace!.Id.Should().NotBeNullOrEmpty();
        actualTrace.ParentId.Should().Be(trace.Id);
        actualTrace.Baggage.Should().HaveCount(1);
        actualTrace.Baggage.Should().Contain(new KeyValuePair<string, string?>("a", "value"));
    }

    [Test]
    public async Task When_trace_is_not_provided_then_subscribers_should_have_new_trace_without_parent()
    {
        // Arrange
        var connection = this.BrokerConnection;
        var topic = this.A<Topic>();
        var message = this.A<string>();
        var encodedMessage = EncodeString(message);
        var publication = new Publication(topic, encodedMessage);
        var handler = new PublicationCollectorHandler();
        await connection.Subscribe(topic, handler);

        // Act
        await connection.Publish(publication);

        // Assert
        var publications = handler.GetMessages(TimeSpan.FromSeconds(1));

        publications.Should().HaveCount(1);

        publications.First().Trace.Should().NotBeNull();
        publications.First().Trace!.Id.Should().NotBeNullOrEmpty();
        publications.First().Trace!.ParentId.Should().BeNullOrEmpty();
    }
        
        

    protected static byte[] EncodeString(string value)
    {
        return Encoding.UTF8.GetBytes(value);
    }
}