#### [Myprysm.Tracing.Abstractions](index.md 'index')
### [Myprysm.Tracing.Abstractions](index.md#Myprysm_Tracing_Abstractions 'Myprysm.Tracing.Abstractions')
## StartupTracerOptions Class
Options used to register tracer identities on startup.  
This can be useful when using specific implementations (e.g. OpenTelemetry).  
```csharp
public class StartupTracerOptions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; StartupTracerOptions  
### Properties
<a name='Myprysm_Tracing_Abstractions_StartupTracerOptions_OnStartup'></a>
## StartupTracerOptions.OnStartup Property
The list of identities to register on startup.  
```csharp
public System.Collections.Generic.List<Myprysm.Tracing.Abstractions.TracerIdentity> OnStartup { get; set; }
```
#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[TracerIdentity](Myprysm_Tracing_Abstractions_TracerIdentity.md 'Myprysm.Tracing.Abstractions.TracerIdentity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')
  
