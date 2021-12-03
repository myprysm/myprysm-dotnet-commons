#### [Myprysm.PubSub.Nats](index.md 'index')
### [Myprysm.PubSub.Nats](index.md#Myprysm_PubSub_Nats 'Myprysm.PubSub.Nats')
## NatsBrokerConnection Class
[Myprysm.PubSub.Abstractions.IBrokerConnection](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.IBrokerConnection 'Myprysm.PubSub.Abstractions.IBrokerConnection') with [NATS](https://nats.io/ 'https://nats.io/') for a volatile but crazy quick PubSub.   
            
```csharp
public class NatsBrokerConnection :
Myprysm.PubSub.Abstractions.IBrokerConnection,
System.IDisposable
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; NatsBrokerConnection  

Implements [Myprysm.PubSub.Abstractions.IBrokerConnection](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.IBrokerConnection 'Myprysm.PubSub.Abstractions.IBrokerConnection'), [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')  
### Constructors
<a name='Myprysm_PubSub_Nats_NatsBrokerConnection_NatsBrokerConnection(Myprysm_Converter_Abstractions_IConverter_Myprysm_Tracing_Abstractions_ITracerFactory_Microsoft_Extensions_Options_IOptions_Myprysm_PubSub_Nats_NatsPubSubOptions__Microsoft_Extensions_Logging_ILogger_Myprysm_PubSub_Nats_NatsBrokerConnection__Microsoft_Extensions_Logging_ILogger_Myprysm_PubSub_Nats_NatsSubscription_)'></a>
## NatsBrokerConnection.NatsBrokerConnection(IConverter, ITracerFactory, IOptions&lt;NatsPubSubOptions&gt;, ILogger&lt;NatsBrokerConnection&gt;, ILogger&lt;NatsSubscription&gt;) Constructor
Creates a new [NatsBrokerConnection](Myprysm_PubSub_Nats_NatsBrokerConnection.md 'Myprysm.PubSub.Nats.NatsBrokerConnection') with the given dependencies.  
```csharp
public NatsBrokerConnection(Myprysm.Converter.Abstractions.IConverter converter, Myprysm.Tracing.Abstractions.ITracerFactory tracerFactory, Microsoft.Extensions.Options.IOptions<Myprysm.PubSub.Nats.NatsPubSubOptions> options, Microsoft.Extensions.Logging.ILogger<Myprysm.PubSub.Nats.NatsBrokerConnection> logger, Microsoft.Extensions.Logging.ILogger<Myprysm.PubSub.Nats.NatsSubscription> subscriptionLogger);
```
#### Parameters
<a name='Myprysm_PubSub_Nats_NatsBrokerConnection_NatsBrokerConnection(Myprysm_Converter_Abstractions_IConverter_Myprysm_Tracing_Abstractions_ITracerFactory_Microsoft_Extensions_Options_IOptions_Myprysm_PubSub_Nats_NatsPubSubOptions__Microsoft_Extensions_Logging_ILogger_Myprysm_PubSub_Nats_NatsBrokerConnection__Microsoft_Extensions_Logging_ILogger_Myprysm_PubSub_Nats_NatsSubscription_)_converter'></a>
`converter` [Myprysm.Converter.Abstractions.IConverter](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Converter.Abstractions.IConverter 'Myprysm.Converter.Abstractions.IConverter')  
The converter used to send the publications over the wire.
  
<a name='Myprysm_PubSub_Nats_NatsBrokerConnection_NatsBrokerConnection(Myprysm_Converter_Abstractions_IConverter_Myprysm_Tracing_Abstractions_ITracerFactory_Microsoft_Extensions_Options_IOptions_Myprysm_PubSub_Nats_NatsPubSubOptions__Microsoft_Extensions_Logging_ILogger_Myprysm_PubSub_Nats_NatsBrokerConnection__Microsoft_Extensions_Logging_ILogger_Myprysm_PubSub_Nats_NatsSubscription_)_tracerFactory'></a>
`tracerFactory` [Myprysm.Tracing.Abstractions.ITracerFactory](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITracerFactory 'Myprysm.Tracing.Abstractions.ITracerFactory')  
The tracer factory to trace the publications.
  
<a name='Myprysm_PubSub_Nats_NatsBrokerConnection_NatsBrokerConnection(Myprysm_Converter_Abstractions_IConverter_Myprysm_Tracing_Abstractions_ITracerFactory_Microsoft_Extensions_Options_IOptions_Myprysm_PubSub_Nats_NatsPubSubOptions__Microsoft_Extensions_Logging_ILogger_Myprysm_PubSub_Nats_NatsBrokerConnection__Microsoft_Extensions_Logging_ILogger_Myprysm_PubSub_Nats_NatsSubscription_)_options'></a>
`options` [Microsoft.Extensions.Options.IOptions&lt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Options.IOptions-1 'Microsoft.Extensions.Options.IOptions`1')[NatsPubSubOptions](Myprysm_PubSub_Nats_NatsPubSubOptions.md 'Myprysm.PubSub.Nats.NatsPubSubOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Options.IOptions-1 'Microsoft.Extensions.Options.IOptions`1')  
The options.
  
