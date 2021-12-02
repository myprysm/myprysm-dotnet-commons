#### [Myprysm.PubSub.Abstractions](index.md 'index')
### [Myprysm.PubSub.Abstractions](index.md#Myprysm_PubSub_Abstractions 'Myprysm.PubSub.Abstractions')
## Publication Class
Represents a publication to send to any unknown [ISubscription](Myprysm_PubSub_Abstractions_ISubscription.md 'Myprysm.PubSub.Abstractions.ISubscription') handled by an [IBrokerConnection](Myprysm_PubSub_Abstractions_IBrokerConnection.md 'Myprysm.PubSub.Abstractions.IBrokerConnection').  
```csharp
public class Publication :
System.IEquatable<Myprysm.PubSub.Abstractions.Publication>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Publication  

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Publication](Myprysm_PubSub_Abstractions_Publication.md 'Myprysm.PubSub.Abstractions.Publication')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')  
### Constructors
<a name='Myprysm_PubSub_Abstractions_Publication_Publication(Myprysm_PubSub_Abstractions_Topic_byte___bool_Myprysm_Tracing_Abstractions_ITrace_)'></a>
## Publication.Publication(Topic, byte[], bool, ITrace?) Constructor
Represents a publication to send to any unknown [ISubscription](Myprysm_PubSub_Abstractions_ISubscription.md 'Myprysm.PubSub.Abstractions.ISubscription') handled by an [IBrokerConnection](Myprysm_PubSub_Abstractions_IBrokerConnection.md 'Myprysm.PubSub.Abstractions.IBrokerConnection').  
```csharp
public Publication(Myprysm.PubSub.Abstractions.Topic Topic, byte[] Message, bool IsVolatile=true, Myprysm.Tracing.Abstractions.ITrace? Trace=null);
```
#### Parameters
<a name='Myprysm_PubSub_Abstractions_Publication_Publication(Myprysm_PubSub_Abstractions_Topic_byte___bool_Myprysm_Tracing_Abstractions_ITrace_)_Topic'></a>
`Topic` [Topic](Myprysm_PubSub_Abstractions_Topic.md 'Myprysm.PubSub.Abstractions.Topic')  
The topic to send the publication.
  
<a name='Myprysm_PubSub_Abstractions_Publication_Publication(Myprysm_PubSub_Abstractions_Topic_byte___bool_Myprysm_Tracing_Abstractions_ITrace_)_Message'></a>
`Message` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The content of the publication.
  
<a name='Myprysm_PubSub_Abstractions_Publication_Publication(Myprysm_PubSub_Abstractions_Topic_byte___bool_Myprysm_Tracing_Abstractions_ITrace_)_IsVolatile'></a>
`IsVolatile` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Whether this publication is volatile or persistent.  
Some brokers only support volatile or persistent publications. You should verify the underlying [Capabilities](Myprysm_PubSub_Abstractions_IBrokerConnection.md#Myprysm_PubSub_Abstractions_IBrokerConnection_Capabilities 'Myprysm.PubSub.Abstractions.IBrokerConnection.Capabilities').  
  
<a name='Myprysm_PubSub_Abstractions_Publication_Publication(Myprysm_PubSub_Abstractions_Topic_byte___bool_Myprysm_Tracing_Abstractions_ITrace_)_Trace'></a>
`Trace` [Myprysm.Tracing.Abstractions.ITrace](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace 'Myprysm.Tracing.Abstractions.ITrace')  
The trace used as a parent. You should not have to provide one as the [IBrokerConnection](Myprysm_PubSub_Abstractions_IBrokerConnection.md 'Myprysm.PubSub.Abstractions.IBrokerConnection') should try to  
obtain the [Myprysm.Tracing.Abstractions.ITracer.CurrentTrace](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITracer.CurrentTrace 'Myprysm.Tracing.Abstractions.ITracer.CurrentTrace') by itself. This can be useful for testing purpose.  
  
  
