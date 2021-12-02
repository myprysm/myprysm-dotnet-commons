# Myprysm Pub/Sub Abstractions

Myprysm publish/subscribe abstractions.

This abstraction represents a broker connection that allows sending publications to topics and subscriptions on those topics.

This abstraction allows a simple management of subscription groups/competing consumers 
and volatile/transient and persistent publications.



## Dependency Injection and Tracing

As per the asynchronous and implementation specific nature of the subscriptions 
it is not possible for this abstraction to provide decorators to support tracing.

The abstraction provide a simple `SerializedTrace` that can be used by the implementations to propagate the tracing context. 

## Implementations

The implementations should indicate the supported capabilities. 
It should also take care of propagating any current trace when no trace is provided in the `Publication`. 

## Testing

You can use the [compatibility test suite](../Myprysm.PubSub.Abstractions.Testing/README.md)
to validate your implementation.

## Documentation

The API documentation is available [here](documentation/index.md).