<a name='Myprysm_PubSub_Nats_NatsBrokerConnection_NatsBrokerConnection(Myprysm_Converter_Abstractions_IConverter_Myprysm_Tracing_Abstractions_ITracerFactory_Microsoft_Extensions_Options_IOptions_Myprysm_PubSub_Nats_NatsPubSubOptions__Microsoft_Extensions_Logging_ILogger_Myprysm_PubSub_Nats_NatsBrokerConnection__Microsoft_Extensions_Logging_ILogger_Myprysm_PubSub_Nats_NatsSubscription_)_logger'></a>
`logger` [Microsoft.Extensions.Logging.ILogger&lt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.ILogger-1 'Microsoft.Extensions.Logging.ILogger`1')[NatsBrokerConnection](Myprysm_PubSub_Nats_NatsBrokerConnection.md 'Myprysm.PubSub.Nats.NatsBrokerConnection')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.ILogger-1 'Microsoft.Extensions.Logging.ILogger`1')  
The logger.
  
<a name='Myprysm_PubSub_Nats_NatsBrokerConnection_NatsBrokerConnection(Myprysm_Converter_Abstractions_IConverter_Myprysm_Tracing_Abstractions_ITracerFactory_Microsoft_Extensions_Options_IOptions_Myprysm_PubSub_Nats_NatsPubSubOptions__Microsoft_Extensions_Logging_ILogger_Myprysm_PubSub_Nats_NatsBrokerConnection__Microsoft_Extensions_Logging_ILogger_Myprysm_PubSub_Nats_NatsSubscription_)_subscriptionLogger'></a>
`subscriptionLogger` [Microsoft.Extensions.Logging.ILogger&lt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.ILogger-1 'Microsoft.Extensions.Logging.ILogger`1')[NatsSubscription](Myprysm_PubSub_Nats_NatsSubscription.md 'Myprysm.PubSub.Nats.NatsSubscription')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.ILogger-1 'Microsoft.Extensions.Logging.ILogger`1')  
The logger for subscriptions.
  
  
### Properties
<a name='Myprysm_PubSub_Nats_NatsBrokerConnection_Capabilities'></a>
## NatsBrokerConnection.Capabilities Property
Gets the capabilities supported by the underlying [Myprysm.PubSub.Abstractions.IBrokerConnection](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.IBrokerConnection 'Myprysm.PubSub.Abstractions.IBrokerConnection').  
```csharp
public Myprysm.PubSub.Abstractions.BrokerCapabilities Capabilities { get; }
```
#### Property Value
[Myprysm.PubSub.Abstractions.BrokerCapabilities](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.BrokerCapabilities 'Myprysm.PubSub.Abstractions.BrokerCapabilities')

