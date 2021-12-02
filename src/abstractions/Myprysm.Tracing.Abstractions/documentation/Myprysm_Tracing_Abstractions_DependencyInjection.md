#### [Myprysm.Tracing.Abstractions](index.md 'index')
### [Myprysm.Tracing.Abstractions](index.md#Myprysm_Tracing_Abstractions 'Myprysm.Tracing.Abstractions')
## DependencyInjection Class
Dependency injection extensions.  
```csharp
public static class DependencyInjection
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DependencyInjection  
### Methods
<a name='Myprysm_Tracing_Abstractions_DependencyInjection_RegisterTracerOnStartup(Microsoft_Extensions_DependencyInjection_IServiceCollection_Myprysm_Tracing_Abstractions_TracerIdentity)'></a>
## DependencyInjection.RegisterTracerOnStartup(IServiceCollection, TracerIdentity) Method
Registers a [TracerIdentity](Myprysm_Tracing_Abstractions_TracerIdentity.md 'Myprysm.Tracing.Abstractions.TracerIdentity') in the startup options.  
Can be useful with some implementations like OpenTelemetry.  
```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection RegisterTracerOnStartup(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Myprysm.Tracing.Abstractions.TracerIdentity identity);
```
#### Parameters
<a name='Myprysm_Tracing_Abstractions_DependencyInjection_RegisterTracerOnStartup(Microsoft_Extensions_DependencyInjection_IServiceCollection_Myprysm_Tracing_Abstractions_TracerIdentity)_services'></a>
`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection.
  
<a name='Myprysm_Tracing_Abstractions_DependencyInjection_RegisterTracerOnStartup(Microsoft_Extensions_DependencyInjection_IServiceCollection_Myprysm_Tracing_Abstractions_TracerIdentity)_identity'></a>
`identity` [TracerIdentity](Myprysm_Tracing_Abstractions_TracerIdentity.md 'Myprysm.Tracing.Abstractions.TracerIdentity')  
The tracer identity.
  
#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection.
  
<a name='Myprysm_Tracing_Abstractions_DependencyInjection_TryAddDefaultTracer(Microsoft_Extensions_DependencyInjection_IServiceCollection)'></a>
## DependencyInjection.TryAddDefaultTracer(IServiceCollection) Method
Try to register a default noop tracer factory if no tracer factory has been already registered.  
```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection TryAddDefaultTracer(this Microsoft.Extensions.DependencyInjection.IServiceCollection services);
```
#### Parameters
<a name='Myprysm_Tracing_Abstractions_DependencyInjection_TryAddDefaultTracer(Microsoft_Extensions_DependencyInjection_IServiceCollection)_services'></a>
`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection.
  
#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection.
  
