#### [Myprysm.PubSub.Abstractions.Testing](index.md 'index')
### [Myprysm.PubSub.Abstractions.Testing.Integration](index.md#Myprysm_PubSub_Abstractions_Testing_Integration 'Myprysm.PubSub.Abstractions.Testing.Integration')
## SubscriptionGroupBrokerConnectionTests&lt;TOptions&gt; Class
Test suite to implement for a [Myprysm.PubSub.Abstractions.IBrokerConnection](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.IBrokerConnection 'Myprysm.PubSub.Abstractions.IBrokerConnection') that supports [Myprysm.PubSub.Abstractions.SubscriptionGroup](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.SubscriptionGroup 'Myprysm.PubSub.Abstractions.SubscriptionGroup').  
```csharp
public abstract class SubscriptionGroupBrokerConnectionTests<TOptions> : Myprysm.PubSub.Abstractions.Testing.Integration.BrokerConnectionTests<TOptions>
    where TOptions : Myprysm.PubSub.Abstractions.PubSubOptions
```
#### Type parameters
<a name='Myprysm_PubSub_Abstractions_Testing_Integration_SubscriptionGroupBrokerConnectionTests_TOptions__TOptions'></a>
`TOptions`  
The specialized type of the [Myprysm.PubSub.Abstractions.PubSubOptions](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.PubSubOptions 'Myprysm.PubSub.Abstractions.PubSubOptions').
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Myprysm.Testing.NUnit.FixtureTests](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Testing.NUnit.FixtureTests 'Myprysm.Testing.NUnit.FixtureTests') &#129106; [Myprysm.Testing.NUnit.ServiceTests](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Testing.NUnit.ServiceTests 'Myprysm.Testing.NUnit.ServiceTests') &#129106; [Myprysm.PubSub.Abstractions.Testing.Integration.BrokerConnectionTests&lt;](Myprysm_PubSub_Abstractions_Testing_Integration_BrokerConnectionTests_TOptions_.md 'Myprysm.PubSub.Abstractions.Testing.Integration.BrokerConnectionTests&lt;TOptions&gt;')[TOptions](Myprysm_PubSub_Abstractions_Testing_Integration_SubscriptionGroupBrokerConnectionTests_TOptions_.md#Myprysm_PubSub_Abstractions_Testing_Integration_SubscriptionGroupBrokerConnectionTests_TOptions__TOptions 'Myprysm.PubSub.Abstractions.Testing.Integration.SubscriptionGroupBrokerConnectionTests&lt;TOptions&gt;.TOptions')[&gt;](Myprysm_PubSub_Abstractions_Testing_Integration_BrokerConnectionTests_TOptions_.md 'Myprysm.PubSub.Abstractions.Testing.Integration.BrokerConnectionTests&lt;TOptions&gt;') &#129106; SubscriptionGroupBrokerConnectionTests&lt;TOptions&gt;  
### Methods
<a name='Myprysm_PubSub_Abstractions_Testing_Integration_SubscriptionGroupBrokerConnectionTests_TOptions__CheckCapability()'></a>
## SubscriptionGroupBrokerConnectionTests&lt;TOptions&gt;.CheckCapability() Method
Verify that the underlying [Myprysm.PubSub.Abstractions.IBrokerConnection](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.IBrokerConnection 'Myprysm.PubSub.Abstractions.IBrokerConnection') supports [Myprysm.PubSub.Abstractions.SubscriptionGroup](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.SubscriptionGroup 'Myprysm.PubSub.Abstractions.SubscriptionGroup').  
```csharp
public void CheckCapability();
```
  
