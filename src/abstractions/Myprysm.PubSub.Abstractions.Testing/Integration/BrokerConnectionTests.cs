namespace Myprysm.PubSub.Abstractions.Testing.Integration;

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Options;
using Myprysm.Converter.NewtonsoftJson;
using Myprysm.Converter.NewtonsoftJson.ValueObjects;
using Myprysm.PubSub.Abstractions;
using Myprysm.PubSub.Abstractions.Exceptions;
using Myprysm.SharedKernel.Exceptions;
using Myprysm.Testing.NUnit;
using Myprysm.Tracing.Abstractions;
using NUnit.Framework;

/// <summary>
/// Base test suite for all kind of <see cref="IBrokerConnection"/> that ensures tracing is supported appropriately.
/// </summary>
/// <typeparam name="TOptions"></typeparam>
public abstract class BrokerConnectionTests<TOptions> : ServiceTests
    where TOptions : PubSubOptions
{
    private SubscriptionExceptionHandler subscriptionExceptionHandler = _ => { };

    /// <summary>
    /// Gets the underlying <see cref="IBrokerConnection"/>.
    /// </summary>
    protected IBrokerConnection BrokerConnection => this.Services.GetRequiredService<IBrokerConnection>();

    /// <summary>
    /// Gets the test <see cref="ITracer"/>.
    /// </summary>
    protected ITracer Tracer => this.Services.GetRequiredService<ITracerFactory>().GetTracer(new TracerIdentity("tests", "a version"));


    /// <inheritdoc />
    /// <remarks>Don't forget to call <code>base.ConfigureServices(services, configuration)</code> when you override it.</remarks>
    protected override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services
            .TryAddDefaultTracer()
            .Configure<TOptions>(options => options.GlobalSubscriptionExceptionHandler = exc => this.subscriptionExceptionHandler(exc))
            .AddNewtonsoftJsonConverter(
                options => options.WithTracing = true,
                settings => settings.ConfigureValueObjectConverters());
    }

    /// <summary>
    /// You should send a <code>null</code> message to the provided <see cref="Topic"/>.
    /// </summary>
    /// <param name="topic">The topic to send a null message.</param>
    /// <returns>Completes when the <code>null</code> message has been sent.</returns>
    protected abstract Task SendNullMessage(Topic topic);

    /// <summary>
    /// Ensures that the global subscription exception handler is reset to a default noop value.
    /// </summary>
    [SetUp]
    public void ResetGlobalSubscriptionExceptionHandler()
    {
        this.subscriptionExceptionHandler = _ => { };
    }

    /// <summary>
    /// You should ensure that given a <see cref="Topic"/>
    /// When a <see cref="ISubscription"/> is made on this <see cref="Topic"/>
    /// And a <code>null</code> message is published on this <see cref="Topic"/>
    /// Then the application does not crash.
    /// </summary>
    [Test]
    public async Task When_a_null_message_comes_from_an_external_source_application_does_not_crash()
    {
        // Arrange
        var latch = new CountdownEvent(1);

        void ExceptionHandler(Exception exception)
        {
            exception.Should().BeOfType<SubscriptionHandlerException>();
            latch.Signal();
        }

        this.subscriptionExceptionHandler = ExceptionHandler;
        var connection = this.BrokerConnection;
        var topic = this.A<Topic>();


        [ExcludeFromCodeCoverage]
        Task NotCalled(Publication _)
        {
            return Task.CompletedTask;
        }

        using var _ = connection.Subscribe(topic, NotCalled);

        // Act
        await this.SendNullMessage(topic);

        // Assert
        latch.Wait(TimeSpan.FromSeconds(5)).Should().BeTrue();
    }

    /// <summary>
    /// You should ensure that given a <see cref="Topic"/>
    /// When a <see cref="ISubscription"/> is made on this <see cref="Topic"/>
    /// And a <see cref="Publication"/> is published on this <see cref="Topic"/>
    /// And the subscription handler throws an exception
    /// Then the application does not crash.
    /// </summary>
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
        latch.Wait(TimeSpan.FromSeconds(1)).Should().BeTrue();
    }

    /// <summary>
    /// You should ensure that given a <see cref="Topic"/>
    /// When a <see cref="ISubscription"/> is made on this <see cref="Topic"/>
    /// And a <see cref="Publication"/> is published on this <see cref="Topic"/> with a <see cref="ITrace"/>
    /// Then the <see cref="Publication"/> contains a <see cref="ITrace"/> with a parent.
    /// </summary>
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

    /// <summary>
    /// You should ensure that given a <see cref="Topic"/>
    /// When a <see cref="ISubscription"/> is made on this <see cref="Topic"/>
    /// And a <see cref="Publication"/> is published on this <see cref="Topic"/>
    /// Then the <see cref="Publication"/> contains a <see cref="ITrace"/> with a parent
    /// And the <see cref="ITrace"/> contains the parent baggage.
    /// </summary>
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

    /// <summary>
    /// You should ensure that given a <see cref="Topic"/>
    /// When a <see cref="ISubscription"/> is made on this <see cref="Topic"/>
    /// And a <see cref="Publication"/> is published on this <see cref="Topic"/> without a <see cref="ITrace"/>
    /// Then the <see cref="Publication"/> contains a <see cref="ITrace"/> with a parent.
    /// </summary>
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

    /// <summary>
    /// You should ensure that given a <see cref="IBrokerConnection"/>
    /// When the <see cref="BrokerHealthCheck"/> verifies the health.
    /// Then the <see cref="BrokerHealthCheck"/> returns Healthy
    /// </summary>
    [Test]
    public async Task When_broker_connection_is_up_health_check_returns_healthy()
    {
        // Arrange
        var connection = this.BrokerConnection;
        var healthCheck = new BrokerHealthCheck(connection);

        // Act
        var actual = await healthCheck.CheckHealthAsync(new HealthCheckContext());

        // Assert
        actual.Status.Should().Be(HealthStatus.Healthy);
    }

    /// <summary>
    /// You should ensure that given a disposed <see cref="IBrokerConnection"/>
    /// When the <see cref="BrokerHealthCheck"/> verifies the health.
    /// Then the <see cref="BrokerHealthCheck"/> returns Unhealthy
    /// </summary>
    [Test]
    public async Task When_broker_connection_is_down_health_check_returns_healthy()
    {
        // Arrange
        var connection = this.BrokerConnection;
        var healthCheck = new BrokerHealthCheck(connection);
        connection.Dispose();

        // Act
        var actual = await healthCheck.CheckHealthAsync(new HealthCheckContext());

        // Assert
        actual.Status.Should().Be(HealthStatus.Unhealthy);
    }

    /// <summary>
    /// Encodes the given string with the default UTF-8 encoding.
    /// </summary>
    /// <param name="value">The string to encode.</param>
    /// <returns>The UTF-8 encoded string as a byte array.</returns>
    protected static byte[] EncodeString(string value)
    {
        return Encoding.UTF8.GetBytes(value);
    }
}
