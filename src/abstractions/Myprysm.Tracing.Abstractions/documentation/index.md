#### [Myprysm.Tracing.Abstractions](index.md 'index')
### Namespaces
<a name='Myprysm_Tracing_Abstractions'></a>
## Myprysm.Tracing.Abstractions Namespace

| Classes | |
| :--- | :--- |
| [DefaultTracer](Myprysm_Tracing_Abstractions_DefaultTracer.md 'Myprysm.Tracing.Abstractions.DefaultTracer') | Default tracer implementation with minimal operations.<br/>Useful for testing or when no real [ITracerFactory](Myprysm_Tracing_Abstractions_ITracerFactory.md 'Myprysm.Tracing.Abstractions.ITracerFactory') is provided.<br/> |
| [DependencyInjection](Myprysm_Tracing_Abstractions_DependencyInjection.md 'Myprysm.Tracing.Abstractions.DependencyInjection') | Dependency injection extensions.<br/> |
| [StartupTracerOptions](Myprysm_Tracing_Abstractions_StartupTracerOptions.md 'Myprysm.Tracing.Abstractions.StartupTracerOptions') | Options used to register tracer identities on startup.<br/>This can be useful when using specific implementations (e.g. OpenTelemetry).<br/> |
| [TracerIdentity](Myprysm_Tracing_Abstractions_TracerIdentity.md 'Myprysm.Tracing.Abstractions.TracerIdentity') | Represents the identity of a [ITracer](Myprysm_Tracing_Abstractions_ITracer.md 'Myprysm.Tracing.Abstractions.ITracer'), usually for a single library.<br/> |

| Interfaces | |
| :--- | :--- |
| [ITrace](Myprysm_Tracing_Abstractions_ITrace.md 'Myprysm.Tracing.Abstractions.ITrace') | An application trace for telemetry.<br/> |
| [ITracer](Myprysm_Tracing_Abstractions_ITracer.md 'Myprysm.Tracing.Abstractions.ITracer') | A tracer that can start an application trace and get the current application trace for monitoring.<br/> |
| [ITracerFactory](Myprysm_Tracing_Abstractions_ITracerFactory.md 'Myprysm.Tracing.Abstractions.ITracerFactory') | A tracer factory that produces a [ITracer](Myprysm_Tracing_Abstractions_ITracer.md 'Myprysm.Tracing.Abstractions.ITracer') for a [TracerIdentity](Myprysm_Tracing_Abstractions_TracerIdentity.md 'Myprysm.Tracing.Abstractions.TracerIdentity').<br/><br/>Although not required, it may be preferable to cache instances for a given identity.<br/> |

| Enums | |
| :--- | :--- |
| [TraceKind](Myprysm_Tracing_Abstractions_TraceKind.md 'Myprysm.Tracing.Abstractions.TraceKind') | Adapted from https://github.com/open-telemetry/opentelemetry-specification/blob/main/specification/trace/api.md#spankind<br/>TraceKind describes the relationship between the Trace, its parents, and its children in a Trace.<br/>TraceKind describes two independent properties that benefit tracing systems during analysis.<br/> |
  