<a name='Myprysm_PubSub_Abstractions_Testing_Integration_SubscriptionGroupBrokerConnectionTests_TOptions__When_two_subscriptions_are_active_in_different_subscription_groups_then_both_receive_publication()'></a>
## SubscriptionGroupBrokerConnectionTests&lt;TOptions&gt;.When_two_subscriptions_are_active_in_different_subscription_groups_then_both_receive_publication() Method
You should ensure that given a [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic')  
When a [Myprysm.PubSub.Abstractions.Publication](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Publication 'Myprysm.PubSub.Abstractions.Publication') is published on this [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic')  
And a [Myprysm.PubSub.Abstractions.ISubscription](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.ISubscription 'Myprysm.PubSub.Abstractions.ISubscription') is made with a [Myprysm.PubSub.Abstractions.SubscriptionGroup](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.SubscriptionGroup 'Myprysm.PubSub.Abstractions.SubscriptionGroup') on this [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic')  
And a [Myprysm.PubSub.Abstractions.ISubscription](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.ISubscription 'Myprysm.PubSub.Abstractions.ISubscription') is made with another [Myprysm.PubSub.Abstractions.SubscriptionGroup](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.SubscriptionGroup 'Myprysm.PubSub.Abstractions.SubscriptionGroup') on this [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic')  
Then all [Myprysm.PubSub.Abstractions.ISubscription](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.ISubscription 'Myprysm.PubSub.Abstractions.ISubscription') receive the [Myprysm.PubSub.Abstractions.Publication](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Publication 'Myprysm.PubSub.Abstractions.Publication').  
```csharp
public System.Threading.Tasks.Task When_two_subscriptions_are_active_in_different_subscription_groups_then_both_receive_publication();
```
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
  
<a name='Myprysm_PubSub_Abstractions_Testing_Integration_SubscriptionGroupBrokerConnectionTests_TOptions__When_two_subscriptions_are_active_in_the_same_subscription_group_then_only_one_receive_publication()'></a>
## SubscriptionGroupBrokerConnectionTests&lt;TOptions&gt;.When_two_subscriptions_are_active_in_the_same_subscription_group_then_only_one_receive_publication() Method
You should ensure that given a [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic')  
When a [Myprysm.PubSub.Abstractions.Publication](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Publication 'Myprysm.PubSub.Abstractions.Publication') is published on this [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic')  
And a [Myprysm.PubSub.Abstractions.ISubscription](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.ISubscription 'Myprysm.PubSub.Abstractions.ISubscription') is made with a [Myprysm.PubSub.Abstractions.SubscriptionGroup](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.SubscriptionGroup 'Myprysm.PubSub.Abstractions.SubscriptionGroup') on this [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic')  
And a [Myprysm.PubSub.Abstractions.ISubscription](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.ISubscription 'Myprysm.PubSub.Abstractions.ISubscription') is made with a [Myprysm.PubSub.Abstractions.SubscriptionGroup](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.SubscriptionGroup 'Myprysm.PubSub.Abstractions.SubscriptionGroup') on this [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic')  
Then only one [Myprysm.PubSub.Abstractions.ISubscription](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.ISubscription 'Myprysm.PubSub.Abstractions.ISubscription') receive the [Myprysm.PubSub.Abstractions.Publication](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Publication 'Myprysm.PubSub.Abstractions.Publication').  
```csharp
public System.Threading.Tasks.Task When_two_subscriptions_are_active_in_the_same_subscription_group_then_only_one_receive_publication();
```
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
  
<a name='Myprysm_PubSub_Abstractions_Testing_Integration_SubscriptionGroupBrokerConnectionTests_TOptions__When_two_subscriptions_are_active_then_both_receive_publication()'></a>
## SubscriptionGroupBrokerConnectionTests&lt;TOptions&gt;.When_two_subscriptions_are_active_then_both_receive_publication() Method
You should ensure that given a [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic')  
When a [Myprysm.PubSub.Abstractions.Publication](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Publication 'Myprysm.PubSub.Abstractions.Publication') is published on this [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic')  
And a [Myprysm.PubSub.Abstractions.ISubscription](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.ISubscription 'Myprysm.PubSub.Abstractions.ISubscription') is made without subscription group on this [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic')  
And a [Myprysm.PubSub.Abstractions.ISubscription](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.ISubscription 'Myprysm.PubSub.Abstractions.ISubscription') is made without subscription group on this [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic')  
Then all [Myprysm.PubSub.Abstractions.ISubscription](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.ISubscription 'Myprysm.PubSub.Abstractions.ISubscription') receive the [Myprysm.PubSub.Abstractions.Publication](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Publication 'Myprysm.PubSub.Abstractions.Publication').  
```csharp
public System.Threading.Tasks.Task When_two_subscriptions_are_active_then_both_receive_publication();
```
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
  
