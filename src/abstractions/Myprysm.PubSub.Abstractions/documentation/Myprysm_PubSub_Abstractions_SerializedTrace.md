#### [Myprysm.PubSub.Abstractions](index.md 'index')
### [Myprysm.PubSub.Abstractions](index.md#Myprysm_PubSub_Abstractions 'Myprysm.PubSub.Abstractions')
## SerializedTrace Class
Represents a trace that has been serialized and transmitted from an original publication.  
```csharp
public sealed class SerializedTrace :
Myprysm.Tracing.Abstractions.ITrace,
System.IDisposable,
System.IEquatable<Myprysm.PubSub.Abstractions.SerializedTrace>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SerializedTrace  

Implements [Myprysm.Tracing.Abstractions.ITrace](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace 'Myprysm.Tracing.Abstractions.ITrace'), [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable'), [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[SerializedTrace](Myprysm_PubSub_Abstractions_SerializedTrace.md 'Myprysm.PubSub.Abstractions.SerializedTrace')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')  
### Remarks
This trace should only be used in [ISubscription](Myprysm_PubSub_Abstractions_ISubscription.md 'Myprysm.PubSub.Abstractions.ISubscription') to initiate the consumer trace.  
### Constructors
<a name='Myprysm_PubSub_Abstractions_SerializedTrace_SerializedTrace(string__string_System_Collections_Generic_Dictionary_string_string___)'></a>
## SerializedTrace.SerializedTrace(string?, string, Dictionary&lt;string,string?&gt;?) Constructor
Creates a new [SerializedTrace](Myprysm_PubSub_Abstractions_SerializedTrace.md 'Myprysm.PubSub.Abstractions.SerializedTrace').  
```csharp
public SerializedTrace(string? parentId, string id, System.Collections.Generic.Dictionary<string,string?>? baggage);
```
#### Parameters
<a name='Myprysm_PubSub_Abstractions_SerializedTrace_SerializedTrace(string__string_System_Collections_Generic_Dictionary_string_string___)_parentId'></a>
`parentId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The optional parent id of the original trace.
  
<a name='Myprysm_PubSub_Abstractions_SerializedTrace_SerializedTrace(string__string_System_Collections_Generic_Dictionary_string_string___)_id'></a>
`id` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The id of the original trace.
  
