# Myprysm NATS PubSub

Implementation of an [IBrokerConnection](../../abstractions/Myprysm.PubSub.Abstractions/README.md)
with [NATS](https://nats.io/).

It does not support (yet?) persistent publications. It supports subscription groups/competing consumers.

## Configuration and usage

You can load the latest version of this broker connection from [Myprysm Nuget repository](https://baget.myprysm.fr/packages/myprysm.pubsub.nats).

You can inject the `IBrokerConnection` in your application by using the `DependencyInjectionExtensions`.

You should provide the appropriate options to connect to the remote NATS instance.

You should provide your own `IConverter` implementation for publication serialization/deserialization over the wire.

## Documentation

The API documentation is available [here](documentation/index.md).
