#### [Myprysm.Tracing.Abstractions](index.md 'index')
### [Myprysm.Tracing.Abstractions](index.md#Myprysm.Tracing.Abstractions 'Myprysm.Tracing.Abstractions')

## DependencyInjection Class

Dependency injection extensions.

```csharp
public static class DependencyInjection
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DependencyInjection
### Methods

<a name='Myprysm.Tracing.Abstractions.DependencyInjection.RegisterTracerOnStartup(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Myprysm.Tracing.Abstractions.TracerIdentity)'></a>

## DependencyInjection.RegisterTracerOnStartup(this IServiceCollection, TracerIdentity) Method

Registers a [TracerIdentity](Myprysm.Tracing.Abstractions.TracerIdentity.md 'Myprysm.Tracing.Abstractions.TracerIdentity') in the startup options.  
Can be useful with some implementations like OpenTelemetry.

```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection RegisterTracerOnStartup(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, Myprysm.Tracing.Abstractions.TracerIdentity identity);
```
#### Parameters

<a name='Myprysm.Tracing.Abstractions.DependencyInjection.RegisterTracerOnStartup(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Myprysm.Tracing.Abstractions.TracerIdentity).services'></a>

`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')

The service collection.

<a name='Myprysm.Tracing.Abstractions.DependencyInjection.RegisterTracerOnStartup(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,Myprysm.Tracing.Abstractions.TracerIdentity).identity'></a>

`identity` [TracerIdentity](Myprysm.Tracing.Abstractions.TracerIdentity.md 'Myprysm.Tracing.Abstractions.TracerIdentity')

The tracer identity.

#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection.

<a name='Myprysm.Tracing.Abstractions.DependencyInjection.TryAddDefaultTracer(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection)'></a>

## DependencyInjection.TryAddDefaultTracer(this IServiceCollection) Method

Try to register a default noop tracer factory if no tracer factory has been already registered.

```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection TryAddDefaultTracer(this Microsoft.Extensions.DependencyInjection.IServiceCollection services);
```
#### Parameters

<a name='Myprysm.Tracing.Abstractions.DependencyInjection.TryAddDefaultTracer(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection).services'></a>

`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')

The service collection.

#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The service collection.