#### [Myprysm.PubSub.Abstractions](index.md 'index')
### [Myprysm.PubSub.Abstractions](index.md#Myprysm_PubSub_Abstractions 'Myprysm.PubSub.Abstractions')
## Topic Class
Represents a topic to send a [Publication](Myprysm_PubSub_Abstractions_Publication.md 'Myprysm.PubSub.Abstractions.Publication').  
```csharp
public class Topic : Myprysm.SharedKernel.ValueObjects.SingleValueObject<string>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Myprysm.SharedKernel.ValueObjects.ValueObject](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.SharedKernel.ValueObjects.ValueObject 'Myprysm.SharedKernel.ValueObjects.ValueObject') &#129106; [Myprysm.SharedKernel.ValueObjects.SingleValueObject&lt;](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.SharedKernel.ValueObjects.SingleValueObject-1 'Myprysm.SharedKernel.ValueObjects.SingleValueObject`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.SharedKernel.ValueObjects.SingleValueObject-1 'Myprysm.SharedKernel.ValueObjects.SingleValueObject`1') &#129106; Topic  
### Remarks
The validity of the topic name may vary depending on the implementation.  
### Constructors
<a name='Myprysm_PubSub_Abstractions_Topic_Topic(string)'></a>
## Topic.Topic(string) Constructor
Creates a new [Topic](Myprysm_PubSub_Abstractions_Topic.md 'Myprysm.PubSub.Abstractions.Topic').  
```csharp
public Topic(string value);
```
#### Parameters
<a name='Myprysm_PubSub_Abstractions_Topic_Topic(string)_value'></a>
`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The value of the topic
  
  
