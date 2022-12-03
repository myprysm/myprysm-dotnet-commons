#### [Myprysm.Testing.NUnit](index.md 'index')
### [Myprysm.Testing.NUnit](index.md#Myprysm.Testing.NUnit 'Myprysm.Testing.NUnit')

## CollectorTracer Class

Tracer decorator that collects the generated traces from the delegated tracer.

```csharp
public class CollectorTracer :
Myprysm.Tracing.Abstractions.ITracer
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; CollectorTracer

Implements [Myprysm.Tracing.Abstractions.ITracer](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITracer 'Myprysm.Tracing.Abstractions.ITracer')
### Constructors

<a name='Myprysm.Testing.NUnit.CollectorTracer.CollectorTracer(Myprysm.Tracing.Abstractions.ITracer)'></a>

## CollectorTracer(ITracer) Constructor

Creates a new [CollectorTracer](Myprysm.Testing.NUnit.CollectorTracer.md 'Myprysm.Testing.NUnit.CollectorTracer').

```csharp
public CollectorTracer(Myprysm.Tracing.Abstractions.ITracer @delegate);
```
#### Parameters

<a name='Myprysm.Testing.NUnit.CollectorTracer.CollectorTracer(Myprysm.Tracing.Abstractions.ITracer).delegate'></a>

`delegate` [Myprysm.Tracing.Abstractions.ITracer](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITracer 'Myprysm.Tracing.Abstractions.ITracer')

The delegated tracer
### Properties

<a name='Myprysm.Testing.NUnit.CollectorTracer.CurrentTrace'></a>

## CollectorTracer.CurrentTrace Property

The delegated current trace.

```csharp
public Myprysm.Tracing.Abstractions.ITrace? CurrentTrace { get; }
```

Implements [CurrentTrace](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITracer.CurrentTrace 'Myprysm.Tracing.Abstractions.ITracer.CurrentTrace')

#### Property Value
[Myprysm.Tracing.Abstractions.ITrace](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace 'Myprysm.Tracing.Abstractions.ITrace')

<a name='Myprysm.Testing.NUnit.CollectorTracer.Identity'></a>

## CollectorTracer.Identity Property

The delegated identity.

```csharp
public Myprysm.Tracing.Abstractions.TracerIdentity Identity { get; }
```

Implements [Identity](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITracer.Identity 'Myprysm.Tracing.Abstractions.ITracer.Identity')

#### Property Value
[Myprysm.Tracing.Abstractions.TracerIdentity](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.TracerIdentity 'Myprysm.Tracing.Abstractions.TracerIdentity')

<a name='Myprysm.Testing.NUnit.CollectorTracer.Traces'></a>

## CollectorTracer.Traces Property

The collected traces.

```csharp
public System.Collections.Generic.IEnumerable<Myprysm.Tracing.Abstractions.ITrace> Traces { get; }
```

#### Property Value
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Myprysm.Tracing.Abstractions.ITrace](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace 'Myprysm.Tracing.Abstractions.ITrace')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')
### Methods

<a name='Myprysm.Testing.NUnit.CollectorTracer.StartTrace(string,Myprysm.Tracing.Abstractions.TraceKind,Myprysm.Tracing.Abstractions.ITrace)'></a>

## CollectorTracer.StartTrace(string, TraceKind, ITrace) Method

Start an application trace with the provided name, optional kind and parent.

```csharp
public Myprysm.Tracing.Abstractions.ITrace? StartTrace(string name, Myprysm.Tracing.Abstractions.TraceKind kind=Myprysm.Tracing.Abstractions.TraceKind.Internal, Myprysm.Tracing.Abstractions.ITrace? parent=null);
```
#### Parameters

<a name='Myprysm.Testing.NUnit.CollectorTracer.StartTrace(string,Myprysm.Tracing.Abstractions.TraceKind,Myprysm.Tracing.Abstractions.ITrace).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the trace.

<a name='Myprysm.Testing.NUnit.CollectorTracer.StartTrace(string,Myprysm.Tracing.Abstractions.TraceKind,Myprysm.Tracing.Abstractions.ITrace).kind'></a>

`kind` [Myprysm.Tracing.Abstractions.TraceKind](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.TraceKind 'Myprysm.Tracing.Abstractions.TraceKind')

The optional kind of the trace.

<a name='Myprysm.Testing.NUnit.CollectorTracer.StartTrace(string,Myprysm.Tracing.Abstractions.TraceKind,Myprysm.Tracing.Abstractions.ITrace).parent'></a>

`parent` [Myprysm.Tracing.Abstractions.ITrace](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace 'Myprysm.Tracing.Abstractions.ITrace')

The optional parent of the trace.

Implements [StartTrace(string, TraceKind, ITrace)](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITracer.StartTrace#Myprysm_Tracing_Abstractions_ITracer_StartTrace_System_String,Myprysm_Tracing_Abstractions_TraceKind,Myprysm_Tracing_Abstractions_ITrace_ 'Myprysm.Tracing.Abstractions.ITracer.StartTrace(System.String,Myprysm.Tracing.Abstractions.TraceKind,Myprysm.Tracing.Abstractions.ITrace)')

#### Returns
[Myprysm.Tracing.Abstractions.ITrace](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITrace 'Myprysm.Tracing.Abstractions.ITrace')

### Remarks
When a parent is not provided,  
the tracer implementation should try to determine the appropriate parent by itself.