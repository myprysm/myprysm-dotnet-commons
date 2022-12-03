#### [Myprysm.Tracing.ApplicationInsights](index.md 'index')
### [Myprysm.Tracing.ApplicationInsights](index.md#Myprysm.Tracing.ApplicationInsights 'Myprysm.Tracing.ApplicationInsights')

## TelemetryClientTracer Class

A tracer wrapping an [Microsoft.ApplicationInsights.TelemetryClient](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.ApplicationInsights.TelemetryClient 'Microsoft.ApplicationInsights.TelemetryClient') for application telemetry.

```csharp
public class TelemetryClientTracer :
Myprysm.Tracing.Abstractions.ITracer
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; TelemetryClientTracer

Implements [Myprysm.Tracing.Abstractions.ITracer](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITracer 'Myprysm.Tracing.Abstractions.ITracer')
### Constructors

<a name='Myprysm.Tracing.ApplicationInsights.TelemetryClientTracer.TelemetryClientTracer(Myprysm.Tracing.Abstractions.TracerIdentity,Microsoft.ApplicationInsights.TelemetryClient)'></a>

## TelemetryClientTracer(TracerIdentity, TelemetryClient) Constructor

Creates a new [TelemetryClientTracer](Myprysm.Tracing.ApplicationInsights.TelemetryClientTracer.md 'Myprysm.Tracing.ApplicationInsights.TelemetryClientTracer') with the given identity and [Microsoft.ApplicationInsights.TelemetryClient](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.ApplicationInsights.TelemetryClient 'Microsoft.ApplicationInsights.TelemetryClient').

```csharp
public TelemetryClientTracer(Myprysm.Tracing.Abstractions.TracerIdentity identity, Microsoft.ApplicationInsights.TelemetryClient telemetryClient);
```
#### Parameters

<a name='Myprysm.Tracing.ApplicationInsights.TelemetryClientTracer.TelemetryClientTracer(Myprysm.Tracing.Abstractions.TracerIdentity,Microsoft.ApplicationInsights.TelemetryClient).identity'></a>

`identity` [Myprysm.Tracing.Abstractions.TracerIdentity](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.TracerIdentity 'Myprysm.Tracing.Abstractions.TracerIdentity')

The tracer identity.

<a name='Myprysm.Tracing.ApplicationInsights.TelemetryClientTracer.TelemetryClientTracer(Myprysm.Tracing.Abstractions.TracerIdentity,Microsoft.ApplicationInsights.TelemetryClient).telemetryClient'></a>

`telemetryClient` [Microsoft.ApplicationInsights.TelemetryClient](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.ApplicationInsights.TelemetryClient 'Microsoft.ApplicationInsights.TelemetryClient')

The Application Insights telemetry client.
### Properties

<a name='Myprysm.Tracing.ApplicationInsights.TelemetryClientTracer.CurrentTrace'></a>

## TelemetryClientTracer.CurrentTrace Property

The current application trace at the moment of the request.

```csharp
public Myprysm.Tracing.Abstractions.ITrace? CurrentTrace { get; }
```

Implements [CurrentTrace](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITracer.CurrentTrace 'Myprysm.Tracing.Abstractions.ITracer.CurrentTrace')

#### Property Value
[Myprysm.Tracing.Abstractions.ITrace](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace 'Myprysm.Tracing.Abstractions.ITrace')

<a name='Myprysm.Tracing.ApplicationInsights.TelemetryClientTracer.Identity'></a>

## TelemetryClientTracer.Identity Property

The identity of the tracer.

```csharp
public Myprysm.Tracing.Abstractions.TracerIdentity Identity { get; }
```

Implements [Identity](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITracer.Identity 'Myprysm.Tracing.Abstractions.ITracer.Identity')

#### Property Value
[Myprysm.Tracing.Abstractions.TracerIdentity](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.TracerIdentity 'Myprysm.Tracing.Abstractions.TracerIdentity')
### Methods

<a name='Myprysm.Tracing.ApplicationInsights.TelemetryClientTracer.StartTrace(string,Myprysm.Tracing.Abstractions.TraceKind,Myprysm.Tracing.Abstractions.ITrace)'></a>

## TelemetryClientTracer.StartTrace(string, TraceKind, ITrace) Method

Start an application trace with the provided name, optional kind and parent.

```csharp
public Myprysm.Tracing.Abstractions.ITrace? StartTrace(string name, Myprysm.Tracing.Abstractions.TraceKind kind=Myprysm.Tracing.Abstractions.TraceKind.Internal, Myprysm.Tracing.Abstractions.ITrace? parent=null);
```
#### Parameters

<a name='Myprysm.Tracing.ApplicationInsights.TelemetryClientTracer.StartTrace(string,Myprysm.Tracing.Abstractions.TraceKind,Myprysm.Tracing.Abstractions.ITrace).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the trace.

<a name='Myprysm.Tracing.ApplicationInsights.TelemetryClientTracer.StartTrace(string,Myprysm.Tracing.Abstractions.TraceKind,Myprysm.Tracing.Abstractions.ITrace).kind'></a>

`kind` [Myprysm.Tracing.Abstractions.TraceKind](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.TraceKind 'Myprysm.Tracing.Abstractions.TraceKind')

The optional kind of the trace.

<a name='Myprysm.Tracing.ApplicationInsights.TelemetryClientTracer.StartTrace(string,Myprysm.Tracing.Abstractions.TraceKind,Myprysm.Tracing.Abstractions.ITrace).parent'></a>

`parent` [Myprysm.Tracing.Abstractions.ITrace](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace 'Myprysm.Tracing.Abstractions.ITrace')

The optional parent of the trace.

Implements [StartTrace(string, TraceKind, ITrace)](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITracer.StartTrace#Myprysm_Tracing_Abstractions_ITracer_StartTrace_System_String,Myprysm_Tracing_Abstractions_TraceKind,Myprysm_Tracing_Abstractions_ITrace_ 'Myprysm.Tracing.Abstractions.ITracer.StartTrace(System.String,Myprysm.Tracing.Abstractions.TraceKind,Myprysm.Tracing.Abstractions.ITrace)')

#### Returns
[Myprysm.Tracing.Abstractions.ITrace](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace 'Myprysm.Tracing.Abstractions.ITrace')

### Remarks
When a parent is not provided,  
the tracer implementation should try to determine the appropriate parent by itself.