Implements [Capabilities](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.IBrokerConnection.Capabilities 'Myprysm.PubSub.Abstractions.IBrokerConnection.Capabilities')  
  
### Methods
<a name='Myprysm_PubSub_Nats_NatsBrokerConnection_Dispose()'></a>
## NatsBrokerConnection.Dispose() Method
Disposes managed resources of [NatsSubscription](Myprysm_PubSub_Nats_NatsSubscription.md 'Myprysm.PubSub.Nats.NatsSubscription').  
```csharp
public void Dispose();
```

Implements [Dispose()](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable.Dispose 'System.IDisposable.Dispose')  
  
<a name='Myprysm_PubSub_Nats_NatsBrokerConnection_Publish(Myprysm_PubSub_Abstractions_Publication_System_Threading_CancellationToken)'></a>
## NatsBrokerConnection.Publish(Publication, CancellationToken) Method
Publish a [Myprysm.PubSub.Abstractions.Publication](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Publication 'Myprysm.PubSub.Abstractions.Publication').  
```csharp
public System.Threading.Tasks.Task Publish(Myprysm.PubSub.Abstractions.Publication publication, System.Threading.CancellationToken cancellation=default(System.Threading.CancellationToken));
```
#### Parameters
<a name='Myprysm_PubSub_Nats_NatsBrokerConnection_Publish(Myprysm_PubSub_Abstractions_Publication_System_Threading_CancellationToken)_publication'></a>
`publication` [Myprysm.PubSub.Abstractions.Publication](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Publication 'Myprysm.PubSub.Abstractions.Publication')  
The publication to publish.
  
<a name='Myprysm_PubSub_Nats_NatsBrokerConnection_Publish(Myprysm_PubSub_Abstractions_Publication_System_Threading_CancellationToken)_cancellation'></a>
`cancellation` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')  
The cancellation token.
  
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  

