#### [Myprysm.Tracing.Abstractions](index.md 'index')
### [Myprysm.Tracing.Abstractions](index.md#Myprysm.Tracing.Abstractions 'Myprysm.Tracing.Abstractions')

## ITracerFactory Interface

A tracer factory that produces a [ITracer](Myprysm.Tracing.Abstractions.ITracer.md 'Myprysm.Tracing.Abstractions.ITracer') for a [TracerIdentity](Myprysm.Tracing.Abstractions.TracerIdentity.md 'Myprysm.Tracing.Abstractions.TracerIdentity').  
  
Although not required, it may be preferable to cache instances for a given identity.

```csharp
public interface ITracerFactory
```
### Methods

<a name='Myprysm.Tracing.Abstractions.ITracerFactory.GetTracer(Myprysm.Tracing.Abstractions.TracerIdentity)'></a>

## ITracerFactory.GetTracer(TracerIdentity) Method

Gets a tracer for the given identity.

```csharp
Myprysm.Tracing.Abstractions.ITracer GetTracer(Myprysm.Tracing.Abstractions.TracerIdentity identity);
```
#### Parameters

<a name='Myprysm.Tracing.Abstractions.ITracerFactory.GetTracer(Myprysm.Tracing.Abstractions.TracerIdentity).identity'></a>

`identity` [TracerIdentity](Myprysm.Tracing.Abstractions.TracerIdentity.md 'Myprysm.Tracing.Abstractions.TracerIdentity')

The identity of the tracer.

#### Returns
[ITracer](Myprysm.Tracing.Abstractions.ITracer.md 'Myprysm.Tracing.Abstractions.ITracer')  
The tracer for the identity.