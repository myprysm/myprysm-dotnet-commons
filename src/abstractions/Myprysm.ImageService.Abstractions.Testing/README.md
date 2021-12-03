# Myprysm ImageService Abstractions Testing

Myprysm image service abstractions compatibility test suite.

This projects hosts the base test suite
that you can extend to ensure that your `IImageService` implementation is compatible.

> This test suite uses [NUnit](https://nunit.org/)

## Implementations

You should extend the `ImageServiceTests` suite and provide your `IImageService` implementation
with the `ConfigureServices` method.

Here is an example implementation for a image service

```c#
[TestFixture]
public class YourImageServiceTests : ImageServiceTests
{
    protected override void Configure(ConfigurationBuilder configuration)
    {
        var config = new Dictionary<string, string>
        {
            [nameof(YourImageServiceOptions.SomeValue)] = "something",
        };

        configuration.AddInMemoryCollection(config);
    }
    
    protected override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddYourImageService(configuration);
    }
}
```

## Documentation

The API documentation is available [here](documentation/index.md).
