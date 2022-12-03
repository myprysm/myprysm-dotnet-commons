#### [Myprysm.PubSub.Abstractions](index.md 'index')
### [Myprysm.PubSub.Abstractions](index.md#Myprysm.PubSub.Abstractions 'Myprysm.PubSub.Abstractions')

## IBrokerConnection Interface

Represents a broker connection that can be used to send [Publication](Myprysm.PubSub.Abstractions.Publication.md 'Myprysm.PubSub.Abstractions.Publication') and subscribe to [Topic](Myprysm.PubSub.Abstractions.Topic.md 'Myprysm.PubSub.Abstractions.Topic').

```csharp
public interface IBrokerConnection :
System.IDisposable
```

Implements [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')
### Properties

<a name='Myprysm.PubSub.Abstractions.IBrokerConnection.Capabilities'></a>

## IBrokerConnection.Capabilities Property

Gets the capabilities supported by the underlying [IBrokerConnection](Myprysm.PubSub.Abstractions.IBrokerConnection.md 'Myprysm.PubSub.Abstractions.IBrokerConnection').

```csharp
Myprysm.PubSub.Abstractions.BrokerCapabilities Capabilities { get; }
```

#### Property Value
[BrokerCapabilities](Myprysm.PubSub.Abstractions.BrokerCapabilities.md 'Myprysm.PubSub.Abstractions.BrokerCapabilities')
### Methods

<a name='Myprysm.PubSub.Abstractions.IBrokerConnection.Publish(Myprysm.PubSub.Abstractions.Publication,System.Threading.CancellationToken)'></a>

## IBrokerConnection.Publish(Publication, CancellationToken) Method

Publish a [Publication](Myprysm.PubSub.Abstractions.Publication.md 'Myprysm.PubSub.Abstractions.Publication').

```csharp
System.Threading.Tasks.Task Publish(Myprysm.PubSub.Abstractions.Publication publication, System.Threading.CancellationToken cancellation=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='Myprysm.PubSub.Abstractions.IBrokerConnection.Publish(Myprysm.PubSub.Abstractions.Publication,System.Threading.CancellationToken).publication'></a>

`publication` [Publication](Myprysm.PubSub.Abstractions.Publication.md 'Myprysm.PubSub.Abstractions.Publication')

The publication to publish.

<a name='Myprysm.PubSub.Abstractions.IBrokerConnection.Publish(Myprysm.PubSub.Abstractions.Publication,System.Threading.CancellationToken).cancellation'></a>

`cancellation` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

The cancellation token.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')

<a name='Myprysm.PubSub.Abstractions.IBrokerConnection.Subscribe(Myprysm.PubSub.Abstractions.Topic,Myprysm.PubSub.Abstractions.PublicationHandler,Myprysm.PubSub.Abstractions.SubscriptionGroup,Myprysm.PubSub.Abstractions.SubscriptionExceptionHandler,System.Threading.CancellationToken)'></a>

## IBrokerConnection.Subscribe(Topic, PublicationHandler, SubscriptionGroup, SubscriptionExceptionHandler, CancellationToken) Method

Subscribe to a given [Topic](Myprysm.PubSub.Abstractions.Topic.md 'Myprysm.PubSub.Abstractions.Topic')  
within an optional [SubscriptionGroup](Myprysm.PubSub.Abstractions.SubscriptionGroup.md 'Myprysm.PubSub.Abstractions.SubscriptionGroup')  
and with an optional dedicated [SubscriptionExceptionHandler(Exception)](Myprysm.PubSub.Abstractions.SubscriptionExceptionHandler(System.Exception).md 'Myprysm.PubSub.Abstractions.SubscriptionExceptionHandler(System.Exception)').

```csharp
System.Threading.Tasks.Task<Myprysm.PubSub.Abstractions.ISubscription> Subscribe(Myprysm.PubSub.Abstractions.Topic topic, Myprysm.PubSub.Abstractions.PublicationHandler handler, Myprysm.PubSub.Abstractions.SubscriptionGroup? group=null, Myprysm.PubSub.Abstractions.SubscriptionExceptionHandler? exceptionHandler=null, System.Threading.CancellationToken cancellation=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='Myprysm.PubSub.Abstractions.IBrokerConnection.Subscribe(Myprysm.PubSub.Abstractions.Topic,Myprysm.PubSub.Abstractions.PublicationHandler,Myprysm.PubSub.Abstractions.SubscriptionGroup,Myprysm.PubSub.Abstractions.SubscriptionExceptionHandler,System.Threading.CancellationToken).topic'></a>

`topic` [Topic](Myprysm.PubSub.Abstractions.Topic.md 'Myprysm.PubSub.Abstractions.Topic')

<a name='Myprysm.PubSub.Abstractions.IBrokerConnection.Subscribe(Myprysm.PubSub.Abstractions.Topic,Myprysm.PubSub.Abstractions.PublicationHandler,Myprysm.PubSub.Abstractions.SubscriptionGroup,Myprysm.PubSub.Abstractions.SubscriptionExceptionHandler,System.Threading.CancellationToken).handler'></a>

`handler` [PublicationHandler(Publication)](Myprysm.PubSub.Abstractions.PublicationHandler(Myprysm.PubSub.Abstractions.Publication).md 'Myprysm.PubSub.Abstractions.PublicationHandler(Myprysm.PubSub.Abstractions.Publication)')

<a name='Myprysm.PubSub.Abstractions.IBrokerConnection.Subscribe(Myprysm.PubSub.Abstractions.Topic,Myprysm.PubSub.Abstractions.PublicationHandler,Myprysm.PubSub.Abstractions.SubscriptionGroup,Myprysm.PubSub.Abstractions.SubscriptionExceptionHandler,System.Threading.CancellationToken).group'></a>

`group` [SubscriptionGroup](Myprysm.PubSub.Abstractions.SubscriptionGroup.md 'Myprysm.PubSub.Abstractions.SubscriptionGroup')

<a name='Myprysm.PubSub.Abstractions.IBrokerConnection.Subscribe(Myprysm.PubSub.Abstractions.Topic,Myprysm.PubSub.Abstractions.PublicationHandler,Myprysm.PubSub.Abstractions.SubscriptionGroup,Myprysm.PubSub.Abstractions.SubscriptionExceptionHandler,System.Threading.CancellationToken).exceptionHandler'></a>

`exceptionHandler` [SubscriptionExceptionHandler(Exception)](Myprysm.PubSub.Abstractions.SubscriptionExceptionHandler(System.Exception).md 'Myprysm.PubSub.Abstractions.SubscriptionExceptionHandler(System.Exception)')

<a name='Myprysm.PubSub.Abstractions.IBrokerConnection.Subscribe(Myprysm.PubSub.Abstractions.Topic,Myprysm.PubSub.Abstractions.PublicationHandler,Myprysm.PubSub.Abstractions.SubscriptionGroup,Myprysm.PubSub.Abstractions.SubscriptionExceptionHandler,System.Threading.CancellationToken).cancellation'></a>

`cancellation` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[ISubscription](Myprysm.PubSub.Abstractions.ISubscription.md 'Myprysm.PubSub.Abstractions.ISubscription')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')

### Remarks