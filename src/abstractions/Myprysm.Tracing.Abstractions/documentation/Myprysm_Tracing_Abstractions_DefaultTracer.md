#### [Myprysm.Tracing.Abstractions](index.md 'index')
### [Myprysm.Tracing.Abstractions](index.md#Myprysm_Tracing_Abstractions 'Myprysm.Tracing.Abstractions')
## DefaultTracer Class
Default tracer implementation with minimal operations.  
Useful for testing or when no real [ITracerFactory](Myprysm_Tracing_Abstractions_ITracerFactory.md 'Myprysm.Tracing.Abstractions.ITracerFactory') is provided.  
```csharp
public class DefaultTracer :
Myprysm.Tracing.Abstractions.ITracer
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DefaultTracer  

Implements [ITracer](Myprysm_Tracing_Abstractions_ITracer.md 'Myprysm.Tracing.Abstractions.ITracer')  
### Constructors
<a name='Myprysm_Tracing_Abstractions_DefaultTracer_DefaultTracer(Myprysm_Tracing_Abstractions_TracerIdentity)'></a>
## DefaultTracer.DefaultTracer(TracerIdentity) Constructor
Creates a new [DefaultTracer](Myprysm_Tracing_Abstractions_DefaultTracer.md 'Myprysm.Tracing.Abstractions.DefaultTracer') with the given identity.  
```csharp
public DefaultTracer(Myprysm.Tracing.Abstractions.TracerIdentity identity);
```
#### Parameters
<a name='Myprysm_Tracing_Abstractions_DefaultTracer_DefaultTracer(Myprysm_Tracing_Abstractions_TracerIdentity)_identity'></a>
`identity` [TracerIdentity](Myprysm_Tracing_Abstractions_TracerIdentity.md 'Myprysm.Tracing.Abstractions.TracerIdentity')  
The tracer identity.
  
  
### Properties
<a name='Myprysm_Tracing_Abstractions_DefaultTracer_CurrentTrace'></a>
## DefaultTracer.CurrentTrace Property
The current application trace at the moment of the request.  
```csharp
public Myprysm.Tracing.Abstractions.ITrace? CurrentTrace { get; }
```
#### Property Value
[ITrace](Myprysm_Tracing_Abstractions_ITrace.md 'Myprysm.Tracing.Abstractions.ITrace')

Implements [CurrentTrace](Myprysm_Tracing_Abstractions_ITracer.md#Myprysm_Tracing_Abstractions_ITracer_CurrentTrace 'Myprysm.Tracing.Abstractions.ITracer.CurrentTrace')  
  
<a name='Myprysm_Tracing_Abstractions_DefaultTracer_Identity'></a>
## DefaultTracer.Identity Property
The identity of the tracer.  
```csharp
public Myprysm.Tracing.Abstractions.TracerIdentity Identity { get; }
```
#### Property Value
[TracerIdentity](Myprysm_Tracing_Abstractions_TracerIdentity.md 'Myprysm.Tracing.Abstractions.TracerIdentity')

Implements [Identity](Myprysm_Tracing_Abstractions_ITracer.md#Myprysm_Tracing_Abstractions_ITracer_Identity 'Myprysm.Tracing.Abstractions.ITracer.Identity')  
  
### Methods
<a name='Myprysm_Tracing_Abstractions_DefaultTracer_StartTrace(string_Myprysm_Tracing_Abstractions_TraceKind_Myprysm_Tracing_Abstractions_ITrace_)'></a>
## DefaultTracer.StartTrace(string, TraceKind, ITrace?) Method
Start an application trace with the provided name, optional kind and parent.  
```csharp
public Myprysm.Tracing.Abstractions.ITrace StartTrace(string name, Myprysm.Tracing.Abstractions.TraceKind kind=Myprysm.Tracing.Abstractions.TraceKind.Internal, Myprysm.Tracing.Abstractions.ITrace? parent=null);
```
#### Parameters
<a name='Myprysm_Tracing_Abstractions_DefaultTracer_StartTrace(string_Myprysm_Tracing_Abstractions_TraceKind_Myprysm_Tracing_Abstractions_ITrace_)_name'></a>
`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The name of the trace.
  
<a name='Myprysm_Tracing_Abstractions_DefaultTracer_StartTrace(string_Myprysm_Tracing_Abstractions_TraceKind_Myprysm_Tracing_Abstractions_ITrace_)_kind'></a>
`kind` [TraceKind](Myprysm_Tracing_Abstractions_TraceKind.md 'Myprysm.Tracing.Abstractions.TraceKind')  
The optional kind of the trace.
  
<a name='Myprysm_Tracing_Abstractions_DefaultTracer_StartTrace(string_Myprysm_Tracing_Abstractions_TraceKind_Myprysm_Tracing_Abstractions_ITrace_)_parent'></a>
`parent` [ITrace](Myprysm_Tracing_Abstractions_ITrace.md 'Myprysm.Tracing.Abstractions.ITrace')  
The optional parent of the trace.
  
#### Returns
[ITrace](Myprysm_Tracing_Abstractions_ITrace.md 'Myprysm.Tracing.Abstractions.ITrace')  

Implements [StartTrace(string, TraceKind, ITrace?)](Myprysm_Tracing_Abstractions_ITracer.md#Myprysm_Tracing_Abstractions_ITracer_StartTrace(string_Myprysm_Tracing_Abstractions_TraceKind_Myprysm_Tracing_Abstractions_ITrace_) 'Myprysm.Tracing.Abstractions.ITracer.StartTrace(string, Myprysm.Tracing.Abstractions.TraceKind, Myprysm.Tracing.Abstractions.ITrace?)')  
### Remarks
When a parent is not provided,  
the tracer implementation should try to determine the appropriate parent by itself.  
  
