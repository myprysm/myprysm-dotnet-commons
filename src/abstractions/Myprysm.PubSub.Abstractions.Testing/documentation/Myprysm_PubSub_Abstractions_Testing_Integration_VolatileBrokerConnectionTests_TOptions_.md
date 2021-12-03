#### [Myprysm.PubSub.Abstractions.Testing](index.md 'index')
### [Myprysm.PubSub.Abstractions.Testing.Integration](index.md#Myprysm_PubSub_Abstractions_Testing_Integration 'Myprysm.PubSub.Abstractions.Testing.Integration')
## VolatileBrokerConnectionTests&lt;TOptions&gt; Class
Test suite to implement for a [Myprysm.PubSub.Abstractions.Transport.Transient](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Transport.Transient 'Myprysm.PubSub.Abstractions.Transport.Transient')[Myprysm.PubSub.Abstractions.IBrokerConnection](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.IBrokerConnection 'Myprysm.PubSub.Abstractions.IBrokerConnection').  
```csharp
public abstract class VolatileBrokerConnectionTests<TOptions> : Myprysm.PubSub.Abstractions.Testing.Integration.BrokerConnectionTests<TOptions>
    where TOptions : Myprysm.PubSub.Abstractions.PubSubOptions
```
#### Type parameters
<a name='Myprysm_PubSub_Abstractions_Testing_Integration_VolatileBrokerConnectionTests_TOptions__TOptions'></a>
`TOptions`  
The specialized type of the [Myprysm.PubSub.Abstractions.PubSubOptions](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.PubSubOptions 'Myprysm.PubSub.Abstractions.PubSubOptions').
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Myprysm.Testing.NUnit.FixtureTests](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Testing.NUnit.FixtureTests 'Myprysm.Testing.NUnit.FixtureTests') &#129106; [Myprysm.Testing.NUnit.ServiceTests](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Testing.NUnit.ServiceTests 'Myprysm.Testing.NUnit.ServiceTests') &#129106; [Myprysm.PubSub.Abstractions.Testing.Integration.BrokerConnectionTests&lt;](Myprysm_PubSub_Abstractions_Testing_Integration_BrokerConnectionTests_TOptions_.md 'Myprysm.PubSub.Abstractions.Testing.Integration.BrokerConnectionTests&lt;TOptions&gt;')[TOptions](Myprysm_PubSub_Abstractions_Testing_Integration_VolatileBrokerConnectionTests_TOptions_.md#Myprysm_PubSub_Abstractions_Testing_Integration_VolatileBrokerConnectionTests_TOptions__TOptions 'Myprysm.PubSub.Abstractions.Testing.Integration.VolatileBrokerConnectionTests&lt;TOptions&gt;.TOptions')[&gt;](Myprysm_PubSub_Abstractions_Testing_Integration_BrokerConnectionTests_TOptions_.md 'Myprysm.PubSub.Abstractions.Testing.Integration.BrokerConnectionTests&lt;TOptions&gt;') &#129106; VolatileBrokerConnectionTests&lt;TOptions&gt;  
### Methods
<a name='Myprysm_PubSub_Abstractions_Testing_Integration_VolatileBrokerConnectionTests_TOptions__CheckCapability()'></a>
## VolatileBrokerConnectionTests&lt;TOptions&gt;.CheckCapability() Method
Verify that the underlying [Myprysm.PubSub.Abstractions.IBrokerConnection](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.IBrokerConnection 'Myprysm.PubSub.Abstractions.IBrokerConnection') supports persistent [Myprysm.PubSub.Abstractions.Publication](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Publication 'Myprysm.PubSub.Abstractions.Publication').  
```csharp
public void CheckCapability();
```
  
<a name='Myprysm_PubSub_Abstractions_Testing_Integration_VolatileBrokerConnectionTests_TOptions__When_subscription_is_active_after_publication_is_sent_then_publication_is_lost()'></a>
## VolatileBrokerConnectionTests&lt;TOptions&gt;.When_subscription_is_active_after_publication_is_sent_then_publication_is_lost() Method
You should ensure that given a [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic')  
When a [Myprysm.PubSub.Abstractions.Publication](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Publication 'Myprysm.PubSub.Abstractions.Publication') is published on this [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic')  
And a [Myprysm.PubSub.Abstractions.ISubscription](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.ISubscription 'Myprysm.PubSub.Abstractions.ISubscription') is made on this [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic')  
Then the [Myprysm.PubSub.Abstractions.Publication](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Publication 'Myprysm.PubSub.Abstractions.Publication') is lost.  
```csharp
public System.Threading.Tasks.Task When_subscription_is_active_after_publication_is_sent_then_publication_is_lost();
```
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
  
<a name='Myprysm_PubSub_Abstractions_Testing_Integration_VolatileBrokerConnectionTests_TOptions__When_subscription_is_active_before_publication_is_sent_then_publication_is_received()'></a>
## VolatileBrokerConnectionTests&lt;TOptions&gt;.When_subscription_is_active_before_publication_is_sent_then_publication_is_received() Method
You should ensure that given a [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic')  
When a [Myprysm.PubSub.Abstractions.Publication](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Publication 'Myprysm.PubSub.Abstractions.Publication') is published on this [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic')  
And a [Myprysm.PubSub.Abstractions.ISubscription](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.ISubscription 'Myprysm.PubSub.Abstractions.ISubscription') is made on this [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic')  
Then the [Myprysm.PubSub.Abstractions.Publication](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Publication 'Myprysm.PubSub.Abstractions.Publication') is received.  
```csharp
public System.Threading.Tasks.Task When_subscription_is_active_before_publication_is_sent_then_publication_is_received();
```
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
  
