#### [Myprysm.PubSub.Abstractions](index.md 'index')
### [Myprysm.PubSub.Abstractions](index.md#Myprysm.PubSub.Abstractions 'Myprysm.PubSub.Abstractions')

## SubscriptionExceptionHandler(Exception) Delegate

Delegate invoked when an exception is thrown when processing a [Publication](Myprysm.PubSub.Abstractions.Publication.md 'Myprysm.PubSub.Abstractions.Publication') in an [ISubscription](Myprysm.PubSub.Abstractions.ISubscription.md 'Myprysm.PubSub.Abstractions.ISubscription').

```csharp
public delegate void SubscriptionExceptionHandler(System.Exception exception);
```
#### Parameters

<a name='Myprysm.PubSub.Abstractions.SubscriptionExceptionHandler(System.Exception).exception'></a>

`exception` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')