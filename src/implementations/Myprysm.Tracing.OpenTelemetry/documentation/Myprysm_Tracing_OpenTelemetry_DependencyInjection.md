#### [Myprysm.Tracing.OpenTelemetry](index.md 'index')
### [Myprysm.Tracing.OpenTelemetry](index.md#Myprysm_Tracing_OpenTelemetry 'Myprysm.Tracing.OpenTelemetry')
## DependencyInjection Class
Dependency injection extensions.  
```csharp
public static class DependencyInjection
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DependencyInjection  
### Methods
<a name='Myprysm_Tracing_OpenTelemetry_DependencyInjection_AddMyprysmOpenTelemetryTracing(Microsoft_Extensions_DependencyInjection_IServiceCollection_System_Action_System_IServiceProvider_OpenTelemetry_Trace_TracerProviderBuilder_)'></a>
## DependencyInjection.AddMyprysmOpenTelemetryTracing(IServiceCollection, Action&lt;IServiceProvider,TracerProviderBuilder&gt;) Method
Adds OpenTelemetry TracerProvider configures with Myprysm Tracing enabled libraries into the specified [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection').  
```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddMyprysmOpenTelemetryTracing(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, System.Action<System.IServiceProvider,OpenTelemetry.Trace.TracerProviderBuilder> configure);
```
#### Parameters
<a name='Myprysm_Tracing_OpenTelemetry_DependencyInjection_AddMyprysmOpenTelemetryTracing(Microsoft_Extensions_DependencyInjection_IServiceCollection_System_Action_System_IServiceProvider_OpenTelemetry_Trace_TracerProviderBuilder_)_services'></a>
`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') to add services into.
  
<a name='Myprysm_Tracing_OpenTelemetry_DependencyInjection_AddMyprysmOpenTelemetryTracing(Microsoft_Extensions_DependencyInjection_IServiceCollection_System_Action_System_IServiceProvider_OpenTelemetry_Trace_TracerProviderBuilder_)_configure'></a>
`configure` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[OpenTelemetry.Trace.TracerProviderBuilder](https://docs.microsoft.com/en-us/dotnet/api/OpenTelemetry.Trace.TracerProviderBuilder 'OpenTelemetry.Trace.TracerProviderBuilder')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')  
Callback action to configure the [OpenTelemetry.Trace.TracerProviderBuilder](https://docs.microsoft.com/en-us/dotnet/api/OpenTelemetry.Trace.TracerProviderBuilder 'OpenTelemetry.Trace.TracerProviderBuilder').
  
#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection for fluent APIs.
  
