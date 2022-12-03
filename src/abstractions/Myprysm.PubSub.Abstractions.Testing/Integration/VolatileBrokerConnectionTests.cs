namespace Myprysm.PubSub.Abstractions.Testing.Integration;

using System;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using Myprysm.PubSub.Abstractions;
using NUnit.Framework;

/// <summary>
/// Test suite to implement for a <see cref="Transport.Transient"/> <see cref="IBrokerConnection"/>.
/// </summary>
/// <typeparam name="TOptions">The specialized type of the <see cref="PubSubOptions"/>.</typeparam>
public abstract class VolatileBrokerConnectionTests<TOptions> : BrokerConnectionTests<TOptions>
    where TOptions : PubSubOptions
{
    /// <summary>
    /// Verify that the underlying <see cref="IBrokerConnection"/> supports persistent <see cref="Publication"/>.
    /// </summary>
    [SetUp]
    public void CheckCapability()
    {
        var transport = this.BrokerConnection.Capabilities.Transport;
        if (transport is Transport.Persistent)
        {
            Assert.Ignore("Broker does not support volatile messages.");
        }
    }

    /// <summary>
    /// You should ensure that given a <see cref="Topic"/>
    /// When a <see cref="Publication"/> is published on this <see cref="Topic"/>
    /// And a <see cref="ISubscription"/> is made on this <see cref="Topic"/>
    /// Then the <see cref="Publication"/> is received.
    /// </summary>
    [Test]
    public async Task When_subscription_is_active_before_publication_is_sent_then_publication_is_received()
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

        publications.First()
            .Should()
            .BeEquivalentTo(new
            {
                Topic = topic,
                Message = encodedMessage,
                IsVolatile = true,
            });
    }

    /// <summary>
    /// You should ensure that given a <see cref="Topic"/>
    /// When a <see cref="Publication"/> is published on this <see cref="Topic"/>
    /// And a <see cref="ISubscription"/> is made on this <see cref="Topic"/>
    /// Then the <see cref="Publication"/> is lost.
    /// </summary>
    [Test]
    public async Task When_subscription_is_active_after_publication_is_sent_then_publication_is_lost()
    {
        // Arrange
        var connection = this.BrokerConnection;
        var topic = this.A<Topic>();
        var message = this.A<string>();
        var encodedMessage = EncodeString(message);
        var publication = new Publication(topic, encodedMessage);
        var handler = new PublicationCollectorHandler();

        // Act
        await connection.Publish(publication);
        await connection.Subscribe(topic, handler.HandleAsync);

        // Assert
        var action = handler.Invoking(h => h.GetMessages(TimeSpan.FromMilliseconds(500)));
        action.Should().Throw<TimeoutException>();
    }
}
