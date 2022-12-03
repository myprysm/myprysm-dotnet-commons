namespace Myprysm.PubSub.Abstractions.Testing.Integration;

using System;
using System.Threading.Tasks;
using FluentAssertions;
using Myprysm.PubSub.Abstractions;
using NUnit.Framework;

/// <summary>
/// Test suite to implement for a <see cref="IBrokerConnection"/> that supports <see cref="SubscriptionGroup"/>.
/// </summary>
/// <typeparam name="TOptions">The specialized type of the <see cref="PubSubOptions"/>.</typeparam>
public abstract class SubscriptionGroupBrokerConnectionTests<TOptions> : BrokerConnectionTests<TOptions>
    where TOptions : PubSubOptions
{
    /// <summary>
    /// Verify that the underlying <see cref="IBrokerConnection"/> supports <see cref="SubscriptionGroup"/>.
    /// </summary>
    [SetUp]
    public void CheckCapability()
    {
        if (!this.BrokerConnection.Capabilities.SubscriptionGroups)
        {
            Assert.Ignore("Broker does not support persistent messages.");
        }
    }

    /// <summary>
    /// You should ensure that given a <see cref="Topic"/>
    /// When a <see cref="Publication"/> is published on this <see cref="Topic"/>
    /// And a <see cref="ISubscription"/> is made without subscription group on this <see cref="Topic"/>
    /// And a <see cref="ISubscription"/> is made without subscription group on this <see cref="Topic"/>
    /// Then all <see cref="ISubscription"/> receive the <see cref="Publication"/>.
    /// </summary>
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

        await connection.Subscribe(topic, handler.HandleAsync);
        await connection.Subscribe(topic, handler.HandleAsync);

        // Act
        await connection.Publish(publication);

        // Assert
        var publications = handler.GetMessages(TimeSpan.FromSeconds(1), 2);
        publications.Should().HaveCount(2);
    }

    /// <summary>
    /// You should ensure that given a <see cref="Topic"/>
    /// When a <see cref="Publication"/> is published on this <see cref="Topic"/>
    /// And a <see cref="ISubscription"/> is made with a <see cref="SubscriptionGroup"/> on this <see cref="Topic"/>
    /// And a <see cref="ISubscription"/> is made with a <see cref="SubscriptionGroup"/> on this <see cref="Topic"/>
    /// Then only one <see cref="ISubscription"/> receive the <see cref="Publication"/>.
    /// </summary>
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

        await connection.Subscribe(topic, handler.HandleAsync, subscriptionGroup);
        await connection.Subscribe(topic, handler.HandleAsync, subscriptionGroup);

        // Act
        await connection.Publish(publication);

        // Assert
        var publications = handler.GetMessages(TimeSpan.FromSeconds(1));
        publications.Should().HaveCount(1);

        // Ensure the buffer is really empty
        var action = handler.Invoking(h => h.GetMessages(TimeSpan.FromMilliseconds(500)));
        action.Should().Throw<TimeoutException>();
    }

    /// <summary>
    /// You should ensure that given a <see cref="Topic"/>
    /// When a <see cref="Publication"/> is published on this <see cref="Topic"/>
    /// And a <see cref="ISubscription"/> is made with a <see cref="SubscriptionGroup"/> on this <see cref="Topic"/>
    /// And a <see cref="ISubscription"/> is made with another <see cref="SubscriptionGroup"/> on this <see cref="Topic"/>
    /// Then all <see cref="ISubscription"/> receive the <see cref="Publication"/>.
    /// </summary>
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

        await connection.Subscribe(topic, handler.HandleAsync, firstSubscriptionGroup);
        await connection.Subscribe(topic, handler.HandleAsync, secondSubscriptionGroup);

        // Act
        await connection.Publish(publication);

        // Assert
        var publications = handler.GetMessages(TimeSpan.FromSeconds(1), 2);
        publications.Should().HaveCount(2);
    }
}
