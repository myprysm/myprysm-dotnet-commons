#### [Myprysm.PubSub.Abstractions.Testing](index.md 'index')
### [Myprysm.PubSub.Abstractions.Testing.Integration](index.md#Myprysm_PubSub_Abstractions_Testing_Integration 'Myprysm.PubSub.Abstractions.Testing.Integration')
## BrokerConnectionTests&lt;TOptions&gt; Class
Base test suite for all kind of [Myprysm.PubSub.Abstractions.IBrokerConnection](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.IBrokerConnection 'Myprysm.PubSub.Abstractions.IBrokerConnection') that ensures tracing is supported appropriately.  
```csharp
public abstract class BrokerConnectionTests<TOptions> : Myprysm.Testing.NUnit.ServiceTests
    where TOptions : Myprysm.PubSub.Abstractions.PubSubOptions
```
#### Type parameters
<a name='Myprysm_PubSub_Abstractions_Testing_Integration_BrokerConnectionTests_TOptions__TOptions'></a>
`TOptions`  
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Myprysm.Testing.NUnit.FixtureTests](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Testing.NUnit.FixtureTests 'Myprysm.Testing.NUnit.FixtureTests') &#129106; [Myprysm.Testing.NUnit.ServiceTests](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Testing.NUnit.ServiceTests 'Myprysm.Testing.NUnit.ServiceTests') &#129106; BrokerConnectionTests&lt;TOptions&gt;  

Derived  
&#8627; [PersistentBrokerConnectionTests&lt;TOptions&gt;](Myprysm_PubSub_Abstractions_Testing_Integration_PersistentBrokerConnectionTests_TOptions_.md 'Myprysm.PubSub.Abstractions.Testing.Integration.PersistentBrokerConnectionTests&lt;TOptions&gt;')  
&#8627; [SubscriptionGroupBrokerConnectionTests&lt;TOptions&gt;](Myprysm_PubSub_Abstractions_Testing_Integration_SubscriptionGroupBrokerConnectionTests_TOptions_.md 'Myprysm.PubSub.Abstractions.Testing.Integration.SubscriptionGroupBrokerConnectionTests&lt;TOptions&gt;')  
&#8627; [VolatileBrokerConnectionTests&lt;TOptions&gt;](Myprysm_PubSub_Abstractions_Testing_Integration_VolatileBrokerConnectionTests_TOptions_.md 'Myprysm.PubSub.Abstractions.Testing.Integration.VolatileBrokerConnectionTests&lt;TOptions&gt;')  
### Methods
<a name='Myprysm_PubSub_Abstractions_Testing_Integration_BrokerConnectionTests_TOptions__ResetGlobalSubscriptionExceptionHandler()'></a>
## BrokerConnectionTests&lt;TOptions&gt;.ResetGlobalSubscriptionExceptionHandler() Method
Ensures that the global subscription exception handler is reset to a default noop value.  
```csharp
public void ResetGlobalSubscriptionExceptionHandler();
```
  
