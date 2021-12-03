#### [Myprysm.PubSub.Abstractions](index.md 'index')
### [Myprysm.PubSub.Abstractions](index.md#Myprysm_PubSub_Abstractions 'Myprysm.PubSub.Abstractions')
## PubSubOptions Class
Base pub sub options.  
  
You should extend those options and use the dependency injection extensions if you want to enable tracing  
```csharp
public class PubSubOptions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; PubSubOptions  
### Fields
<a name='Myprysm_PubSub_Abstractions_PubSubOptions_GlobalSubscriptionExceptionHandler'></a>
## PubSubOptions.GlobalSubscriptionExceptionHandler Field
Global subscription exception handler used when no specific handler is given for a subscription.   
```csharp
public SubscriptionExceptionHandler GlobalSubscriptionExceptionHandler;
```
#### Field Value
[SubscriptionExceptionHandler(Exception)](Myprysm_PubSub_Abstractions_SubscriptionExceptionHandler(System_Exception).md 'Myprysm.PubSub.Abstractions.SubscriptionExceptionHandler(System.Exception)')
### Remarks
You can configure this handler as a catch-all for any subscription issue.  
This handler should not throw any exception.  
  
### Properties
<a name='Myprysm_PubSub_Abstractions_PubSubOptions_WithTracing'></a>
## PubSubOptions.WithTracing Property
Enable tracing with the broker connection implementation.  
```csharp
public bool WithTracing { get; set; }
```
#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
### Remarks
Tracing is enabled by default.
  
