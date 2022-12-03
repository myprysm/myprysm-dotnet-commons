#### [Myprysm.PubSub.Abstractions](index.md 'index')
### [Myprysm.PubSub.Abstractions](index.md#Myprysm.PubSub.Abstractions 'Myprysm.PubSub.Abstractions')

## SerializedTrace Class

Represents a trace that has been serialized and transmitted from an original publication.

```csharp
public sealed class SerializedTrace :
Myprysm.Tracing.Abstractions.ITrace,
System.IDisposable,
System.IEquatable<Myprysm.PubSub.Abstractions.SerializedTrace>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SerializedTrace

Implements [Myprysm.Tracing.Abstractions.ITrace](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace 'Myprysm.Tracing.Abstractions.ITrace'), [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[SerializedTrace](Myprysm.PubSub.Abstractions.SerializedTrace.md 'Myprysm.PubSub.Abstractions.SerializedTrace')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

### Remarks
This trace should only be used in [ISubscription](Myprysm.PubSub.Abstractions.ISubscription.md 'Myprysm.PubSub.Abstractions.ISubscription') to initiate the consumer trace.
### Constructors

<a name='Myprysm.PubSub.Abstractions.SerializedTrace.SerializedTrace(string,string,System.Collections.Generic.IReadOnlyDictionary_string,string_)'></a>

## SerializedTrace(string, string, IReadOnlyDictionary<string,string>) Constructor

Creates a new [SerializedTrace](Myprysm.PubSub.Abstractions.SerializedTrace.md 'Myprysm.PubSub.Abstractions.SerializedTrace').

```csharp
public SerializedTrace(string? parentId, string id, System.Collections.Generic.IReadOnlyDictionary<string,string?>? baggage);
```
#### Parameters

<a name='Myprysm.PubSub.Abstractions.SerializedTrace.SerializedTrace(string,string,System.Collections.Generic.IReadOnlyDictionary_string,string_).parentId'></a>

`parentId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The optional parent id of the original trace.

<a name='Myprysm.PubSub.Abstractions.SerializedTrace.SerializedTrace(string,string,System.Collections.Generic.IReadOnlyDictionary_string,string_).id'></a>

`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The id of the original trace.

<a name='Myprysm.PubSub.Abstractions.SerializedTrace.SerializedTrace(string,string,System.Collections.Generic.IReadOnlyDictionary_string,string_).baggage'></a>

`baggage` [System.Collections.Generic.IReadOnlyDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2 'System.Collections.Generic.IReadOnlyDictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2 'System.Collections.Generic.IReadOnlyDictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2 'System.Collections.Generic.IReadOnlyDictionary`2')

The optional baggage of the original trace.
### Properties

<a name='Myprysm.PubSub.Abstractions.SerializedTrace.Baggage'></a>

## SerializedTrace.Baggage Property

Gets a readonly view of the trace baggage.

```csharp
public System.Collections.Generic.IReadOnlyDictionary<string,string?> Baggage { get; }
```

Implements [Baggage](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace.Baggage 'Myprysm.Tracing.Abstractions.ITrace.Baggage')

#### Property Value
[System.Collections.Generic.IReadOnlyDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2 'System.Collections.Generic.IReadOnlyDictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2 'System.Collections.Generic.IReadOnlyDictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2 'System.Collections.Generic.IReadOnlyDictionary`2')

<a name='Myprysm.PubSub.Abstractions.SerializedTrace.Id'></a>

## SerializedTrace.Id Property

Gets the trace identifier.

```csharp
public string Id { get; }
```

Implements [Id](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace.Id 'Myprysm.Tracing.Abstractions.ITrace.Id')

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='Myprysm.PubSub.Abstractions.SerializedTrace.Name'></a>

## SerializedTrace.Name Property

Gets the trace name.

```csharp
public string Name { get; }
```

Implements [Name](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace.Name 'Myprysm.Tracing.Abstractions.ITrace.Name')

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='Myprysm.PubSub.Abstractions.SerializedTrace.ParentId'></a>

## SerializedTrace.ParentId Property

Gets the trace parent identifier.

```csharp
public string? ParentId { get; }
```

Implements [ParentId](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace.ParentId 'Myprysm.Tracing.Abstractions.ITrace.ParentId')

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='Myprysm.PubSub.Abstractions.SerializedTrace.Tags'></a>

## SerializedTrace.Tags Property

Gets a readonly view of the trace tags.

```csharp
public System.Collections.Generic.IReadOnlyDictionary<string,string?> Tags { get; }
```

Implements [Tags](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace.Tags 'Myprysm.Tracing.Abstractions.ITrace.Tags')

#### Property Value
[System.Collections.Generic.IReadOnlyDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2 'System.Collections.Generic.IReadOnlyDictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2 'System.Collections.Generic.IReadOnlyDictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2 'System.Collections.Generic.IReadOnlyDictionary`2')
### Methods

<a name='Myprysm.PubSub.Abstractions.SerializedTrace.AddBaggage(string,string)'></a>

## SerializedTrace.AddBaggage(string, string) Method

Adds a baggage item with a key and a value to this trace.

