#### [Myprysm.Tracing.Abstractions](index.md 'index')
### [Myprysm.Tracing.Abstractions](index.md#Myprysm.Tracing.Abstractions 'Myprysm.Tracing.Abstractions')

## DefaultTracer Class

Default tracer implementation with minimal operations.  
Useful for testing or when no real [ITracerFactory](Myprysm.Tracing.Abstractions.ITracerFactory.md 'Myprysm.Tracing.Abstractions.ITracerFactory') is provided.

```csharp
public class DefaultTracer :
Myprysm.Tracing.Abstractions.ITracer
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DefaultTracer

Implements [ITracer](Myprysm.Tracing.Abstractions.ITracer.md 'Myprysm.Tracing.Abstractions.ITracer')
### Constructors

<a name='Myprysm.Tracing.Abstractions.DefaultTracer.DefaultTracer(Myprysm.Tracing.Abstractions.TracerIdentity)'></a>

## DefaultTracer(TracerIdentity) Constructor

Creates a new [DefaultTracer](Myprysm.Tracing.Abstractions.DefaultTracer.md 'Myprysm.Tracing.Abstractions.DefaultTracer') with the given identity.

```csharp
public DefaultTracer(Myprysm.Tracing.Abstractions.TracerIdentity identity);
```
#### Parameters

<a name='Myprysm.Tracing.Abstractions.DefaultTracer.DefaultTracer(Myprysm.Tracing.Abstractions.TracerIdentity).identity'></a>

`identity` [TracerIdentity](Myprysm.Tracing.Abstractions.TracerIdentity.md 'Myprysm.Tracing.Abstractions.TracerIdentity')

The tracer identity.
### Properties

<a name='Myprysm.Tracing.Abstractions.DefaultTracer.CurrentTrace'></a>

## DefaultTracer.CurrentTrace Property

The current application trace at the moment of the request.

```csharp
public Myprysm.Tracing.Abstractions.ITrace? CurrentTrace { get; }
```

Implements [CurrentTrace](Myprysm.Tracing.Abstractions.ITracer.md#Myprysm.Tracing.Abstractions.ITracer.CurrentTrace 'Myprysm.Tracing.Abstractions.ITracer.CurrentTrace')

#### Property Value
[ITrace](Myprysm.Tracing.Abstractions.ITrace.md 'Myprysm.Tracing.Abstractions.ITrace')

<a name='Myprysm.Tracing.Abstractions.DefaultTracer.Identity'></a>

## DefaultTracer.Identity Property

The identity of the tracer.

```csharp
public Myprysm.Tracing.Abstractions.TracerIdentity Identity { get; }
```

Implements [Identity](Myprysm.Tracing.Abstractions.ITracer.md#Myprysm.Tracing.Abstractions.ITracer.Identity 'Myprysm.Tracing.Abstractions.ITracer.Identity')

#### Property Value
[TracerIdentity](Myprysm.Tracing.Abstractions.TracerIdentity.md 'Myprysm.Tracing.Abstractions.TracerIdentity')
### Methods

<a name='Myprysm.Tracing.Abstractions.DefaultTracer.StartTrace(string,Myprysm.Tracing.Abstractions.TraceKind,Myprysm.Tracing.Abstractions.ITrace)'></a>

## DefaultTracer.StartTrace(string, TraceKind, ITrace) Method

Start an application trace with the provided name, optional kind and parent.

```csharp
public Myprysm.Tracing.Abstractions.ITrace StartTrace(string name, Myprysm.Tracing.Abstractions.TraceKind kind=Myprysm.Tracing.Abstractions.TraceKind.Internal, Myprysm.Tracing.Abstractions.ITrace? parent=null);
```
#### Parameters

<a name='Myprysm.Tracing.Abstractions.DefaultTracer.StartTrace(string,Myprysm.Tracing.Abstractions.TraceKind,Myprysm.Tracing.Abstractions.ITrace).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the trace.

<a name='Myprysm.Tracing.Abstractions.DefaultTracer.StartTrace(string,Myprysm.Tracing.Abstractions.TraceKind,Myprysm.Tracing.Abstractions.ITrace).kind'></a>

`kind` [TraceKind](Myprysm.Tracing.Abstractions.TraceKind.md 'Myprysm.Tracing.Abstractions.TraceKind')

The optional kind of the trace.

<a name='Myprysm.Tracing.Abstractions.DefaultTracer.StartTrace(string,Myprysm.Tracing.Abstractions.TraceKind,Myprysm.Tracing.Abstractions.ITrace).parent'></a>

`parent` [ITrace](Myprysm.Tracing.Abstractions.ITrace.md 'Myprysm.Tracing.Abstractions.ITrace')

The optional parent of the trace.

Implements [StartTrace(string, TraceKind, ITrace)](Myprysm.Tracing.Abstractions.ITracer.md#Myprysm.Tracing.Abstractions.ITracer.StartTrace(string,Myprysm.Tracing.Abstractions.TraceKind,Myprysm.Tracing.Abstractions.ITrace) 'Myprysm.Tracing.Abstractions.ITracer.StartTrace(string, Myprysm.Tracing.Abstractions.TraceKind, Myprysm.Tracing.Abstractions.ITrace)')

#### Returns
[ITrace](Myprysm.Tracing.Abstractions.ITrace.md 'Myprysm.Tracing.Abstractions.ITrace')

### Remarks
When a parent is not provided,  
the tracer implementation should try to determine the appropriate parent by itself.