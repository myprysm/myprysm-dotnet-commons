#### [Myprysm.Tracing.Abstractions](index.md 'index')

## Myprysm.Tracing.Abstractions Assembly
### Namespaces

<a name='Myprysm.Tracing.Abstractions'></a>

## Myprysm.Tracing.Abstractions Namespace

| Classes | |
| :--- | :--- |
| [DefaultTracer](Myprysm.Tracing.Abstractions.DefaultTracer.md 'Myprysm.Tracing.Abstractions.DefaultTracer') | Default tracer implementation with minimal operations.<br/>Useful for testing or when no real [ITracerFactory](Myprysm.Tracing.Abstractions.ITracerFactory.md 'Myprysm.Tracing.Abstractions.ITracerFactory') is provided. |
| [DependencyInjection](Myprysm.Tracing.Abstractions.DependencyInjection.md 'Myprysm.Tracing.Abstractions.DependencyInjection') | Dependency injection extensions. |
| [StartupTracerOptions](Myprysm.Tracing.Abstractions.StartupTracerOptions.md 'Myprysm.Tracing.Abstractions.StartupTracerOptions') | Options used to register tracer identities on startup.<br/>This can be useful when using specific implementations (e.g. OpenTelemetry). |
| [TracerIdentity](Myprysm.Tracing.Abstractions.TracerIdentity.md 'Myprysm.Tracing.Abstractions.TracerIdentity') | Represents the identity of a [ITracer](Myprysm.Tracing.Abstractions.ITracer.md 'Myprysm.Tracing.Abstractions.ITracer'), usually for a single library. |

| Interfaces | |
| :--- | :--- |
| [ITrace](Myprysm.Tracing.Abstractions.ITrace.md 'Myprysm.Tracing.Abstractions.ITrace') | An application trace for telemetry. |
| [ITracer](Myprysm.Tracing.Abstractions.ITracer.md 'Myprysm.Tracing.Abstractions.ITracer') | A tracer that can start an application trace and get the current application trace for monitoring. |
| [ITracerFactory](Myprysm.Tracing.Abstractions.ITracerFactory.md 'Myprysm.Tracing.Abstractions.ITracerFactory') | A tracer factory that produces a [ITracer](Myprysm.Tracing.Abstractions.ITracer.md 'Myprysm.Tracing.Abstractions.ITracer') for a [TracerIdentity](Myprysm.Tracing.Abstractions.TracerIdentity.md 'Myprysm.Tracing.Abstractions.TracerIdentity').<br/><br/>Although not required, it may be preferable to cache instances for a given identity. |

| Enums | |
| :--- | :--- |
| [TraceKind](Myprysm.Tracing.Abstractions.TraceKind.md 'Myprysm.Tracing.Abstractions.TraceKind') | Adapted from https://github.com/open-telemetry/opentelemetry-specification/blob/main/specification/trace/api.md#spankind<br/>TraceKind describes the relationship between the Trace, its parents, and its children in a Trace.<br/>TraceKind describes two independent properties that benefit tracing systems during analysis. |