Implements [Publish(Publication, CancellationToken)](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.IBrokerConnection.Publish#Myprysm_PubSub_Abstractions_IBrokerConnection_Publish_Myprysm_PubSub_Abstractions_Publication,System_Threading_CancellationToken_ 'Myprysm.PubSub.Abstractions.IBrokerConnection.Publish(Myprysm.PubSub.Abstractions.Publication,System.Threading.CancellationToken)')  
  
<a name='Myprysm_PubSub_Nats_NatsBrokerConnection_Subscribe(Myprysm_PubSub_Abstractions_Topic_Myprysm_PubSub_Abstractions_PublicationHandler_Myprysm_PubSub_Abstractions_SubscriptionGroup__Myprysm_PubSub_Abstractions_SubscriptionExceptionHandler__System_Threading_CancellationToken)'></a>
## NatsBrokerConnection.Subscribe(Topic, PublicationHandler, SubscriptionGroup?, SubscriptionExceptionHandler?, CancellationToken) Method
Subscribe to a given [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic')  
within an optional [Myprysm.PubSub.Abstractions.SubscriptionGroup](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.SubscriptionGroup 'Myprysm.PubSub.Abstractions.SubscriptionGroup')  
and with an optional dedicated [Myprysm.PubSub.Abstractions.SubscriptionExceptionHandler](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.SubscriptionExceptionHandler 'Myprysm.PubSub.Abstractions.SubscriptionExceptionHandler').  
```csharp
public System.Threading.Tasks.Task<Myprysm.PubSub.Abstractions.ISubscription> Subscribe(Myprysm.PubSub.Abstractions.Topic topic, Myprysm.PubSub.Abstractions.PublicationHandler handler, Myprysm.PubSub.Abstractions.SubscriptionGroup? group=null, Myprysm.PubSub.Abstractions.SubscriptionExceptionHandler? exceptionHandler=null, System.Threading.CancellationToken cancellation=default(System.Threading.CancellationToken));
```
#### Parameters
<a name='Myprysm_PubSub_Nats_NatsBrokerConnection_Subscribe(Myprysm_PubSub_Abstractions_Topic_Myprysm_PubSub_Abstractions_PublicationHandler_Myprysm_PubSub_Abstractions_SubscriptionGroup__Myprysm_PubSub_Abstractions_SubscriptionExceptionHandler__System_Threading_CancellationToken)_topic'></a>
`topic` [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic')  
  
<a name='Myprysm_PubSub_Nats_NatsBrokerConnection_Subscribe(Myprysm_PubSub_Abstractions_Topic_Myprysm_PubSub_Abstractions_PublicationHandler_Myprysm_PubSub_Abstractions_SubscriptionGroup__Myprysm_PubSub_Abstractions_SubscriptionExceptionHandler__System_Threading_CancellationToken)_handler'></a>
`handler` [Myprysm.PubSub.Abstractions.PublicationHandler](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.PublicationHandler 'Myprysm.PubSub.Abstractions.PublicationHandler')  
  
<a name='Myprysm_PubSub_Nats_NatsBrokerConnection_Subscribe(Myprysm_PubSub_Abstractions_Topic_Myprysm_PubSub_Abstractions_PublicationHandler_Myprysm_PubSub_Abstractions_SubscriptionGroup__Myprysm_PubSub_Abstractions_SubscriptionExceptionHandler__System_Threading_CancellationToken)_group'></a>
`group` [Myprysm.PubSub.Abstractions.SubscriptionGroup](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.SubscriptionGroup 'Myprysm.PubSub.Abstractions.SubscriptionGroup')  
  
<a name='Myprysm_PubSub_Nats_NatsBrokerConnection_Subscribe(Myprysm_PubSub_Abstractions_Topic_Myprysm_PubSub_Abstractions_PublicationHandler_Myprysm_PubSub_Abstractions_SubscriptionGroup__Myprysm_PubSub_Abstractions_SubscriptionExceptionHandler__System_Threading_CancellationToken)_exceptionHandler'></a>
`exceptionHandler` [Myprysm.PubSub.Abstractions.SubscriptionExceptionHandler](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.SubscriptionExceptionHandler 'Myprysm.PubSub.Abstractions.SubscriptionExceptionHandler')  
  
<a name='Myprysm_PubSub_Nats_NatsBrokerConnection_Subscribe(Myprysm_PubSub_Abstractions_Topic_Myprysm_PubSub_Abstractions_PublicationHandler_Myprysm_PubSub_Abstractions_SubscriptionGroup__Myprysm_PubSub_Abstractions_SubscriptionExceptionHandler__System_Threading_CancellationToken)_cancellation'></a>
`cancellation` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')  
  
#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[Myprysm.PubSub.Abstractions.ISubscription](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.ISubscription 'Myprysm.PubSub.Abstractions.ISubscription')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  

Implements [Subscribe(Topic, PublicationHandler, SubscriptionGroup?, SubscriptionExceptionHandler?, CancellationToken)](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.IBrokerConnection.Subscribe#Myprysm_PubSub_Abstractions_IBrokerConnection_Subscribe_Myprysm_PubSub_Abstractions_Topic,Myprysm_PubSub_Abstractions_PublicationHandler,Myprysm_PubSub_Abstractions_SubscriptionGroup,Myprysm_PubSub_Abstractions_SubscriptionExceptionHandler,System_Threading_CancellationToken_ 'Myprysm.PubSub.Abstractions.IBrokerConnection.Subscribe(Myprysm.PubSub.Abstractions.Topic,Myprysm.PubSub.Abstractions.PublicationHandler,Myprysm.PubSub.Abstractions.SubscriptionGroup,Myprysm.PubSub.Abstractions.SubscriptionExceptionHandler,System.Threading.CancellationToken)')  
### Remarks
  
