namespace Myprysm.PubSub.Tests.Integration;

using System;
using System.Threading.Tasks;
using FluentAssertions;
using Myprysm.PubSub.Abstractions;
using NUnit.Framework;

public abstract class PersistentBrokerConnectionTests : BrokerConnectionTests
{
    [SetUp]
    public void CheckCapability()
    {
        var transport = this.BrokerConnection.Capabilities.Transport;
        if (transport is Transport.Transient)
        {
            Assert.Ignore("Broker does not support persistent messages.");
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
        var publication = new Publication(topic, encodedMessage, false);
        var handler = new PublicationCollectorHandler();
        await connection.Subscribe(topic, handler);

        // Act
        await connection.Publish(publication);

        // Assert
        var publications = handler.GetMessages(TimeSpan.FromSeconds(1));

        publications.Should().HaveCount(1).And.ContainEquivalentOf(publication, options => options.Excluding(p => p.Trace));
    }

    [Test]
    public async Task When_subscription_is_active_after_publication_is_sent_then_publication_is_received()
    {
        // Arrange
        var connection = this.BrokerConnection;
        var topic = this.A<Topic>();
        var message = this.A<string>();
        var encodedMessage = EncodeString(message);
        var publication = new Publication(topic, encodedMessage, false);
        var handler = new PublicationCollectorHandler();

        // Act
        await connection.Publish(publication);
        await connection.Subscribe(topic, handler);

        // Assert
        var publications = handler.GetMessages(TimeSpan.FromSeconds(1));

        publications.Should().HaveCount(1).And.ContainEquivalentOf(publication, options => options.Excluding(p => p.Trace));
    }
}