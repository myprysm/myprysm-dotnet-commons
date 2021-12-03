#### [Myprysm.PubSub.Abstractions](index.md 'index')
### Namespaces
<a name='Myprysm_PubSub_Abstractions'></a>
## Myprysm.PubSub.Abstractions Namespace

| Classes | |
| :--- | :--- |
| [BrokerCapabilities](Myprysm_PubSub_Abstractions_BrokerCapabilities.md 'Myprysm.PubSub.Abstractions.BrokerCapabilities') | Capabilities provided by a broker.<br/> |
| [BrokerHealthCheck](Myprysm_PubSub_Abstractions_BrokerHealthCheck.md 'Myprysm.PubSub.Abstractions.BrokerHealthCheck') | Broker [Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck 'Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck') to ensure a [IBrokerConnection](Myprysm_PubSub_Abstractions_IBrokerConnection.md 'Myprysm.PubSub.Abstractions.IBrokerConnection') instance can work appropriately.<br/> |
| [Publication](Myprysm_PubSub_Abstractions_Publication.md 'Myprysm.PubSub.Abstractions.Publication') | Represents a publication to send to any unknown [ISubscription](Myprysm_PubSub_Abstractions_ISubscription.md 'Myprysm.PubSub.Abstractions.ISubscription') handled by an [IBrokerConnection](Myprysm_PubSub_Abstractions_IBrokerConnection.md 'Myprysm.PubSub.Abstractions.IBrokerConnection').<br/> |
| [PublicationCollectorHandler](Myprysm_PubSub_Abstractions_PublicationCollectorHandler.md 'Myprysm.PubSub.Abstractions.PublicationCollectorHandler') | A publication handler that collects the incoming publications. <br/> |
| [PubSubOptions](Myprysm_PubSub_Abstractions_PubSubOptions.md 'Myprysm.PubSub.Abstractions.PubSubOptions') | Base pub sub options.<br/><br/>You should extend those options and use the dependency injection extensions if you want to enable tracing<br/> |
| [SerializedTrace](Myprysm_PubSub_Abstractions_SerializedTrace.md 'Myprysm.PubSub.Abstractions.SerializedTrace') | Represents a trace that has been serialized and transmitted from an original publication.<br/> |
| [SubscriptionGroup](Myprysm_PubSub_Abstractions_SubscriptionGroup.md 'Myprysm.PubSub.Abstractions.SubscriptionGroup') | Represents a subscription group that can be use to load balance publication across subscriptions within the group.<br/>Also known as competing consumer pattern. <br/> |
| [Topic](Myprysm_PubSub_Abstractions_Topic.md 'Myprysm.PubSub.Abstractions.Topic') | Represents a topic to send a [Publication](Myprysm_PubSub_Abstractions_Publication.md 'Myprysm.PubSub.Abstractions.Publication').<br/> |

| Interfaces | |
| :--- | :--- |
| [IBrokerConnection](Myprysm_PubSub_Abstractions_IBrokerConnection.md 'Myprysm.PubSub.Abstractions.IBrokerConnection') | Represents a broker connection that can be used to send [Publication](Myprysm_PubSub_Abstractions_Publication.md 'Myprysm.PubSub.Abstractions.Publication') and subscribe to [Topic](Myprysm_PubSub_Abstractions_Topic.md 'Myprysm.PubSub.Abstractions.Topic').<br/> |
| [ISubscription](Myprysm_PubSub_Abstractions_ISubscription.md 'Myprysm.PubSub.Abstractions.ISubscription') | Represents a live subscription, listening to [Publication](Myprysm_PubSub_Abstractions_Publication.md 'Myprysm.PubSub.Abstractions.Publication').<br/> |

| Enums | |
| :--- | :--- |
| [Transport](Myprysm_PubSub_Abstractions_Transport.md 'Myprysm.PubSub.Abstractions.Transport') | The kind of transport supported by a broker.<br/> |

| Delegates | |
| :--- | :--- |
| [PublicationHandler(Publication)](Myprysm_PubSub_Abstractions_PublicationHandler(Myprysm_PubSub_Abstractions_Publication).md 'Myprysm.PubSub.Abstractions.PublicationHandler(Myprysm.PubSub.Abstractions.Publication)') |  |
| [SubscriptionExceptionHandler(Exception)](Myprysm_PubSub_Abstractions_SubscriptionExceptionHandler(System_Exception).md 'Myprysm.PubSub.Abstractions.SubscriptionExceptionHandler(System.Exception)') | Delegate invoked when an exception is thrown when processing a [Publication](Myprysm_PubSub_Abstractions_Publication.md 'Myprysm.PubSub.Abstractions.Publication') in an [ISubscription](Myprysm_PubSub_Abstractions_ISubscription.md 'Myprysm.PubSub.Abstractions.ISubscription').<br/> |
  
<a name='Myprysm_PubSub_Abstractions_Exceptions'></a>
## Myprysm.PubSub.Abstractions.Exceptions Namespace

| Classes | |
| :--- | :--- |
| [SubscriptionHandlerException](Myprysm_PubSub_Abstractions_Exceptions_SubscriptionHandlerException.md 'Myprysm.PubSub.Abstractions.Exceptions.SubscriptionHandlerException') | Exception thrown when a [PublicationHandler(Publication)](Myprysm_PubSub_Abstractions_PublicationHandler(Myprysm_PubSub_Abstractions_Publication).md 'Myprysm.PubSub.Abstractions.PublicationHandler(Myprysm.PubSub.Abstractions.Publication)') throws an unmanaged exception.<br/> |
  
