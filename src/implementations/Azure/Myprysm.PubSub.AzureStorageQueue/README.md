# Myprysm NATS PubSub

Implementation of an [IBrokerConnection](../../../abstractions/Myprysm.PubSub.Abstractions/README.md)
with Azure Storage Queues.

It supports persistent publications. It cannot support subscription groups/competing consumers.

## Configuration and usage

You can load the latest version of this broker connection
from [Myprysm Nuget repository](https://baget.myprysm.fr/packages/myprysm.pubsub.azurestoragequeue).

You can inject the `IBrokerConnection` in your application by using the `DependencyInjectionExtensions`.

You should provide the appropriate options to connect to the remote Azure Storage account.

You should provide your own `IConverter` implementation for publication serialization/deserialization over the wire.

You can control globally:
* how often the subscriptions will check for new messages
* how many new messages will be processed at once
* how many times a publication processing should fail before moving to a `poison` queue

## Documentation

The API documentation is available [here](documentation/index.md).
