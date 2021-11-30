# Myprysm Testing NUnit

Myprysm testing utilities for NUnit with AutoFixture and dependency injection.

Use this library if you want a quick setup to run integration tests.

## Categories

This project provides you with two base categories: `Integration` and `Unit`.
You can use those categories to run either one at once and speed up your tests.

# Tracing

This library provides a collector decorator for an `ITracer` provided by the `Myprysm.Tracing.Abstractions`.
You can use this `CollectorTracer` if you  want to verify that your traces are collected appropriately.
For more details check the [API Documentation](documentation/index.md).

## AutoFixture

This library provides a base `FixtureTests` class that you can extend if you need any [AutoFixture]()
For more details check the [API Documentation](documentation/index.md).

## Dependency Injection

This library provides dependency injection support for testing. 
See [ServiceTests](documentation/Myprysm_Testing_NUnit_ServiceTests.md) for more details.
For more details check the [API Documentation](documentation/index.md).

## File resources in tests

You can make use of either `TypeExtensions` or `StringExtensions` extensions if you need to load any file resource. 
This will provide you with a project/type aware location that you can use safely in tests.

A few examples could look like `typeof(YourType).GetResourceStream(YourResourceInTheSameNamespace);`
or `"/your/absolute/path".GetResourceAsStream()`.

> Don't forget to include the appropriate resources in the `csproj`
> if you intend to include embedded resources or assimilated.

## Documentation

The API documentation is available [here](documentation/index.md).