<a name='Myprysm_PubSub_Abstractions_Testing_Integration_BrokerConnectionTests_TOptions__When_a_message_handler_throws_application_does_not_crash()'></a>
## BrokerConnectionTests&lt;TOptions&gt;.When_a_message_handler_throws_application_does_not_crash() Method
You should ensure that given a [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic')  
When a [Myprysm.PubSub.Abstractions.ISubscription](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.ISubscription 'Myprysm.PubSub.Abstractions.ISubscription') is made on this [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic')  
And a [Myprysm.PubSub.Abstractions.Publication](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Publication 'Myprysm.PubSub.Abstractions.Publication') is published on this [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic')  
And the subscription handler throws an exception  
Then the application does not crash.  
```csharp
public System.Threading.Tasks.Task When_a_message_handler_throws_application_does_not_crash();
```
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
  
<a name='Myprysm_PubSub_Abstractions_Testing_Integration_BrokerConnectionTests_TOptions__When_a_null_message_comes_from_an_external_source_application_does_not_crash()'></a>
## BrokerConnectionTests&lt;TOptions&gt;.When_a_null_message_comes_from_an_external_source_application_does_not_crash() Method
You should ensure that given a [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic')  
When a [Myprysm.PubSub.Abstractions.ISubscription](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.ISubscription 'Myprysm.PubSub.Abstractions.ISubscription') is made on this [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic')  
And a ```csharp
null```
 message is published on this [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic')  
Then the application does not crash.  
```csharp
public System.Threading.Tasks.Task When_a_null_message_comes_from_an_external_source_application_does_not_crash();
```
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
  
<a name='Myprysm_PubSub_Abstractions_Testing_Integration_BrokerConnectionTests_TOptions__When_broker_connection_is_down_health_check_returns_unhealthy()'></a>
## BrokerConnectionTests&lt;TOptions&gt;.When_broker_connection_is_down_health_check_returns_unhealthy() Method
You should ensure that given a disposed [Myprysm.PubSub.Abstractions.IBrokerConnection](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.IBrokerConnection 'Myprysm.PubSub.Abstractions.IBrokerConnection')  
When the [Myprysm.PubSub.Abstractions.BrokerHealthCheck](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.BrokerHealthCheck 'Myprysm.PubSub.Abstractions.BrokerHealthCheck') verifies the health.  
Then the [Myprysm.PubSub.Abstractions.BrokerHealthCheck](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.BrokerHealthCheck 'Myprysm.PubSub.Abstractions.BrokerHealthCheck') returns Unhealthy  
```csharp
public System.Threading.Tasks.Task When_broker_connection_is_down_health_check_returns_unhealthy();
```
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
  
<a name='Myprysm_PubSub_Abstractions_Testing_Integration_BrokerConnectionTests_TOptions__When_broker_connection_is_up_health_check_returns_healthy()'></a>
## BrokerConnectionTests&lt;TOptions&gt;.When_broker_connection_is_up_health_check_returns_healthy() Method
You should ensure that given a [Myprysm.PubSub.Abstractions.IBrokerConnection](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.IBrokerConnection 'Myprysm.PubSub.Abstractions.IBrokerConnection')  
When the [Myprysm.PubSub.Abstractions.BrokerHealthCheck](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.BrokerHealthCheck 'Myprysm.PubSub.Abstractions.BrokerHealthCheck') verifies the health.  
Then the [Myprysm.PubSub.Abstractions.BrokerHealthCheck](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.BrokerHealthCheck 'Myprysm.PubSub.Abstractions.BrokerHealthCheck') returns Healthy  
```csharp
public System.Threading.Tasks.Task When_broker_connection_is_up_health_check_returns_healthy();
```
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
  
<a name='Myprysm_PubSub_Abstractions_Testing_Integration_BrokerConnectionTests_TOptions__When_header_is_provided_then_header_is_available_to_consume()'></a>
## BrokerConnectionTests&lt;TOptions&gt;.When_header_is_provided_then_header_is_available_to_consume() Method
You should ensure that given a [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic')  
When a [Myprysm.PubSub.Abstractions.ISubscription](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.ISubscription 'Myprysm.PubSub.Abstractions.ISubscription') is made on this [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic')  
And a [Myprysm.PubSub.Abstractions.Publication](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Publication 'Myprysm.PubSub.Abstractions.Publication') is published on this [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic') without a [Myprysm.Tracing.Abstractions.ITrace](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace 'Myprysm.Tracing.Abstractions.ITrace')  
Then the [Myprysm.PubSub.Abstractions.Publication](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Publication 'Myprysm.PubSub.Abstractions.Publication') contains a [Myprysm.Tracing.Abstractions.ITrace](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace 'Myprysm.Tracing.Abstractions.ITrace') with a parent.  
```csharp
public System.Threading.Tasks.Task When_header_is_provided_then_header_is_available_to_consume();
```
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
  
<a name='Myprysm_PubSub_Abstractions_Testing_Integration_BrokerConnectionTests_TOptions__When_trace_is_not_provided_then_subscribers_should_have_new_trace_with_parent()'></a>
## BrokerConnectionTests&lt;TOptions&gt;.When_trace_is_not_provided_then_subscribers_should_have_new_trace_with_parent() Method
You should ensure that given a [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic')  
When a [Myprysm.PubSub.Abstractions.ISubscription](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.ISubscription 'Myprysm.PubSub.Abstractions.ISubscription') is made on this [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic')  
And a [Myprysm.PubSub.Abstractions.Publication](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Publication 'Myprysm.PubSub.Abstractions.Publication') is published on this [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic') without a [Myprysm.Tracing.Abstractions.ITrace](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace 'Myprysm.Tracing.Abstractions.ITrace')  
Then the [Myprysm.PubSub.Abstractions.Publication](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Publication 'Myprysm.PubSub.Abstractions.Publication') contains a [Myprysm.Tracing.Abstractions.ITrace](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace 'Myprysm.Tracing.Abstractions.ITrace') with a parent.  
```csharp
public System.Threading.Tasks.Task When_trace_is_not_provided_then_subscribers_should_have_new_trace_with_parent();
```
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
  
<a name='Myprysm_PubSub_Abstractions_Testing_Integration_BrokerConnectionTests_TOptions__When_trace_is_provided_then_subscribers_should_have_new_trace_with_parent()'></a>
## BrokerConnectionTests&lt;TOptions&gt;.When_trace_is_provided_then_subscribers_should_have_new_trace_with_parent() Method
You should ensure that given a [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic')  
When a [Myprysm.PubSub.Abstractions.ISubscription](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.ISubscription 'Myprysm.PubSub.Abstractions.ISubscription') is made on this [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic')  
And a [Myprysm.PubSub.Abstractions.Publication](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Publication 'Myprysm.PubSub.Abstractions.Publication') is published on this [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic') with a [Myprysm.Tracing.Abstractions.ITrace](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace 'Myprysm.Tracing.Abstractions.ITrace')  
Then the [Myprysm.PubSub.Abstractions.Publication](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Publication 'Myprysm.PubSub.Abstractions.Publication') contains a [Myprysm.Tracing.Abstractions.ITrace](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace 'Myprysm.Tracing.Abstractions.ITrace') with a parent.  
```csharp
public System.Threading.Tasks.Task When_trace_is_provided_then_subscribers_should_have_new_trace_with_parent();
```
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
  
<a name='Myprysm_PubSub_Abstractions_Testing_Integration_BrokerConnectionTests_TOptions__When_trace_is_provided_with_baggage_then_subscribers_should_have_baggage()'></a>
## BrokerConnectionTests&lt;TOptions&gt;.When_trace_is_provided_with_baggage_then_subscribers_should_have_baggage() Method
You should ensure that given a [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic')  
When a [Myprysm.PubSub.Abstractions.ISubscription](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.ISubscription 'Myprysm.PubSub.Abstractions.ISubscription') is made on this [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic')  
And a [Myprysm.PubSub.Abstractions.Publication](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Publication 'Myprysm.PubSub.Abstractions.Publication') is published on this [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic')  
Then the [Myprysm.PubSub.Abstractions.Publication](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Publication 'Myprysm.PubSub.Abstractions.Publication') contains a [Myprysm.Tracing.Abstractions.ITrace](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace 'Myprysm.Tracing.Abstractions.ITrace') with a parent  
And the [Myprysm.Tracing.Abstractions.ITrace](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace 'Myprysm.Tracing.Abstractions.ITrace') contains the parent baggage.  
```csharp
public System.Threading.Tasks.Task When_trace_is_provided_with_baggage_then_subscribers_should_have_baggage();
```
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
  
