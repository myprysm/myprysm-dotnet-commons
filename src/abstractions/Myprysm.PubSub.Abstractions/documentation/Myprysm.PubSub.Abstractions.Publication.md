#### [Myprysm.PubSub.Abstractions](index.md 'index')
### [Myprysm.PubSub.Abstractions](index.md#Myprysm.PubSub.Abstractions 'Myprysm.PubSub.Abstractions')

## Publication Class

Represents a publication to send to any unknown [ISubscription](Myprysm.PubSub.Abstractions.ISubscription.md 'Myprysm.PubSub.Abstractions.ISubscription') handled by an [IBrokerConnection](Myprysm.PubSub.Abstractions.IBrokerConnection.md 'Myprysm.PubSub.Abstractions.IBrokerConnection').

```csharp
public class Publication :
System.IEquatable<Myprysm.PubSub.Abstractions.Publication>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Publication

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Publication](Myprysm.PubSub.Abstractions.Publication.md 'Myprysm.PubSub.Abstractions.Publication')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')
### Constructors

<a name='Myprysm.PubSub.Abstractions.Publication.Publication(Myprysm.PubSub.Abstractions.Topic,byte[],System.Collections.Generic.IDictionary_string,string_,bool,Myprysm.Tracing.Abstractions.ITrace)'></a>

## Publication(Topic, byte[], IDictionary<string,string>, bool, ITrace) Constructor

Represents a publication to send to any unknown [ISubscription](Myprysm.PubSub.Abstractions.ISubscription.md 'Myprysm.PubSub.Abstractions.ISubscription') handled by an [IBrokerConnection](Myprysm.PubSub.Abstractions.IBrokerConnection.md 'Myprysm.PubSub.Abstractions.IBrokerConnection').

```csharp
public Publication(Myprysm.PubSub.Abstractions.Topic Topic, byte[] Message, System.Collections.Generic.IDictionary<string,string?>? Headers=null, bool IsVolatile=true, Myprysm.Tracing.Abstractions.ITrace? Trace=null);
```
#### Parameters

<a name='Myprysm.PubSub.Abstractions.Publication.Publication(Myprysm.PubSub.Abstractions.Topic,byte[],System.Collections.Generic.IDictionary_string,string_,bool,Myprysm.Tracing.Abstractions.ITrace).Topic'></a>

`Topic` [Topic](Myprysm.PubSub.Abstractions.Topic.md 'Myprysm.PubSub.Abstractions.Topic')

The topic to send the publication.

<a name='Myprysm.PubSub.Abstractions.Publication.Publication(Myprysm.PubSub.Abstractions.Topic,byte[],System.Collections.Generic.IDictionary_string,string_,bool,Myprysm.Tracing.Abstractions.ITrace).Message'></a>

`Message` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The content of the publication.

<a name='Myprysm.PubSub.Abstractions.Publication.Publication(Myprysm.PubSub.Abstractions.Topic,byte[],System.Collections.Generic.IDictionary_string,string_,bool,Myprysm.Tracing.Abstractions.ITrace).Headers'></a>

`Headers` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')

The headers of the publication.

<a name='Myprysm.PubSub.Abstractions.Publication.Publication(Myprysm.PubSub.Abstractions.Topic,byte[],System.Collections.Generic.IDictionary_string,string_,bool,Myprysm.Tracing.Abstractions.ITrace).IsVolatile'></a>

`IsVolatile` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Whether this publication is volatile or persistent.  
Some brokers only support volatile or persistent publications. You should verify the underlying [Capabilities](Myprysm.PubSub.Abstractions.IBrokerConnection.md#Myprysm.PubSub.Abstractions.IBrokerConnection.Capabilities 'Myprysm.PubSub.Abstractions.IBrokerConnection.Capabilities').

<a name='Myprysm.PubSub.Abstractions.Publication.Publication(Myprysm.PubSub.Abstractions.Topic,byte[],System.Collections.Generic.IDictionary_string,string_,bool,Myprysm.Tracing.Abstractions.ITrace).Trace'></a>

`Trace` [Myprysm.Tracing.Abstractions.ITrace](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace 'Myprysm.Tracing.Abstractions.ITrace')

The trace used as a parent. You should not have to provide one as the [IBrokerConnection](Myprysm.PubSub.Abstractions.IBrokerConnection.md 'Myprysm.PubSub.Abstractions.IBrokerConnection') should try to  
obtain the [Myprysm.Tracing.Abstractions.ITracer.CurrentTrace](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITracer.CurrentTrace 'Myprysm.Tracing.Abstractions.ITracer.CurrentTrace') by itself. This can be useful for testing purpose.
### Properties

<a name='Myprysm.PubSub.Abstractions.Publication.Headers'></a>

## Publication.Headers Property

The headers of the publication.

```csharp
public System.Collections.Generic.IDictionary<string,string?>? Headers { get; set; }
```

#### Property Value
[System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')

<a name='Myprysm.PubSub.Abstractions.Publication.IsVolatile'></a>

## Publication.IsVolatile Property

Whether this publication is volatile or persistent.  
Some brokers only support volatile or persistent publications. You should verify the underlying [Capabilities](Myprysm.PubSub.Abstractions.IBrokerConnection.md#Myprysm.PubSub.Abstractions.IBrokerConnection.Capabilities 'Myprysm.PubSub.Abstractions.IBrokerConnection.Capabilities').

```csharp
public bool IsVolatile { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='Myprysm.PubSub.Abstractions.Publication.Message'></a>

## Publication.Message Property

The content of the publication.

```csharp
public byte[] Message { get; set; }
```

#### Property Value
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

<a name='Myprysm.PubSub.Abstractions.Publication.Topic'></a>

## Publication.Topic Property

The topic to send the publication.

```csharp
public Myprysm.PubSub.Abstractions.Topic Topic { get; set; }
```

#### Property Value
[Topic](Myprysm.PubSub.Abstractions.Topic.md 'Myprysm.PubSub.Abstractions.Topic')

<a name='Myprysm.PubSub.Abstractions.Publication.Trace'></a>

## Publication.Trace Property

The trace used as a parent. You should not have to provide one as the [IBrokerConnection](Myprysm.PubSub.Abstractions.IBrokerConnection.md 'Myprysm.PubSub.Abstractions.IBrokerConnection') should try to  
obtain the [Myprysm.Tracing.Abstractions.ITracer.CurrentTrace](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITracer.CurrentTrace 'Myprysm.Tracing.Abstractions.ITracer.CurrentTrace') by itself. This can be useful for testing purpose.

```csharp
public Myprysm.Tracing.Abstractions.ITrace? Trace { get; set; }
```

#### Property Value
[Myprysm.Tracing.Abstractions.ITrace](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace 'Myprysm.Tracing.Abstractions.ITrace')