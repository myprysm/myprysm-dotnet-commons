#### [Myprysm.Tracing.ActivitySource](index.md 'index')
### [Myprysm.Tracing.ActivitySource](index.md#Myprysm.Tracing.ActivitySource 'Myprysm.Tracing.ActivitySource')

## ActivitySourceTracerFactory Class

Factory that manages instances of [ActivitySourceTracer](Myprysm.Tracing.ActivitySource.ActivitySourceTracer.md 'Myprysm.Tracing.ActivitySource.ActivitySourceTracer').

```csharp
public class ActivitySourceTracerFactory :
Myprysm.Tracing.Abstractions.ITracerFactory
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ActivitySourceTracerFactory

Implements [Myprysm.Tracing.Abstractions.ITracerFactory](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITracerFactory 'Myprysm.Tracing.Abstractions.ITracerFactory')
### Constructors

<a name='Myprysm.Tracing.ActivitySource.ActivitySourceTracerFactory.ActivitySourceTracerFactory(Microsoft.Extensions.Options.IOptions_Myprysm.Tracing.Abstractions.StartupTracerOptions_)'></a>

## ActivitySourceTracerFactory(IOptions<StartupTracerOptions>) Constructor

Creates a new [ActivitySourceTracerFactory](Myprysm.Tracing.ActivitySource.ActivitySourceTracerFactory.md 'Myprysm.Tracing.ActivitySource.ActivitySourceTracerFactory') with the given startup options.

```csharp
public ActivitySourceTracerFactory(Microsoft.Extensions.Options.IOptions<Myprysm.Tracing.Abstractions.StartupTracerOptions> options);
```
#### Parameters

<a name='Myprysm.Tracing.ActivitySource.ActivitySourceTracerFactory.ActivitySourceTracerFactory(Microsoft.Extensions.Options.IOptions_Myprysm.Tracing.Abstractions.StartupTracerOptions_).options'></a>

`options` [Microsoft.Extensions.Options.IOptions&lt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Options.IOptions-1 'Microsoft.Extensions.Options.IOptions`1')[Myprysm.Tracing.Abstractions.StartupTracerOptions](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.StartupTracerOptions 'Myprysm.Tracing.Abstractions.StartupTracerOptions')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Options.IOptions-1 'Microsoft.Extensions.Options.IOptions`1')

The startup options to register [Myprysm.Tracing.Abstractions.TracerIdentity](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.TracerIdentity 'Myprysm.Tracing.Abstractions.TracerIdentity') on startup.
### Properties

<a name='Myprysm.Tracing.ActivitySource.ActivitySourceTracerFactory.RegisteredIdentities'></a>

## ActivitySourceTracerFactory.RegisteredIdentities Property

Gets the registered identities of this [ActivitySourceTracerFactory](Myprysm.Tracing.ActivitySource.ActivitySourceTracerFactory.md 'Myprysm.Tracing.ActivitySource.ActivitySourceTracerFactory').

```csharp
public System.Collections.Generic.IEnumerable<Myprysm.Tracing.Abstractions.TracerIdentity> RegisteredIdentities { get; }
```

#### Property Value
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Myprysm.Tracing.Abstractions.TracerIdentity](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.TracerIdentity 'Myprysm.Tracing.Abstractions.TracerIdentity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')
### Methods

<a name='Myprysm.Tracing.ActivitySource.ActivitySourceTracerFactory.GetTracer(Myprysm.Tracing.Abstractions.TracerIdentity)'></a>

## ActivitySourceTracerFactory.GetTracer(TracerIdentity) Method

Gets a tracer for the given identity.

```csharp
public Myprysm.Tracing.Abstractions.ITracer GetTracer(Myprysm.Tracing.Abstractions.TracerIdentity identity);
```
#### Parameters

<a name='Myprysm.Tracing.ActivitySource.ActivitySourceTracerFactory.GetTracer(Myprysm.Tracing.Abstractions.TracerIdentity).identity'></a>

`identity` [Myprysm.Tracing.Abstractions.TracerIdentity](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.TracerIdentity 'Myprysm.Tracing.Abstractions.TracerIdentity')

The identity of the tracer.

Implements [GetTracer(TracerIdentity)](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITracerFactory.GetTracer#Myprysm_Tracing_Abstractions_ITracerFactory_GetTracer_Myprysm_Tracing_Abstractions_TracerIdentity_ 'Myprysm.Tracing.Abstractions.ITracerFactory.GetTracer(Myprysm.Tracing.Abstractions.TracerIdentity)')

#### Returns
[Myprysm.Tracing.Abstractions.ITracer](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITracer 'Myprysm.Tracing.Abstractions.ITracer')  
The tracer for the identity.