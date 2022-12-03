#### [Myprysm.PubSub.Abstractions](index.md 'index')

## Myprysm.PubSub.Abstractions Assembly
### Namespaces

<a name='Myprysm.PubSub.Abstractions'></a>

## Myprysm.PubSub.Abstractions Namespace

| Classes | |
| :--- | :--- |
| [BrokerCapabilities](Myprysm.PubSub.Abstractions.BrokerCapabilities.md 'Myprysm.PubSub.Abstractions.BrokerCapabilities') | Capabilities provided by a broker. |
| [BrokerHealthCheck](Myprysm.PubSub.Abstractions.BrokerHealthCheck.md 'Myprysm.PubSub.Abstractions.BrokerHealthCheck') | Broker [Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck 'Microsoft.Extensions.Diagnostics.HealthChecks.IHealthCheck') to ensure a [IBrokerConnection](Myprysm.PubSub.Abstractions.IBrokerConnection.md 'Myprysm.PubSub.Abstractions.IBrokerConnection') instance can work appropriately. |
| [Publication](Myprysm.PubSub.Abstractions.Publication.md 'Myprysm.PubSub.Abstractions.Publication') | Represents a publication to send to any unknown [ISubscription](Myprysm.PubSub.Abstractions.ISubscription.md 'Myprysm.PubSub.Abstractions.ISubscription') handled by an [IBrokerConnection](Myprysm.PubSub.Abstractions.IBrokerConnection.md 'Myprysm.PubSub.Abstractions.IBrokerConnection'). |
| [PublicationCollectorHandler](Myprysm.PubSub.Abstractions.PublicationCollectorHandler.md 'Myprysm.PubSub.Abstractions.PublicationCollectorHandler') | A publication handler that collects the incoming publications. |
| [PubSubOptions](Myprysm.PubSub.Abstractions.PubSubOptions.md 'Myprysm.PubSub.Abstractions.PubSubOptions') | Base pub sub options.<br/><br/>You should extend those options and use the dependency injection extensions if you want to enable tracing |
| [SerializedTrace](Myprysm.PubSub.Abstractions.SerializedTrace.md 'Myprysm.PubSub.Abstractions.SerializedTrace') | Represents a trace that has been serialized and transmitted from an original publication. |
| [SubscriptionGroup](Myprysm.PubSub.Abstractions.SubscriptionGroup.md 'Myprysm.PubSub.Abstractions.SubscriptionGroup') | Represents a subscription group that can be use to load balance publication across subscriptions within the group.<br/>Also known as competing consumer pattern. |
| [Topic](Myprysm.PubSub.Abstractions.Topic.md 'Myprysm.PubSub.Abstractions.Topic') | Represents a topic to send a [Publication](Myprysm.PubSub.Abstractions.Publication.md 'Myprysm.PubSub.Abstractions.Publication'). |

| Interfaces | |
| :--- | :--- |
| [IBrokerConnection](Myprysm.PubSub.Abstractions.IBrokerConnection.md 'Myprysm.PubSub.Abstractions.IBrokerConnection') | Represents a broker connection that can be used to send [Publication](Myprysm.PubSub.Abstractions.Publication.md 'Myprysm.PubSub.Abstractions.Publication') and subscribe to [Topic](Myprysm.PubSub.Abstractions.Topic.md 'Myprysm.PubSub.Abstractions.Topic'). |
| [ISubscription](Myprysm.PubSub.Abstractions.ISubscription.md 'Myprysm.PubSub.Abstractions.ISubscription') | Represents a live subscription, listening to [Publication](Myprysm.PubSub.Abstractions.Publication.md 'Myprysm.PubSub.Abstractions.Publication'). |

| Enums | |
| :--- | :--- |
| [Transport](Myprysm.PubSub.Abstractions.Transport.md 'Myprysm.PubSub.Abstractions.Transport') | The kind of transport supported by a broker. |

| Delegates | |
| :--- | :--- |
| [PublicationHandler(Publication)](Myprysm.PubSub.Abstractions.PublicationHandler(Myprysm.PubSub.Abstractions.Publication).md 'Myprysm.PubSub.Abstractions.PublicationHandler(Myprysm.PubSub.Abstractions.Publication)') | |
| [SubscriptionExceptionHandler(Exception)](Myprysm.PubSub.Abstractions.SubscriptionExceptionHandler(System.Exception).md 'Myprysm.PubSub.Abstractions.SubscriptionExceptionHandler(System.Exception)') | Delegate invoked when an exception is thrown when processing a [Publication](Myprysm.PubSub.Abstractions.Publication.md 'Myprysm.PubSub.Abstractions.Publication') in an [ISubscription](Myprysm.PubSub.Abstractions.ISubscription.md 'Myprysm.PubSub.Abstractions.ISubscription'). |

<a name='Myprysm.PubSub.Abstractions.Exceptions'></a>

## Myprysm.PubSub.Abstractions.Exceptions Namespace

| Classes | |
| :--- | :--- |
| [SubscriptionHandlerException](Myprysm.PubSub.Abstractions.Exceptions.SubscriptionHandlerException.md 'Myprysm.PubSub.Abstractions.Exceptions.SubscriptionHandlerException') | Exception thrown when a [PublicationHandler(Publication)](Myprysm.PubSub.Abstractions.PublicationHandler(Myprysm.PubSub.Abstractions.Publication).md 'Myprysm.PubSub.Abstractions.PublicationHandler(Myprysm.PubSub.Abstractions.Publication)') throws an unmanaged exception. |
