namespace Myprysm.PubSub.Tests.Integration;

using System;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using Myprysm.PubSub.Abstractions;
using NUnit.Framework;

public abstract class VolatileBrokerConnectionTests : BrokerConnectionTests
{
    [SetUp]
    public void CheckCapability()
    {
        var transport = this.BrokerConnection.Capabilities.Transport;
        if (transport is Transport.Persistent)
        {
            Assert.Ignore("Broker does not support volatile messages.");
        }
    }

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
        await connection.Subscribe(topic, handler);

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
        await connection.Subscribe(topic, handler);

        // Assert
        var action = handler.Invoking(h => h.GetMessages(TimeSpan.FromMilliseconds(500)));
        action.Should().Throw<TimeoutException>();
    }
}