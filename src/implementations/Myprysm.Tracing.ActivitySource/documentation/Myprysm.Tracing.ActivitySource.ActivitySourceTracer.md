#### [Myprysm.Tracing.ActivitySource](index.md 'index')
### [Myprysm.Tracing.ActivitySource](index.md#Myprysm.Tracing.ActivitySource 'Myprysm.Tracing.ActivitySource')

## ActivitySourceTracer Class

A tracer wrapping an [System.Diagnostics.ActivitySource](https://docs.microsoft.com/en-us/dotnet/api/System.Diagnostics.ActivitySource 'System.Diagnostics.ActivitySource') for application telemetry.

```csharp
public sealed class ActivitySourceTracer :
Myprysm.Tracing.Abstractions.ITracer
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ActivitySourceTracer

Implements [Myprysm.Tracing.Abstractions.ITracer](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITracer 'Myprysm.Tracing.Abstractions.ITracer')
### Constructors

<a name='Myprysm.Tracing.ActivitySource.ActivitySourceTracer.ActivitySourceTracer(Myprysm.Tracing.Abstractions.TracerIdentity)'></a>

## ActivitySourceTracer(TracerIdentity) Constructor

Creates a new [ActivitySourceTracer](Myprysm.Tracing.ActivitySource.ActivitySourceTracer.md 'Myprysm.Tracing.ActivitySource.ActivitySourceTracer').

```csharp
public ActivitySourceTracer(Myprysm.Tracing.Abstractions.TracerIdentity identity);
```
#### Parameters

<a name='Myprysm.Tracing.ActivitySource.ActivitySourceTracer.ActivitySourceTracer(Myprysm.Tracing.Abstractions.TracerIdentity).identity'></a>

`identity` [Myprysm.Tracing.Abstractions.TracerIdentity](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.TracerIdentity 'Myprysm.Tracing.Abstractions.TracerIdentity')

The tracer identity.
### Properties

<a name='Myprysm.Tracing.ActivitySource.ActivitySourceTracer.ActivitySource'></a>

## ActivitySourceTracer.ActivitySource Property

Gets the underlying [ActivitySource](Myprysm.Tracing.ActivitySource.ActivitySourceTracer.md#Myprysm.Tracing.ActivitySource.ActivitySourceTracer.ActivitySource 'Myprysm.Tracing.ActivitySource.ActivitySourceTracer.ActivitySource') of this tracer.

```csharp
public System.Diagnostics.ActivitySource ActivitySource { get; }
```

#### Property Value
[System.Diagnostics.ActivitySource](https://docs.microsoft.com/en-us/dotnet/api/System.Diagnostics.ActivitySource 'System.Diagnostics.ActivitySource')

<a name='Myprysm.Tracing.ActivitySource.ActivitySourceTracer.CurrentTrace'></a>

## ActivitySourceTracer.CurrentTrace Property

The current application trace at the moment of the request.

```csharp
public Myprysm.Tracing.Abstractions.ITrace? CurrentTrace { get; }
```

Implements [CurrentTrace](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITracer.CurrentTrace 'Myprysm.Tracing.Abstractions.ITracer.CurrentTrace')

#### Property Value
[Myprysm.Tracing.Abstractions.ITrace](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace 'Myprysm.Tracing.Abstractions.ITrace')

<a name='Myprysm.Tracing.ActivitySource.ActivitySourceTracer.Identity'></a>

## ActivitySourceTracer.Identity Property

The identity of the tracer.

```csharp
public Myprysm.Tracing.Abstractions.TracerIdentity Identity { get; }
```

Implements [Identity](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITracer.Identity 'Myprysm.Tracing.Abstractions.ITracer.Identity')

#### Property Value
[Myprysm.Tracing.Abstractions.TracerIdentity](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.TracerIdentity 'Myprysm.Tracing.Abstractions.TracerIdentity')
### Methods

<a name='Myprysm.Tracing.ActivitySource.ActivitySourceTracer.StartTrace(string,Myprysm.Tracing.Abstractions.TraceKind,Myprysm.Tracing.Abstractions.ITrace)'></a>

## ActivitySourceTracer.StartTrace(string, TraceKind, ITrace) Method

Start an application trace with the provided name, optional kind and parent.

```csharp
public Myprysm.Tracing.Abstractions.ITrace? StartTrace(string name, Myprysm.Tracing.Abstractions.TraceKind kind=Myprysm.Tracing.Abstractions.TraceKind.Internal, Myprysm.Tracing.Abstractions.ITrace? parent=null);
```
#### Parameters

<a name='Myprysm.Tracing.ActivitySource.ActivitySourceTracer.StartTrace(string,Myprysm.Tracing.Abstractions.TraceKind,Myprysm.Tracing.Abstractions.ITrace).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the trace.

<a name='Myprysm.Tracing.ActivitySource.ActivitySourceTracer.StartTrace(string,Myprysm.Tracing.Abstractions.TraceKind,Myprysm.Tracing.Abstractions.ITrace).kind'></a>

`kind` [Myprysm.Tracing.Abstractions.TraceKind](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.TraceKind 'Myprysm.Tracing.Abstractions.TraceKind')

The optional kind of the trace.

<a name='Myprysm.Tracing.ActivitySource.ActivitySourceTracer.StartTrace(string,Myprysm.Tracing.Abstractions.TraceKind,Myprysm.Tracing.Abstractions.ITrace).parent'></a>

`parent` [Myprysm.Tracing.Abstractions.ITrace](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace 'Myprysm.Tracing.Abstractions.ITrace')

The optional parent of the trace.

Implements [StartTrace(string, TraceKind, ITrace)](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITracer.StartTrace#Myprysm_Tracing_Abstractions_ITracer_StartTrace_System_String,Myprysm_Tracing_Abstractions_TraceKind,Myprysm_Tracing_Abstractions_ITrace_ 'Myprysm.Tracing.Abstractions.ITracer.StartTrace(System.String,Myprysm.Tracing.Abstractions.TraceKind,Myprysm.Tracing.Abstractions.ITrace)')

#### Returns
[Myprysm.Tracing.Abstractions.ITrace](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace 'Myprysm.Tracing.Abstractions.ITrace')

### Remarks
When a parent is not provided,  
the tracer implementation should try to determine the appropriate parent by itself.