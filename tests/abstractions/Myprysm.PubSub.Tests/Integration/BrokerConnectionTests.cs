namespace Myprysm.PubSub.Tests.Integration;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Myprysm.Converter.NewtonsoftJson;
using Myprysm.Converter.NewtonsoftJson.ValueObjects;
using Myprysm.PubSub.Abstractions;
using Myprysm.PubSub.Abstractions.Exceptions;
using Myprysm.SharedKernel.Exceptions;
using Myprysm.Testing;
using Myprysm.Tracing.Abstractions;
using NUnit.Framework;

public abstract class BrokerConnectionTests<TOptions> : ServiceTests
    where TOptions : PubSubOptions
{
    protected IBrokerConnection BrokerConnection => this.Services.GetRequiredService<IBrokerConnection>();

    protected ITracer Tracer => this.Services.GetRequiredService<ITracerFactory>().GetTracer(new TracerIdentity("tests", "a version"));

    protected override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddSingleton<ITracerFactory, DefaultTracerFactory>()
            .AddNewtonsoftJsonConverter(
                options => options.WithTracing = true,
                settings => settings.ConfigureValueObjectConverters());
    }

    protected abstract Task SendNullMessage(Topic topic);

    [SetUp]
    public void ResetGlobalSubscriptionExceptionHandler()
    {
        this.Services.GetRequiredService<IOptions<TOptions>>().Value.GlobalSubscriptionExceptionHandler = delegate { };
    }

    [Test]
    public async Task When_a_null_message_comes_from_an_external_source_application_does_not_crash()
    {
        // Arrange
        var connection = this.BrokerConnection;
        var topic = this.A<Topic>();
        var latch = new CountdownEvent(1);

        void ExceptionHandler(Exception exception)
        {
            exception.Should().BeOfType<SubscriptionHandlerException>();
            latch.Signal();
        }


        this.Services.GetRequiredService<IOptions<TOptions>>().Value.GlobalSubscriptionExceptionHandler = ExceptionHandler;

        using var _ = connection.Subscribe(topic, _ => Task.CompletedTask);

        // Act
        await this.SendNullMessage(topic);

        // Assert
        latch.Wait(TimeSpan.FromSeconds(1));
    }

    [Test]
    public async Task When_a_message_handler_throws_application_does_not_crash()
    {
        // Arrange
        var connection = this.BrokerConnection;
        var topic = this.A<Topic>();
        var message = this.A<string>();
        var encodedMessage = EncodeString(message);
        var latch = new CountdownEvent(1);

        void ExceptionHandler(Exception exception)
        {
            exception.Should().BeOfType<ConflictException>();
            latch.Signal();
        }

        using var _ = connection.Subscribe(topic, _ => throw new ConflictException("test"), exceptionHandler: ExceptionHandler);

        // Act
        await connection.Publish(new Publication(topic, encodedMessage));

        // Assert
        latch.Wait(TimeSpan.FromSeconds(1));
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
        await connection.Subscribe(topic, handler.HandleAsync);

        // Act
        await connection.Publish(publication);

        // Assert
        var publications = handler.GetMessages(TimeSpan.FromSeconds(1));

        publications.Should().HaveCount(1);

        var actualTrace = publications.First().Trace;
        actualTrace.Should().NotBeNull();
        actualTrace!.Id.Should().NotBeNullOrEmpty();
        actualTrace.ParentId.Should().NotBeNullOrEmpty();
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
        await connection.Subscribe(topic, handler.HandleAsync);

        // Act
        await connection.Publish(publication);

        // Assert
        var publications = handler.GetMessages(TimeSpan.FromSeconds(1));

        publications.Should().HaveCount(1);

        var actualTrace = publications.First().Trace;
        actualTrace.Should().NotBeNull();
        actualTrace!.Id.Should().NotBeNullOrEmpty();
        actualTrace.ParentId.Should().NotBeNullOrEmpty();
        actualTrace.Baggage.Should().HaveCount(1);
        actualTrace.Baggage.Should().Contain(new KeyValuePair<string, string?>("a", "value"));
    }

    [Test]
    public async Task When_trace_is_not_provided_then_subscribers_should_have_new_trace_with_parent()
    {
        // Arrange
        var connection = this.BrokerConnection;
        var topic = this.A<Topic>();
        var message = this.A<string>();
        var encodedMessage = EncodeString(message);
        var publication = new Publication(topic, encodedMessage);
        var handler = new PublicationCollectorHandler();
        await connection.Subscribe(topic, handler.HandleAsync);

        // Act
        await connection.Publish(publication);

        // Assert
        var publications = handler.GetMessages(TimeSpan.FromSeconds(1));

        publications.Should().HaveCount(1);

        publications.First().Trace.Should().NotBeNull();
        publications.First().Trace!.Id.Should().NotBeNullOrEmpty();
        publications.First().Trace!.ParentId.Should().NotBeNullOrEmpty();
    }


    protected static byte[] EncodeString(string value)
    {
        return Encoding.UTF8.GetBytes(value);
    }
}
