#### [Myprysm.PubSub.Abstractions](index.md 'index')
### [Myprysm.PubSub.Abstractions](index.md#Myprysm_PubSub_Abstractions 'Myprysm.PubSub.Abstractions')
## Transport Enum
The kind of transport supported by a broker.  
```csharp
public enum Transport

```
#### Fields
<a name='Myprysm_PubSub_Abstractions_Transport_Both'></a>
`Both` 2  
Supports both [Transient](Myprysm_PubSub_Abstractions_Transport.md#Myprysm_PubSub_Abstractions_Transport_Transient 'Myprysm.PubSub.Abstractions.Transport.Transient') and [Persistent](Myprysm_PubSub_Abstractions_Transport.md#Myprysm_PubSub_Abstractions_Transport_Persistent 'Myprysm.PubSub.Abstractions.Transport.Persistent') transports.  
  
<a name='Myprysm_PubSub_Abstractions_Transport_Persistent'></a>
`Persistent` 1  
Messages are persisted until a subscription is made to a topic.  
  
<a name='Myprysm_PubSub_Abstractions_Transport_Transient'></a>
`Transient` 0  
Messages can be lost when there is no subscription bound to a topic.  
  
