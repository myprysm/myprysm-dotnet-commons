#### [Myprysm.Tracing.ActivitySource](index.md 'index')
### [Myprysm.Tracing.ActivitySource](index.md#Myprysm_Tracing_ActivitySource 'Myprysm.Tracing.ActivitySource')
## DependencyInjection Class
Dependency injection extensions.  
```csharp
public static class DependencyInjection
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DependencyInjection  
### Methods
<a name='Myprysm_Tracing_ActivitySource_DependencyInjection_AddActivityTracing(Microsoft_Extensions_DependencyInjection_IServiceCollection)'></a>
## DependencyInjection.AddActivityTracing(IServiceCollection) Method
Registers an [ActivitySourceTracerFactory](Myprysm_Tracing_ActivitySource_ActivitySourceTracerFactory.md 'Myprysm.Tracing.ActivitySource.ActivitySourceTracerFactory') that can generate eagerly [Myprysm.Tracing.Abstractions.ITracer](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITracer 'Myprysm.Tracing.Abstractions.ITracer')  
for application telemetry.  
```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddActivityTracing(this Microsoft.Extensions.DependencyInjection.IServiceCollection services);
```
#### Parameters
<a name='Myprysm_Tracing_ActivitySource_DependencyInjection_AddActivityTracing(Microsoft_Extensions_DependencyInjection_IServiceCollection)_services'></a>
`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection.
  
#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection for fluent APIs.
  