```csharp
public void AddBaggage(string key, string? value);
```
#### Parameters

<a name='Myprysm.PubSub.Abstractions.SerializedTrace.AddBaggage(string,string).key'></a>

`key` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The baggage key.

<a name='Myprysm.PubSub.Abstractions.SerializedTrace.AddBaggage(string,string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The baggage value.

Implements [AddBaggage(string, string)](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace.AddBaggage#Myprysm_Tracing_Abstractions_ITrace_AddBaggage_System_String,System_String_ 'Myprysm.Tracing.Abstractions.ITrace.AddBaggage(System.String,System.String)')

<a name='Myprysm.PubSub.Abstractions.SerializedTrace.AddTag(string,string)'></a>

## SerializedTrace.AddTag(string, string) Method

Adds a tag item with a key and a value to this trace.

```csharp
public void AddTag(string key, string? value);
```
#### Parameters

<a name='Myprysm.PubSub.Abstractions.SerializedTrace.AddTag(string,string).key'></a>

`key` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The tag key.

<a name='Myprysm.PubSub.Abstractions.SerializedTrace.AddTag(string,string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The tag value.

Implements [AddTag(string, string)](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace.AddTag#Myprysm_Tracing_Abstractions_ITrace_AddTag_System_String,System_String_ 'Myprysm.Tracing.Abstractions.ITrace.AddTag(System.String,System.String)')

<a name='Myprysm.PubSub.Abstractions.SerializedTrace.CreateChild(string,Myprysm.Tracing.Abstractions.TraceKind)'></a>

## SerializedTrace.CreateChild(string, TraceKind) Method

Creates a child trace with this trace as parent and the given kind.

```csharp
public Myprysm.Tracing.Abstractions.ITrace CreateChild(string name, Myprysm.Tracing.Abstractions.TraceKind kind=Myprysm.Tracing.Abstractions.TraceKind.Internal);
```
#### Parameters

<a name='Myprysm.PubSub.Abstractions.SerializedTrace.CreateChild(string,Myprysm.Tracing.Abstractions.TraceKind).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the child trace.

<a name='Myprysm.PubSub.Abstractions.SerializedTrace.CreateChild(string,Myprysm.Tracing.Abstractions.TraceKind).kind'></a>

`kind` [Myprysm.Tracing.Abstractions.TraceKind](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.TraceKind 'Myprysm.Tracing.Abstractions.TraceKind')

The kind of the child trace.

Implements [CreateChild(string, TraceKind)](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace.CreateChild#Myprysm_Tracing_Abstractions_ITrace_CreateChild_System_String,Myprysm_Tracing_Abstractions_TraceKind_ 'Myprysm.Tracing.Abstractions.ITrace.CreateChild(System.String,Myprysm.Tracing.Abstractions.TraceKind)')

#### Returns
[Myprysm.Tracing.Abstractions.ITrace](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace 'Myprysm.Tracing.Abstractions.ITrace')

<a name='Myprysm.PubSub.Abstractions.SerializedTrace.Dispose()'></a>

## SerializedTrace.Dispose() Method

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose();
```

Implements [Dispose()](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable.Dispose 'System.IDisposable.Dispose')

<a name='Myprysm.PubSub.Abstractions.SerializedTrace.GetSerializedTrace(Myprysm.Tracing.Abstractions.ITrace)'></a>

## SerializedTrace.GetSerializedTrace(ITrace) Method

Create a serialized trace that can be sent over the wire from a given [Myprysm.Tracing.Abstractions.ITrace](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace 'Myprysm.Tracing.Abstractions.ITrace').

```csharp
public static Myprysm.PubSub.Abstractions.SerializedTrace? GetSerializedTrace(Myprysm.Tracing.Abstractions.ITrace? trace);
```
#### Parameters

<a name='Myprysm.PubSub.Abstractions.SerializedTrace.GetSerializedTrace(Myprysm.Tracing.Abstractions.ITrace).trace'></a>

`trace` [Myprysm.Tracing.Abstractions.ITrace](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace 'Myprysm.Tracing.Abstractions.ITrace')

The trace to convert.

#### Returns
[SerializedTrace](Myprysm.PubSub.Abstractions.SerializedTrace.md 'Myprysm.PubSub.Abstractions.SerializedTrace')

<a name='Myprysm.PubSub.Abstractions.SerializedTrace.SetParentId(string)'></a>

## SerializedTrace.SetParentId(string) Method

Sets the parent trace id.

```csharp
public void SetParentId(string parentId);
```
#### Parameters

<a name='Myprysm.PubSub.Abstractions.SerializedTrace.SetParentId(string).parentId'></a>

`parentId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The parent trace id.

Implements [SetParentId(string)](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace.SetParentId#Myprysm_Tracing_Abstractions_ITrace_SetParentId_System_String_ 'Myprysm.Tracing.Abstractions.ITrace.SetParentId(System.String)')

#### Exceptions

[Myprysm.SharedKernel.Exceptions.IllegalOperationException](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.SharedKernel.Exceptions.IllegalOperationException 'Myprysm.SharedKernel.Exceptions.IllegalOperationException')  
When the trace already has a parent.