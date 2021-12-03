#### [Myprysm.Tracing.Abstractions](index.md 'index')
### [Myprysm.Tracing.Abstractions](index.md#Myprysm_Tracing_Abstractions 'Myprysm.Tracing.Abstractions')
## ITracer Interface
A tracer that can start an application trace and get the current application trace for monitoring.  
```csharp
public interface ITracer
```

Derived  
&#8627; [DefaultTracer](Myprysm_Tracing_Abstractions_DefaultTracer.md 'Myprysm.Tracing.Abstractions.DefaultTracer')  
### Properties
<a name='Myprysm_Tracing_Abstractions_ITracer_CurrentTrace'></a>
## ITracer.CurrentTrace Property
The current application trace at the moment of the request.  
```csharp
Myprysm.Tracing.Abstractions.ITrace? CurrentTrace { get; }
```
#### Property Value
[ITrace](Myprysm_Tracing_Abstractions_ITrace.md 'Myprysm.Tracing.Abstractions.ITrace')
  
<a name='Myprysm_Tracing_Abstractions_ITracer_Identity'></a>
## ITracer.Identity Property
The identity of the tracer.  
```csharp
Myprysm.Tracing.Abstractions.TracerIdentity Identity { get; }
```
#### Property Value
[TracerIdentity](Myprysm_Tracing_Abstractions_TracerIdentity.md 'Myprysm.Tracing.Abstractions.TracerIdentity')
  
### Methods
<a name='Myprysm_Tracing_Abstractions_ITracer_StartTrace(string_Myprysm_Tracing_Abstractions_TraceKind_Myprysm_Tracing_Abstractions_ITrace_)'></a>
## ITracer.StartTrace(string, TraceKind, ITrace?) Method
Start an application trace with the provided name, optional kind and parent.  
```csharp
Myprysm.Tracing.Abstractions.ITrace? StartTrace(string name, Myprysm.Tracing.Abstractions.TraceKind kind=Myprysm.Tracing.Abstractions.TraceKind.Internal, Myprysm.Tracing.Abstractions.ITrace? parent=null);
```
#### Parameters
<a name='Myprysm_Tracing_Abstractions_ITracer_StartTrace(string_Myprysm_Tracing_Abstractions_TraceKind_Myprysm_Tracing_Abstractions_ITrace_)_name'></a>
`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The name of the trace.
  
<a name='Myprysm_Tracing_Abstractions_ITracer_StartTrace(string_Myprysm_Tracing_Abstractions_TraceKind_Myprysm_Tracing_Abstractions_ITrace_)_kind'></a>
`kind` [TraceKind](Myprysm_Tracing_Abstractions_TraceKind.md 'Myprysm.Tracing.Abstractions.TraceKind')  
The optional kind of the trace.
  
<a name='Myprysm_Tracing_Abstractions_ITracer_StartTrace(string_Myprysm_Tracing_Abstractions_TraceKind_Myprysm_Tracing_Abstractions_ITrace_)_parent'></a>
`parent` [ITrace](Myprysm_Tracing_Abstractions_ITrace.md 'Myprysm.Tracing.Abstractions.ITrace')  
The optional parent of the trace.
  
#### Returns
[ITrace](Myprysm_Tracing_Abstractions_ITrace.md 'Myprysm.Tracing.Abstractions.ITrace')  
### Remarks
When a parent is not provided,  
the tracer implementation should try to determine the appropriate parent by itself.  
  
