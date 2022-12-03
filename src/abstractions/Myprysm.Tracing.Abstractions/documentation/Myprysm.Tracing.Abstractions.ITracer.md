#### [Myprysm.Tracing.Abstractions](index.md 'index')
### [Myprysm.Tracing.Abstractions](index.md#Myprysm.Tracing.Abstractions 'Myprysm.Tracing.Abstractions')

## ITracer Interface

A tracer that can start an application trace and get the current application trace for monitoring.

```csharp
public interface ITracer
```

Derived  
&#8627; [DefaultTracer](Myprysm.Tracing.Abstractions.DefaultTracer.md 'Myprysm.Tracing.Abstractions.DefaultTracer')
### Properties

<a name='Myprysm.Tracing.Abstractions.ITracer.CurrentTrace'></a>

## ITracer.CurrentTrace Property

The current application trace at the moment of the request.

```csharp
Myprysm.Tracing.Abstractions.ITrace? CurrentTrace { get; }
```

#### Property Value
[ITrace](Myprysm.Tracing.Abstractions.ITrace.md 'Myprysm.Tracing.Abstractions.ITrace')

<a name='Myprysm.Tracing.Abstractions.ITracer.Identity'></a>

## ITracer.Identity Property

The identity of the tracer.

```csharp
Myprysm.Tracing.Abstractions.TracerIdentity Identity { get; }
```

#### Property Value
[TracerIdentity](Myprysm.Tracing.Abstractions.TracerIdentity.md 'Myprysm.Tracing.Abstractions.TracerIdentity')
### Methods

<a name='Myprysm.Tracing.Abstractions.ITracer.StartTrace(string,Myprysm.Tracing.Abstractions.TraceKind,Myprysm.Tracing.Abstractions.ITrace)'></a>

## ITracer.StartTrace(string, TraceKind, ITrace) Method

Start an application trace with the provided name, optional kind and parent.

```csharp
Myprysm.Tracing.Abstractions.ITrace? StartTrace(string name, Myprysm.Tracing.Abstractions.TraceKind kind=Myprysm.Tracing.Abstractions.TraceKind.Internal, Myprysm.Tracing.Abstractions.ITrace? parent=null);
```
#### Parameters

<a name='Myprysm.Tracing.Abstractions.ITracer.StartTrace(string,Myprysm.Tracing.Abstractions.TraceKind,Myprysm.Tracing.Abstractions.ITrace).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the trace.

<a name='Myprysm.Tracing.Abstractions.ITracer.StartTrace(string,Myprysm.Tracing.Abstractions.TraceKind,Myprysm.Tracing.Abstractions.ITrace).kind'></a>

`kind` [TraceKind](Myprysm.Tracing.Abstractions.TraceKind.md 'Myprysm.Tracing.Abstractions.TraceKind')

The optional kind of the trace.

<a name='Myprysm.Tracing.Abstractions.ITracer.StartTrace(string,Myprysm.Tracing.Abstractions.TraceKind,Myprysm.Tracing.Abstractions.ITrace).parent'></a>

`parent` [ITrace](Myprysm.Tracing.Abstractions.ITrace.md 'Myprysm.Tracing.Abstractions.ITrace')

The optional parent of the trace.

#### Returns
[ITrace](Myprysm.Tracing.Abstractions.ITrace.md 'Myprysm.Tracing.Abstractions.ITrace')

### Remarks
When a parent is not provided,  
the tracer implementation should try to determine the appropriate parent by itself.