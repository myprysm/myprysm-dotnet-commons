#### [Myprysm.Tracing.ApplicationInsights](index.md 'index')
### [Myprysm.Tracing.ApplicationInsights](index.md#Myprysm.Tracing.ApplicationInsights 'Myprysm.Tracing.ApplicationInsights')

## DependencyInjection Class

Dependency injection extensions.

```csharp
public static class DependencyInjection
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DependencyInjection
### Methods

<a name='Myprysm.Tracing.ApplicationInsights.DependencyInjection.AddApplicationInsightsTracer(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection)'></a>

## DependencyInjection.AddApplicationInsightsTracer(this IServiceCollection) Method

Registers an [TelemetryClientTracerFactory](Myprysm.Tracing.ApplicationInsights.TelemetryClientTracerFactory.md 'Myprysm.Tracing.ApplicationInsights.TelemetryClientTracerFactory') that can generate [Myprysm.Tracing.Abstractions.ITracer](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Tracing.Abstractions.ITracer 'Myprysm.Tracing.Abstractions.ITracer')  
for application telemetry.

```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddApplicationInsightsTracer(this Microsoft.Extensions.DependencyInjection.IServiceCollection services);
```
#### Parameters

<a name='Myprysm.Tracing.ApplicationInsights.DependencyInjection.AddApplicationInsightsTracer(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection).services'></a>

`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')

The service collection.

#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection for fluent APIs.