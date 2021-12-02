# Myprysm Pub/Sub Abstractions Testing

Myprysm publish/subscribe abstractions compatibility test suite.

This projects hosts the base test suite
that you can extend to ensure that your `IBrokerConnection` implementation is compatible.

> This test suite uses [NUnit](https://nunit.org/)

## Implementations

You should extend the appropriate test suites for the supported capabilities of your `IBrokerConnection` and provide your implementation
with the `ConfigureServices` method.

You should also implement a method that sends a null message to a given topic.

The test suites available depending on the capabilities:

* `PersistentBrokerConnectionTests`
* `SubscriptionGroupBrokerConnectionTests`
* `VolatileBrokerConnectionTests`

Here is an example implementation for a persistent broker connection.

```c#
[TestFixture]
public class YourPersistentBrokerConnectionTests : PersistentBrokerConnectionTests<YourPubSubOptions>
{
    protected override void Configure(ConfigurationBuilder configuration)
    {
        var config = new Dictionary<string, string>
        {
            [nameof(YourPubSubOptions.SomeSetting)] = "A value",
        };

        configuration.AddInMemoryCollection(config);
    }

    protected override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        base.ConfigureServices(services, configuration);

        services.AddYourPubSub(configuration);
    }

    protected override Task SendNullMessage(Topic topic)
    {
        var connection = this.Services.GetRequiredService<IBrokerConnection>() as YourBrokerConnection;
        var lowLevelConnection = connection.LowLevelConnection;

        lowLevelConnection.Publish(topic.Value, null);
        return Task.CompletedTask;
    }
}
```

## Documentation

The API documentation is available [here](documentation/index.md).
