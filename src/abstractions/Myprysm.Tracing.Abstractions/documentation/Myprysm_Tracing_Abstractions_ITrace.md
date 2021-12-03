#### [Myprysm.Tracing.Abstractions](index.md 'index')
### [Myprysm.Tracing.Abstractions](index.md#Myprysm_Tracing_Abstractions 'Myprysm.Tracing.Abstractions')
## ITrace Interface
An application trace for telemetry.  
```csharp
public interface ITrace :
System.IDisposable
```

Implements [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')  
### Properties
<a name='Myprysm_Tracing_Abstractions_ITrace_Baggage'></a>
## ITrace.Baggage Property
Gets a readonly view of the trace baggage.  
```csharp
System.Collections.Generic.IReadOnlyDictionary<string,string?> Baggage { get; }
```
#### Property Value
[System.Collections.Generic.IReadOnlyDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2 'System.Collections.Generic.IReadOnlyDictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2 'System.Collections.Generic.IReadOnlyDictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2 'System.Collections.Generic.IReadOnlyDictionary`2')
  
<a name='Myprysm_Tracing_Abstractions_ITrace_Id'></a>
## ITrace.Id Property
Gets the trace identifier.  
```csharp
string Id { get; }
```
#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
  
<a name='Myprysm_Tracing_Abstractions_ITrace_Name'></a>
## ITrace.Name Property
Gets the trace name.   
```csharp
string Name { get; }
```
#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
  
<a name='Myprysm_Tracing_Abstractions_ITrace_ParentId'></a>
## ITrace.ParentId Property
Gets the trace parent identifier.  
```csharp
string? ParentId { get; }
```
#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
  
<a name='Myprysm_Tracing_Abstractions_ITrace_Tags'></a>
## ITrace.Tags Property
Gets a readonly view of the trace tags.  
```csharp
System.Collections.Generic.IReadOnlyDictionary<string,string?> Tags { get; }
```
#### Property Value
[System.Collections.Generic.IReadOnlyDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2 'System.Collections.Generic.IReadOnlyDictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2 'System.Collections.Generic.IReadOnlyDictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2 'System.Collections.Generic.IReadOnlyDictionary`2')
  
### Methods
<a name='Myprysm_Tracing_Abstractions_ITrace_AddBaggage(string_string_)'></a>
## ITrace.AddBaggage(string, string?) Method
Adds a baggage item with a key and a value to this trace.  
```csharp
void AddBaggage(string key, string? value);
```
#### Parameters
<a name='Myprysm_Tracing_Abstractions_ITrace_AddBaggage(string_string_)_key'></a>
`key` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The baggage key.
  
<a name='Myprysm_Tracing_Abstractions_ITrace_AddBaggage(string_string_)_value'></a>
`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The baggage value.
  
  
<a name='Myprysm_Tracing_Abstractions_ITrace_AddTag(string_string_)'></a>
## ITrace.AddTag(string, string?) Method
Adds a tag item with a key and a value to this trace.  
```csharp
void AddTag(string key, string? value);
```
#### Parameters
<a name='Myprysm_Tracing_Abstractions_ITrace_AddTag(string_string_)_key'></a>
`key` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The tag key.
  
<a name='Myprysm_Tracing_Abstractions_ITrace_AddTag(string_string_)_value'></a>
`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The tag value.
  
  
<a name='Myprysm_Tracing_Abstractions_ITrace_CreateChild(string_Myprysm_Tracing_Abstractions_TraceKind)'></a>
## ITrace.CreateChild(string, TraceKind) Method
Creates a child trace with this trace as parent and the given kind.  
```csharp
Myprysm.Tracing.Abstractions.ITrace? CreateChild(string name, Myprysm.Tracing.Abstractions.TraceKind kind=Myprysm.Tracing.Abstractions.TraceKind.Internal);
```
#### Parameters
<a name='Myprysm_Tracing_Abstractions_ITrace_CreateChild(string_Myprysm_Tracing_Abstractions_TraceKind)_name'></a>
`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The name of the child trace.
  
<a name='Myprysm_Tracing_Abstractions_ITrace_CreateChild(string_Myprysm_Tracing_Abstractions_TraceKind)_kind'></a>
`kind` [TraceKind](Myprysm_Tracing_Abstractions_TraceKind.md 'Myprysm.Tracing.Abstractions.TraceKind')  
The kind of the child trace.
  
#### Returns
[ITrace](Myprysm_Tracing_Abstractions_ITrace.md 'Myprysm.Tracing.Abstractions.ITrace')  
  
<a name='Myprysm_Tracing_Abstractions_ITrace_SetParent(Myprysm_Tracing_Abstractions_ITrace)'></a>
## ITrace.SetParent(ITrace) Method
Sets the parent trace.  
```csharp
void SetParent(Myprysm.Tracing.Abstractions.ITrace parent);
```
#### Parameters
<a name='Myprysm_Tracing_Abstractions_ITrace_SetParent(Myprysm_Tracing_Abstractions_ITrace)_parent'></a>
`parent` [ITrace](Myprysm_Tracing_Abstractions_ITrace.md 'Myprysm.Tracing.Abstractions.ITrace')  
The parent trace.
  
#### Exceptions
[Myprysm.SharedKernel.Exceptions.IllegalOperationException](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.SharedKernel.Exceptions.IllegalOperationException 'Myprysm.SharedKernel.Exceptions.IllegalOperationException')  
When the trace already has a parent.
  
<a name='Myprysm_Tracing_Abstractions_ITrace_SetParentId(string)'></a>
## ITrace.SetParentId(string) Method
Sets the parent trace id.  
```csharp
void SetParentId(string parentId);
```
#### Parameters
<a name='Myprysm_Tracing_Abstractions_ITrace_SetParentId(string)_parentId'></a>
`parentId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The parent trace id.
  
#### Exceptions
[Myprysm.SharedKernel.Exceptions.IllegalOperationException](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.SharedKernel.Exceptions.IllegalOperationException 'Myprysm.SharedKernel.Exceptions.IllegalOperationException')  
When the trace already has a parent.
  
