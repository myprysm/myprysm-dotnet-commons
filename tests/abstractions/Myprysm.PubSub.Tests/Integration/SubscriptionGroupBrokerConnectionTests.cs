namespace Myprysm.PubSub.Tests.Integration;

using System;
using System.Threading.Tasks;
using FluentAssertions;
using Myprysm.PubSub.Abstractions;
using NUnit.Framework;

public abstract class SubscriptionGroupBrokerConnectionTests : BrokerConnectionTests
{
    [Test]
    public async Task When_two_subscriptions_are_active_then_both_receive_publication()
    {
        // Arrange
        var connection = this.BrokerConnection;
        var topic = this.A<Topic>();
        var message = this.A<string>();
        var encodedMessage = EncodeString(message);
        var publication = new Publication(topic, encodedMessage);
        var handler = new PublicationCollectorHandler();

        await connection.Subscribe(topic, handler);
        await connection.Subscribe(topic, handler);

        // Act
        await connection.Publish(publication);

        // Assert
        var publications = handler.GetMessages(TimeSpan.FromSeconds(1), 2);
        publications.Should().HaveCount(2);
    }

    [Test]
    public async Task
        When_two_subscriptions_are_active_in_the_same_subscription_group_then_only_one_receive_publication()
    {
        // Arrange
        var connection = this.BrokerConnection;
        var topic = this.A<Topic>();
        var subscriptionGroup = this.A<SubscriptionGroup>();
        var message = this.A<string>();
        var encodedMessage = EncodeString(message);
        var publication = new Publication(topic, encodedMessage);
        var handler = new PublicationCollectorHandler();

        await connection.Subscribe(topic, handler, subscriptionGroup);
        await connection.Subscribe(topic, handler, subscriptionGroup);

        // Act
        await connection.Publish(publication);

        // Assert
        var publications = handler.GetMessages(TimeSpan.FromSeconds(1));
        publications.Should().HaveCount(1);

        // Ensure the buffer is really empty
        var action = handler.Invoking(h => h.GetMessages(TimeSpan.FromMilliseconds(500)));
        action.Should().Throw<TimeoutException>();
    }

    [Test]
    public async Task
        When_two_subscriptions_are_active_in_different_subscription_groups_then_both_receive_publication()
    {
        // Arrange
        var connection = this.BrokerConnection;
        var topic = this.A<Topic>();
        var firstSubscriptionGroup = this.A<SubscriptionGroup>();
        var secondSubscriptionGroup = this.A<SubscriptionGroup>();
        var message = this.A<string>();
        var encodedMessage = EncodeString(message);
        var publication = new Publication(topic, encodedMessage);
        var handler = new PublicationCollectorHandler();

        await connection.Subscribe(topic, handler, firstSubscriptionGroup);
        await connection.Subscribe(topic, handler, secondSubscriptionGroup);

        // Act
        await connection.Publish(publication);

        // Assert
        var publications = handler.GetMessages(TimeSpan.FromSeconds(1), 2);
        publications.Should().HaveCount(2);
    }
}