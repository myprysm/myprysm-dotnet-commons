#### [Myprysm.PubSub.Abstractions.Testing](index.md 'index')
### [Myprysm.PubSub.Abstractions.Testing.Integration](index.md#Myprysm.PubSub.Abstractions.Testing.Integration 'Myprysm.PubSub.Abstractions.Testing.Integration')

## PersistentBrokerConnectionTests<TOptions> Class

Test suite to implement for a [Myprysm.PubSub.Abstractions.Transport.Persistent](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Transport.Persistent 'Myprysm.PubSub.Abstractions.Transport.Persistent')[Myprysm.PubSub.Abstractions.IBrokerConnection](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.IBrokerConnection 'Myprysm.PubSub.Abstractions.IBrokerConnection').

```csharp
public abstract class PersistentBrokerConnectionTests<TOptions> : Myprysm.PubSub.Abstractions.Testing.Integration.BrokerConnectionTests<TOptions>
    where TOptions : Myprysm.PubSub.Abstractions.PubSubOptions
```
#### Type parameters

<a name='Myprysm.PubSub.Abstractions.Testing.Integration.PersistentBrokerConnectionTests_TOptions_.TOptions'></a>

`TOptions`

The specialized type of the [Myprysm.PubSub.Abstractions.PubSubOptions](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.PubSubOptions 'Myprysm.PubSub.Abstractions.PubSubOptions').

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Myprysm.Testing.NUnit.FixtureTests](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Testing.NUnit.FixtureTests 'Myprysm.Testing.NUnit.FixtureTests') &#129106; [Myprysm.Testing.NUnit.ServiceTests](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Testing.NUnit.ServiceTests 'Myprysm.Testing.NUnit.ServiceTests') &#129106; [Myprysm.PubSub.Abstractions.Testing.Integration.BrokerConnectionTests&lt;](Myprysm.PubSub.Abstractions.Testing.Integration.BrokerConnectionTests_TOptions_.md 'Myprysm.PubSub.Abstractions.Testing.Integration.BrokerConnectionTests<TOptions>')[TOptions](Myprysm.PubSub.Abstractions.Testing.Integration.PersistentBrokerConnectionTests_TOptions_.md#Myprysm.PubSub.Abstractions.Testing.Integration.PersistentBrokerConnectionTests_TOptions_.TOptions 'Myprysm.PubSub.Abstractions.Testing.Integration.PersistentBrokerConnectionTests<TOptions>.TOptions')[&gt;](Myprysm.PubSub.Abstractions.Testing.Integration.BrokerConnectionTests_TOptions_.md 'Myprysm.PubSub.Abstractions.Testing.Integration.BrokerConnectionTests<TOptions>') &#129106; PersistentBrokerConnectionTests<TOptions>
### Methods

<a name='Myprysm.PubSub.Abstractions.Testing.Integration.PersistentBrokerConnectionTests_TOptions_.CheckCapability()'></a>

## PersistentBrokerConnectionTests<TOptions>.CheckCapability() Method

Verify that the underlying [Myprysm.PubSub.Abstractions.IBrokerConnection](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.IBrokerConnection 'Myprysm.PubSub.Abstractions.IBrokerConnection') supports persistent [Myprysm.PubSub.Abstractions.Publication](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Publication 'Myprysm.PubSub.Abstractions.Publication').

```csharp
public void CheckCapability();
```

<a name='Myprysm.PubSub.Abstractions.Testing.Integration.PersistentBrokerConnectionTests_TOptions_.When_subscription_is_active_after_publication_is_sent_then_publication_is_received()'></a>

## PersistentBrokerConnectionTests<TOptions>.When_subscription_is_active_after_publication_is_sent_then_publication_is_received() Method

You should ensure that given a [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic')  
When a [Myprysm.PubSub.Abstractions.ISubscription](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.ISubscription 'Myprysm.PubSub.Abstractions.ISubscription') is made on this [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic')  
And a [Myprysm.PubSub.Abstractions.Publication](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Publication 'Myprysm.PubSub.Abstractions.Publication') is published on this [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic')  
Then the [Myprysm.PubSub.Abstractions.Publication](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Publication 'Myprysm.PubSub.Abstractions.Publication') is received.

```csharp
public System.Threading.Tasks.Task When_subscription_is_active_after_publication_is_sent_then_publication_is_received();
```

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')

<a name='Myprysm.PubSub.Abstractions.Testing.Integration.PersistentBrokerConnectionTests_TOptions_.When_subscription_is_active_before_publication_is_sent_then_publication_is_received()'></a>

## PersistentBrokerConnectionTests<TOptions>.When_subscription_is_active_before_publication_is_sent_then_publication_is_received() Method

You should ensure that given a [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic')  
When a [Myprysm.PubSub.Abstractions.Publication](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Publication 'Myprysm.PubSub.Abstractions.Publication') is published on this [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic')  
And a [Myprysm.PubSub.Abstractions.ISubscription](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.ISubscription 'Myprysm.PubSub.Abstractions.ISubscription') is made on this [Myprysm.PubSub.Abstractions.Topic](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Topic 'Myprysm.PubSub.Abstractions.Topic')  
Then the [Myprysm.PubSub.Abstractions.Publication](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.PubSub.Abstractions.Publication 'Myprysm.PubSub.Abstractions.Publication') is received.

```csharp
public System.Threading.Tasks.Task When_subscription_is_active_before_publication_is_sent_then_publication_is_received();
```

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')