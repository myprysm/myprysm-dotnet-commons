#### [Myprysm.PubSub.Abstractions](index.md 'index')
### [Myprysm.PubSub.Abstractions](index.md#Myprysm_PubSub_Abstractions 'Myprysm.PubSub.Abstractions')
## IBrokerConnection Interface
Represents a broker connection that can be used to send [Publication](Myprysm_PubSub_Abstractions_Publication.md 'Myprysm.PubSub.Abstractions.Publication') and subscribe to [Topic](Myprysm_PubSub_Abstractions_Topic.md 'Myprysm.PubSub.Abstractions.Topic').  
```csharp
public interface IBrokerConnection :
System.IDisposable
```

Implements [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')  
### Properties
<a name='Myprysm_PubSub_Abstractions_IBrokerConnection_Capabilities'></a>
## IBrokerConnection.Capabilities Property
Gets the capabilities supported by the underlying [IBrokerConnection](Myprysm_PubSub_Abstractions_IBrokerConnection.md 'Myprysm.PubSub.Abstractions.IBrokerConnection').  
```csharp
Myprysm.PubSub.Abstractions.BrokerCapabilities Capabilities { get; }
```
#### Property Value
[BrokerCapabilities](Myprysm_PubSub_Abstractions_BrokerCapabilities.md 'Myprysm.PubSub.Abstractions.BrokerCapabilities')
  
### Methods
<a name='Myprysm_PubSub_Abstractions_IBrokerConnection_Publish(Myprysm_PubSub_Abstractions_Publication_System_Threading_CancellationToken)'></a>
## IBrokerConnection.Publish(Publication, CancellationToken) Method
Publish a [Publication](Myprysm_PubSub_Abstractions_Publication.md 'Myprysm.PubSub.Abstractions.Publication').  
```csharp
System.Threading.Tasks.Task Publish(Myprysm.PubSub.Abstractions.Publication publication, System.Threading.CancellationToken cancellation=default(System.Threading.CancellationToken));
```
#### Parameters
<a name='Myprysm_PubSub_Abstractions_IBrokerConnection_Publish(Myprysm_PubSub_Abstractions_Publication_System_Threading_CancellationToken)_publication'></a>
`publication` [Publication](Myprysm_PubSub_Abstractions_Publication.md 'Myprysm.PubSub.Abstractions.Publication')  
The publication to publish.
  
<a name='Myprysm_PubSub_Abstractions_IBrokerConnection_Publish(Myprysm_PubSub_Abstractions_Publication_System_Threading_CancellationToken)_cancellation'></a>
`cancellation` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')  
The cancellation token.
  
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
  
<a name='Myprysm_PubSub_Abstractions_IBrokerConnection_Subscribe(Myprysm_PubSub_Abstractions_Topic_Myprysm_PubSub_Abstractions_PublicationHandler_Myprysm_PubSub_Abstractions_SubscriptionGroup__Myprysm_PubSub_Abstractions_SubscriptionExceptionHandler__System_Threading_CancellationToken)'></a>
## IBrokerConnection.Subscribe(Topic, PublicationHandler, SubscriptionGroup?, SubscriptionExceptionHandler?, CancellationToken) Method
Subscribe to a given [Topic](Myprysm_PubSub_Abstractions_Topic.md 'Myprysm.PubSub.Abstractions.Topic')  
within an optional [SubscriptionGroup](Myprysm_PubSub_Abstractions_SubscriptionGroup.md 'Myprysm.PubSub.Abstractions.SubscriptionGroup')  
and with an optional dedicated [SubscriptionExceptionHandler(Exception)](Myprysm_PubSub_Abstractions_SubscriptionExceptionHandler(System_Exception).md 'Myprysm.PubSub.Abstractions.SubscriptionExceptionHandler(System.Exception)').  
```csharp
System.Threading.Tasks.Task<Myprysm.PubSub.Abstractions.ISubscription> Subscribe(Myprysm.PubSub.Abstractions.Topic topic, Myprysm.PubSub.Abstractions.PublicationHandler handler, Myprysm.PubSub.Abstractions.SubscriptionGroup? group=null, Myprysm.PubSub.Abstractions.SubscriptionExceptionHandler? exceptionHandler=null, System.Threading.CancellationToken cancellation=default(System.Threading.CancellationToken));
```
#### Parameters
<a name='Myprysm_PubSub_Abstractions_IBrokerConnection_Subscribe(Myprysm_PubSub_Abstractions_Topic_Myprysm_PubSub_Abstractions_PublicationHandler_Myprysm_PubSub_Abstractions_SubscriptionGroup__Myprysm_PubSub_Abstractions_SubscriptionExceptionHandler__System_Threading_CancellationToken)_topic'></a>
`topic` [Topic](Myprysm_PubSub_Abstractions_Topic.md 'Myprysm.PubSub.Abstractions.Topic')  
  
<a name='Myprysm_PubSub_Abstractions_IBrokerConnection_Subscribe(Myprysm_PubSub_Abstractions_Topic_Myprysm_PubSub_Abstractions_PublicationHandler_Myprysm_PubSub_Abstractions_SubscriptionGroup__Myprysm_PubSub_Abstractions_SubscriptionExceptionHandler__System_Threading_CancellationToken)_handler'></a>
`handler` [PublicationHandler(Publication)](Myprysm_PubSub_Abstractions_PublicationHandler(Myprysm_PubSub_Abstractions_Publication).md 'Myprysm.PubSub.Abstractions.PublicationHandler(Myprysm.PubSub.Abstractions.Publication)')  
  
<a name='Myprysm_PubSub_Abstractions_IBrokerConnection_Subscribe(Myprysm_PubSub_Abstractions_Topic_Myprysm_PubSub_Abstractions_PublicationHandler_Myprysm_PubSub_Abstractions_SubscriptionGroup__Myprysm_PubSub_Abstractions_SubscriptionExceptionHandler__System_Threading_CancellationToken)_group'></a>
`group` [SubscriptionGroup](Myprysm_PubSub_Abstractions_SubscriptionGroup.md 'Myprysm.PubSub.Abstractions.SubscriptionGroup')  
  
<a name='Myprysm_PubSub_Abstractions_IBrokerConnection_Subscribe(Myprysm_PubSub_Abstractions_Topic_Myprysm_PubSub_Abstractions_PublicationHandler_Myprysm_PubSub_Abstractions_SubscriptionGroup__Myprysm_PubSub_Abstractions_SubscriptionExceptionHandler__System_Threading_CancellationToken)_exceptionHandler'></a>
`exceptionHandler` [SubscriptionExceptionHandler(Exception)](Myprysm_PubSub_Abstractions_SubscriptionExceptionHandler(System_Exception).md 'Myprysm.PubSub.Abstractions.SubscriptionExceptionHandler(System.Exception)')  
  
<a name='Myprysm_PubSub_Abstractions_IBrokerConnection_Subscribe(Myprysm_PubSub_Abstractions_Topic_Myprysm_PubSub_Abstractions_PublicationHandler_Myprysm_PubSub_Abstractions_SubscriptionGroup__Myprysm_PubSub_Abstractions_SubscriptionExceptionHandler__System_Threading_CancellationToken)_cancellation'></a>
`cancellation` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')  
  
#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[ISubscription](Myprysm_PubSub_Abstractions_ISubscription.md 'Myprysm.PubSub.Abstractions.ISubscription')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
### Remarks
  
