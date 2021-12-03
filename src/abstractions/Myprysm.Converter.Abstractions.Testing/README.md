# Myprysm Converter Abstractions Testing

Myprysm conversion/serde abstractions compatibility test suite.

This projects hosts the base test suite
that you can extend to ensure that your `IConverter` implementation is compatible.

> This test suite uses [NUnit](https://nunit.org/)

## Implementations

You should extend the `ConverterTests` suite and provide your `IConverter` implementation
with the `ConfigureServices` method.

You should also provide invalid data as per your converter implementation as a `byte[]`
so that we can ensure that the right exceptions are thrown.

Here is an example implementation for a json converter

```c#
[TestFixture]
public class YourJsonConverterTests : ConverterTests
{
    protected override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddYourJsonConverter(_ => { });
    }

    protected override byte[] GetInvalidData()
    {
        return Encoding.UTF8.GetBytes("I am invalid json");
    }
}
```

## Documentation

The API documentation is available [here](documentation/index.md).
