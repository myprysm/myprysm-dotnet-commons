# Myprysm FileService Abstractions Testing

Myprysm file service abstractions compatibility test suite.

This projects hosts the base test suite
that you can extend to ensure that your `IFileService` implementation is compatible.

> This test suite uses [NUnit](https://nunit.org/)

## Implementations

You should extend the `FileServiceTests` suite and provide your `IFileService` implementation
with the `ConfigureServices` method.

Here is an example implementation for a file service

```c#
[TestFixture]
public class YourFileServiceTests : FileServiceTests
{
    protected override void Configure(ConfigurationBuilder configuration)
    {
        var config = new Dictionary<string, string>
        {
            [nameof(YourFileServiceOptions.SomeValue)] = "something",
        };

        configuration.AddInMemoryCollection(config);
    }
    
    protected override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddYourFileService(configuration);
    }
}
```

## Documentation

The API documentation is available [here](documentation/index.md).
