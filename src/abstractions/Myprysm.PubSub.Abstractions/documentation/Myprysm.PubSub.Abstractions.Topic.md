#### [Myprysm.PubSub.Abstractions](index.md 'index')
### [Myprysm.PubSub.Abstractions](index.md#Myprysm.PubSub.Abstractions 'Myprysm.PubSub.Abstractions')

## Topic Class

Represents a topic to send a [Publication](Myprysm.PubSub.Abstractions.Publication.md 'Myprysm.PubSub.Abstractions.Publication').

```csharp
public class Topic : Myprysm.SharedKernel.ValueObjects.SingleValueObject<string>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Myprysm.SharedKernel.ValueObjects.ValueObject](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.SharedKernel.ValueObjects.ValueObject 'Myprysm.SharedKernel.ValueObjects.ValueObject') &#129106; [Myprysm.SharedKernel.ValueObjects.SingleValueObject&lt;](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.SharedKernel.ValueObjects.SingleValueObject-1 'Myprysm.SharedKernel.ValueObjects.SingleValueObject`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.SharedKernel.ValueObjects.SingleValueObject-1 'Myprysm.SharedKernel.ValueObjects.SingleValueObject`1') &#129106; Topic

### Remarks
The validity of the topic name may vary depending on the implementation.
### Constructors

<a name='Myprysm.PubSub.Abstractions.Topic.Topic(string)'></a>

## Topic(string) Constructor

Creates a new [Topic](Myprysm.PubSub.Abstractions.Topic.md 'Myprysm.PubSub.Abstractions.Topic').

```csharp
public Topic(string value);
```
#### Parameters

<a name='Myprysm.PubSub.Abstractions.Topic.Topic(string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value of the topic