#### [Myprysm.Tracing.ApplicationInsights](index.md 'index')
### [Myprysm.Tracing.ApplicationInsights](index.md#Myprysm.Tracing.ApplicationInsights 'Myprysm.Tracing.ApplicationInsights')

## TelemetryClientTracerFactory Class

Factory that manages instances of [TelemetryClientTracer](Myprysm.Tracing.ApplicationInsights.TelemetryClientTracer.md 'Myprysm.Tracing.ApplicationInsights.TelemetryClientTracer').

```csharp
public class TelemetryClientTracerFactory :
Myprysm.Tracing.Abstractions.ITracerFactory
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; TelemetryClientTracerFactory

Implements [Myprysm.Tracing.Abstractions.ITracerFactory](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITracerFactory 'Myprysm.Tracing.Abstractions.ITracerFactory')
### Constructors

<a name='Myprysm.Tracing.ApplicationInsights.TelemetryClientTracerFactory.TelemetryClientTracerFactory(Microsoft.ApplicationInsights.TelemetryClient)'></a>

## TelemetryClientTracerFactory(TelemetryClient) Constructor

Creates a new [TelemetryClientTracerFactory](Myprysm.Tracing.ApplicationInsights.TelemetryClientTracerFactory.md 'Myprysm.Tracing.ApplicationInsights.TelemetryClientTracerFactory') with the given [Microsoft.ApplicationInsights.TelemetryClient](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.ApplicationInsights.TelemetryClient 'Microsoft.ApplicationInsights.TelemetryClient').

```csharp
public TelemetryClientTracerFactory(Microsoft.ApplicationInsights.TelemetryClient telemetryClient);
```
#### Parameters

<a name='Myprysm.Tracing.ApplicationInsights.TelemetryClientTracerFactory.TelemetryClientTracerFactory(Microsoft.ApplicationInsights.TelemetryClient).telemetryClient'></a>

`telemetryClient` [Microsoft.ApplicationInsights.TelemetryClient](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.ApplicationInsights.TelemetryClient 'Microsoft.ApplicationInsights.TelemetryClient')

The telemetry client.
### Methods

<a name='Myprysm.Tracing.ApplicationInsights.TelemetryClientTracerFactory.GetTracer(Myprysm.Tracing.Abstractions.TracerIdentity)'></a>

## TelemetryClientTracerFactory.GetTracer(TracerIdentity) Method

Gets a tracer for the given identity.

```csharp
public Myprysm.Tracing.Abstractions.ITracer GetTracer(Myprysm.Tracing.Abstractions.TracerIdentity identity);
```
#### Parameters

<a name='Myprysm.Tracing.ApplicationInsights.TelemetryClientTracerFactory.GetTracer(Myprysm.Tracing.Abstractions.TracerIdentity).identity'></a>

`identity` [Myprysm.Tracing.Abstractions.TracerIdentity](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.TracerIdentity 'Myprysm.Tracing.Abstractions.TracerIdentity')

The identity of the tracer.

Implements [GetTracer(TracerIdentity)](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITracerFactory.GetTracer#Myprysm_Tracing_Abstractions_ITracerFactory_GetTracer_Myprysm_Tracing_Abstractions_TracerIdentity_ 'Myprysm.Tracing.Abstractions.ITracerFactory.GetTracer(Myprysm.Tracing.Abstractions.TracerIdentity)')

#### Returns
[Myprysm.Tracing.Abstractions.ITracer](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITracer 'Myprysm.Tracing.Abstractions.ITracer')  
The tracer for the identity.