#### [Myprysm.PubSub.Abstractions](index.md 'index')
### [Myprysm.PubSub.Abstractions](index.md#Myprysm.PubSub.Abstractions 'Myprysm.PubSub.Abstractions')

## Transport Enum

The kind of transport supported by a broker.

```csharp
public enum Transport
```
### Fields

<a name='Myprysm.PubSub.Abstractions.Transport.Both'></a>

`Both` 2

Supports both [Transient](Myprysm.PubSub.Abstractions.Transport.md#Myprysm.PubSub.Abstractions.Transport.Transient 'Myprysm.PubSub.Abstractions.Transport.Transient') and [Persistent](Myprysm.PubSub.Abstractions.Transport.md#Myprysm.PubSub.Abstractions.Transport.Persistent 'Myprysm.PubSub.Abstractions.Transport.Persistent') transports.

<a name='Myprysm.PubSub.Abstractions.Transport.Persistent'></a>

`Persistent` 1

Messages are persisted until a subscription is made to a topic.

<a name='Myprysm.PubSub.Abstractions.Transport.Transient'></a>

`Transient` 0

Messages can be lost when there is no subscription bound to a topic.