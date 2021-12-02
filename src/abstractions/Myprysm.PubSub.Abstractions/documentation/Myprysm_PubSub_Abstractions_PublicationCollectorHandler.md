#### [Myprysm.PubSub.Abstractions](index.md 'index')
### [Myprysm.PubSub.Abstractions](index.md#Myprysm_PubSub_Abstractions 'Myprysm.PubSub.Abstractions')
## PublicationCollectorHandler Class
A publication handler that collects the incoming publications.   
```csharp
public class PublicationCollectorHandler
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; PublicationCollectorHandler  
### Constructors
<a name='Myprysm_PubSub_Abstractions_PublicationCollectorHandler_PublicationCollectorHandler()'></a>
## PublicationCollectorHandler.PublicationCollectorHandler() Constructor
Creates a new [PublicationCollectorHandler](Myprysm_PubSub_Abstractions_PublicationCollectorHandler.md 'Myprysm.PubSub.Abstractions.PublicationCollectorHandler').0  
```csharp
public PublicationCollectorHandler();
```
  
### Methods
<a name='Myprysm_PubSub_Abstractions_PublicationCollectorHandler_GetMessages(System_TimeSpan_int)'></a>
## PublicationCollectorHandler.GetMessages(TimeSpan, int) Method
Get the given number of messages from the subscribed topic within the given accepted timeout.  
```csharp
public System.Collections.Generic.IReadOnlyCollection<Myprysm.PubSub.Abstractions.Publication> GetMessages(System.TimeSpan timeout, int count=1);
```
#### Parameters
<a name='Myprysm_PubSub_Abstractions_PublicationCollectorHandler_GetMessages(System_TimeSpan_int)_timeout'></a>
`timeout` [System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')  
The timeout before failing the operation.
  
<a name='Myprysm_PubSub_Abstractions_PublicationCollectorHandler_GetMessages(System_TimeSpan_int)_count'></a>
`count` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The number of messages to collect.
  
#### Returns
[System.Collections.Generic.IReadOnlyCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyCollection-1 'System.Collections.Generic.IReadOnlyCollection`1')[Publication](Myprysm_PubSub_Abstractions_Publication.md 'Myprysm.PubSub.Abstractions.Publication')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyCollection-1 'System.Collections.Generic.IReadOnlyCollection`1')  
The collected messages.
#### Exceptions
[System.TimeoutException](https://docs.microsoft.com/en-us/dotnet/api/System.TimeoutException 'System.TimeoutException')  
When the collector did not receive enough messages before the timeout.
  
<a name='Myprysm_PubSub_Abstractions_PublicationCollectorHandler_HandleAsync(Myprysm_PubSub_Abstractions_Publication)'></a>
## PublicationCollectorHandler.HandleAsync(Publication) Method
Store the incoming publication.  
```csharp
public System.Threading.Tasks.Task HandleAsync(Myprysm.PubSub.Abstractions.Publication publication);
```
#### Parameters
<a name='Myprysm_PubSub_Abstractions_PublicationCollectorHandler_HandleAsync(Myprysm_PubSub_Abstractions_Publication)_publication'></a>
`publication` [Publication](Myprysm_PubSub_Abstractions_Publication.md 'Myprysm.PubSub.Abstractions.Publication')  
The incoming publication.
  
#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
Succeeds always.
  
