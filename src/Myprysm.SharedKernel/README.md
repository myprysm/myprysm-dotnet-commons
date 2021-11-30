# Myprysm Shared Kernel

Myprysm Shared Kernel with ValueObjects, ExecutionResults and ManagedExceptions.

This library provides you with a set of common utilities that are useful to any application development.

There is a set of managed exceptions so that you can be more specific about the failures happening in your system.
It includes also a set of execution results to distinguish exceptional cases from well known failures.
If record types are not enough for you and you want your own value objects or single value objects, 
it contains base implementations that you can extend to make your code more domain centric 

The execution results, value objects and a few extension methods come with very little adaptation from the awesome [EventFlow](https://github.com/eventflow/EventFlow).

## Value Objects and Single Value Objects

If you try to apply strictly DDD, 
you would like to avoid any kind of primitive types in your aggregates, entities and value objects.

`SingleValueObject<>` can help you fill this need and streamline 
how you manage those specific values that can be for example a `Password`, `Username` or `Amount`.

> You should preferably name the constructor argument `value` as it may be significant when the type is deserialized

Here is an example of a `Username`:

```c#
public class Username : SingleValueObject<string>
{
  public Username(string value) : base(value)
  {
    if (string.IsNullOrEmpty(value) || value.Length <= 4)
    {
      throw ValidationException.With(nameof(Username), $"Invalid username '{value}'");
    }
  }
}
```

## Execution results

As per event flow advice, execution results should not be used as a method of reading values from aggregates/write model.
Yet if something is generated during the processing of a command/request and you need to return it to the parent caller, 
you can use `ExecutionResult.Success(yourObject)`

## Documentation

The API documentation is available [here](documentation/index.md).
