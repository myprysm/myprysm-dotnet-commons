#### [Myprysm.PubSub.Abstractions](index.md 'index')
### [Myprysm.PubSub.Abstractions](index.md#Myprysm.PubSub.Abstractions 'Myprysm.PubSub.Abstractions')

## SubscriptionGroup Class

Represents a subscription group that can be use to load balance publication across subscriptions within the group.  
Also known as competing consumer pattern.

```csharp
public class SubscriptionGroup : Myprysm.SharedKernel.ValueObjects.SingleValueObject<string>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Myprysm.SharedKernel.ValueObjects.ValueObject](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.SharedKernel.ValueObjects.ValueObject 'Myprysm.SharedKernel.ValueObjects.ValueObject') &#129106; [Myprysm.SharedKernel.ValueObjects.SingleValueObject&lt;](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.SharedKernel.ValueObjects.SingleValueObject-1 'Myprysm.SharedKernel.ValueObjects.SingleValueObject`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.SharedKernel.ValueObjects.SingleValueObject-1 'Myprysm.SharedKernel.ValueObjects.SingleValueObject`1') &#129106; SubscriptionGroup
### Constructors

<a name='Myprysm.PubSub.Abstractions.SubscriptionGroup.SubscriptionGroup(string)'></a>

## SubscriptionGroup(string) Constructor

Creates a new [SubscriptionGroup](Myprysm.PubSub.Abstractions.SubscriptionGroup.md 'Myprysm.PubSub.Abstractions.SubscriptionGroup')

```csharp
public SubscriptionGroup(string value);
```
#### Parameters

<a name='Myprysm.PubSub.Abstractions.SubscriptionGroup.SubscriptionGroup(string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value of the subscription group.