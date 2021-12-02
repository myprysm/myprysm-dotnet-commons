#### [Myprysm.Tracing.Abstractions](index.md 'index')
### [Myprysm.Tracing.Abstractions](index.md#Myprysm_Tracing_Abstractions 'Myprysm.Tracing.Abstractions')
## ITracerFactory Interface
A tracer factory that produces a [ITracer](Myprysm_Tracing_Abstractions_ITracer.md 'Myprysm.Tracing.Abstractions.ITracer') for a [TracerIdentity](Myprysm_Tracing_Abstractions_TracerIdentity.md 'Myprysm.Tracing.Abstractions.TracerIdentity').  
  
Although not required, it may be preferable to cache instances for a given identity.  
```csharp
public interface ITracerFactory
```
### Methods
<a name='Myprysm_Tracing_Abstractions_ITracerFactory_GetTracer(Myprysm_Tracing_Abstractions_TracerIdentity)'></a>
## ITracerFactory.GetTracer(TracerIdentity) Method
Gets a tracer for the given identity.  
```csharp
Myprysm.Tracing.Abstractions.ITracer GetTracer(Myprysm.Tracing.Abstractions.TracerIdentity identity);
```
#### Parameters
<a name='Myprysm_Tracing_Abstractions_ITracerFactory_GetTracer(Myprysm_Tracing_Abstractions_TracerIdentity)_identity'></a>
`identity` [TracerIdentity](Myprysm_Tracing_Abstractions_TracerIdentity.md 'Myprysm.Tracing.Abstractions.TracerIdentity')  
The identity of the tracer.
  
#### Returns
[ITracer](Myprysm_Tracing_Abstractions_ITracer.md 'Myprysm.Tracing.Abstractions.ITracer')  
The tracer for the identity.
  