<a name='Myprysm_PubSub_Abstractions_SerializedTrace_SerializedTrace(string__string_System_Collections_Generic_Dictionary_string_string___)_baggage'></a>
`baggage` [System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')  
The optional baggage of the original trace.
  
  
### Properties
<a name='Myprysm_PubSub_Abstractions_SerializedTrace_Baggage'></a>
## SerializedTrace.Baggage Property
Gets a readonly view of the trace baggage.  
```csharp
public System.Collections.Generic.IReadOnlyDictionary<string,string?> Baggage { get; }
```
#### Property Value
[System.Collections.Generic.IReadOnlyDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2 'System.Collections.Generic.IReadOnlyDictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2 'System.Collections.Generic.IReadOnlyDictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2 'System.Collections.Generic.IReadOnlyDictionary`2')

Implements [Baggage](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace.Baggage 'Myprysm.Tracing.Abstractions.ITrace.Baggage')  
  
<a name='Myprysm_PubSub_Abstractions_SerializedTrace_Id'></a>
## SerializedTrace.Id Property
Gets the trace identifier.  
```csharp
public string Id { get; }
```
#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Implements [Id](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace.Id 'Myprysm.Tracing.Abstractions.ITrace.Id')  
  
<a name='Myprysm_PubSub_Abstractions_SerializedTrace_Name'></a>
## SerializedTrace.Name Property
Gets the trace name.   
```csharp
public string Name { get; }
```
#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Implements [Name](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace.Name 'Myprysm.Tracing.Abstractions.ITrace.Name')  
  
<a name='Myprysm_PubSub_Abstractions_SerializedTrace_ParentId'></a>
## SerializedTrace.ParentId Property
Gets the trace parent identifier.  
```csharp
public string? ParentId { get; }
```
#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Implements [ParentId](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace.ParentId 'Myprysm.Tracing.Abstractions.ITrace.ParentId')  
  
<a name='Myprysm_PubSub_Abstractions_SerializedTrace_Tags'></a>
## SerializedTrace.Tags Property
Gets a readonly view of the trace tags.  
```csharp
public System.Collections.Generic.IReadOnlyDictionary<string,string?> Tags { get; }
```
#### Property Value
[System.Collections.Generic.IReadOnlyDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2 'System.Collections.Generic.IReadOnlyDictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2 'System.Collections.Generic.IReadOnlyDictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2 'System.Collections.Generic.IReadOnlyDictionary`2')

Implements [Tags](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace.Tags 'Myprysm.Tracing.Abstractions.ITrace.Tags')  
  
### Methods
<a name='Myprysm_PubSub_Abstractions_SerializedTrace_AddBaggage(string_string_)'></a>
## SerializedTrace.AddBaggage(string, string?) Method
Adds a baggage item with a key and a value to this trace.  
```csharp
public void AddBaggage(string key, string? value);
```
#### Parameters
<a name='Myprysm_PubSub_Abstractions_SerializedTrace_AddBaggage(string_string_)_key'></a>
`key` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The baggage key.
  
<a name='Myprysm_PubSub_Abstractions_SerializedTrace_AddBaggage(string_string_)_value'></a>
`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The baggage value.
  

Implements [AddBaggage(string, string?)](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace.AddBaggage#Myprysm_Tracing_Abstractions_ITrace_AddBaggage_System_String,System_String_ 'Myprysm.Tracing.Abstractions.ITrace.AddBaggage(System.String,System.String)')  
  
<a name='Myprysm_PubSub_Abstractions_SerializedTrace_AddTag(string_string_)'></a>
## SerializedTrace.AddTag(string, string?) Method
Adds a tag item with a key and a value to this trace.  
```csharp
public void AddTag(string key, string? value);
```
#### Parameters
<a name='Myprysm_PubSub_Abstractions_SerializedTrace_AddTag(string_string_)_key'></a>
`key` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The tag key.
  
<a name='Myprysm_PubSub_Abstractions_SerializedTrace_AddTag(string_string_)_value'></a>
`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The tag value.
  

Implements [AddTag(string, string?)](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace.AddTag#Myprysm_Tracing_Abstractions_ITrace_AddTag_System_String,System_String_ 'Myprysm.Tracing.Abstractions.ITrace.AddTag(System.String,System.String)')  
  
<a name='Myprysm_PubSub_Abstractions_SerializedTrace_CreateChild(string_Myprysm_Tracing_Abstractions_TraceKind)'></a>
## SerializedTrace.CreateChild(string, TraceKind) Method
Creates a child trace with this trace as parent and the given kind.  
```csharp
public Myprysm.Tracing.Abstractions.ITrace CreateChild(string name, Myprysm.Tracing.Abstractions.TraceKind kind=Myprysm.Tracing.Abstractions.TraceKind.Internal);
```
#### Parameters
<a name='Myprysm_PubSub_Abstractions_SerializedTrace_CreateChild(string_Myprysm_Tracing_Abstractions_TraceKind)_name'></a>
`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The name of the child trace.
  
<a name='Myprysm_PubSub_Abstractions_SerializedTrace_CreateChild(string_Myprysm_Tracing_Abstractions_TraceKind)_kind'></a>
`kind` [Myprysm.Tracing.Abstractions.TraceKind](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.TraceKind 'Myprysm.Tracing.Abstractions.TraceKind')  
The kind of the child trace.
  
#### Returns
[Myprysm.Tracing.Abstractions.ITrace](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace 'Myprysm.Tracing.Abstractions.ITrace')  

Implements [CreateChild(string, TraceKind)](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace.CreateChild#Myprysm_Tracing_Abstractions_ITrace_CreateChild_System_String,Myprysm_Tracing_Abstractions_TraceKind_ 'Myprysm.Tracing.Abstractions.ITrace.CreateChild(System.String,Myprysm.Tracing.Abstractions.TraceKind)')  
  
<a name='Myprysm_PubSub_Abstractions_SerializedTrace_Dispose()'></a>
## SerializedTrace.Dispose() Method
Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
```csharp
public void Dispose();
```

Implements [Dispose()](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable.Dispose 'System.IDisposable.Dispose')  
  
<a name='Myprysm_PubSub_Abstractions_SerializedTrace_GetSerializedTrace(Myprysm_Tracing_Abstractions_ITrace_)'></a>
## SerializedTrace.GetSerializedTrace(ITrace?) Method
Create a serialized trace that can be sent over the wire from a given [Myprysm.Tracing.Abstractions.ITrace](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace 'Myprysm.Tracing.Abstractions.ITrace').  
```csharp
public static Myprysm.PubSub.Abstractions.SerializedTrace? GetSerializedTrace(Myprysm.Tracing.Abstractions.ITrace? trace);
```
#### Parameters
<a name='Myprysm_PubSub_Abstractions_SerializedTrace_GetSerializedTrace(Myprysm_Tracing_Abstractions_ITrace_)_trace'></a>
`trace` [Myprysm.Tracing.Abstractions.ITrace](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace 'Myprysm.Tracing.Abstractions.ITrace')  
The trace to convert.
  
#### Returns
[SerializedTrace](Myprysm_PubSub_Abstractions_SerializedTrace.md 'Myprysm.PubSub.Abstractions.SerializedTrace')  
  
<a name='Myprysm_PubSub_Abstractions_SerializedTrace_SetParentId(string)'></a>
## SerializedTrace.SetParentId(string) Method
Sets the parent trace id.  
```csharp
public void SetParentId(string parentId);
```
#### Parameters
<a name='Myprysm_PubSub_Abstractions_SerializedTrace_SetParentId(string)_parentId'></a>
`parentId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The parent trace id.
  
#### Exceptions
[Myprysm.SharedKernel.Exceptions.IllegalOperationException](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.SharedKernel.Exceptions.IllegalOperationException 'Myprysm.SharedKernel.Exceptions.IllegalOperationException')  
When the trace already has a parent.

Implements [SetParentId(string)](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace.SetParentId#Myprysm_Tracing_Abstractions_ITrace_SetParentId_System_String_ 'Myprysm.Tracing.Abstractions.ITrace.SetParentId(System.String)')  
  
