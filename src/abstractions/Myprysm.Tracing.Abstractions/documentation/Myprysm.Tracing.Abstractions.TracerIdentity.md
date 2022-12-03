#### [Myprysm.Tracing.Abstractions](index.md 'index')
### [Myprysm.Tracing.Abstractions](index.md#Myprysm.Tracing.Abstractions 'Myprysm.Tracing.Abstractions')

## TracerIdentity Class

Represents the identity of a [ITracer](Myprysm.Tracing.Abstractions.ITracer.md 'Myprysm.Tracing.Abstractions.ITracer'), usually for a single library.

```csharp
public class TracerIdentity :
System.IEquatable<Myprysm.Tracing.Abstractions.TracerIdentity>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; TracerIdentity

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[TracerIdentity](Myprysm.Tracing.Abstractions.TracerIdentity.md 'Myprysm.Tracing.Abstractions.TracerIdentity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')
### Constructors

<a name='Myprysm.Tracing.Abstractions.TracerIdentity.TracerIdentity(string,string)'></a>

## TracerIdentity(string, string) Constructor

Represents the identity of a [ITracer](Myprysm.Tracing.Abstractions.ITracer.md 'Myprysm.Tracing.Abstractions.ITracer'), usually for a single library.

```csharp
public TracerIdentity(string Name, string? Version);
```
#### Parameters

<a name='Myprysm.Tracing.Abstractions.TracerIdentity.TracerIdentity(string,string).Name'></a>

`Name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the library.

<a name='Myprysm.Tracing.Abstractions.TracerIdentity.TracerIdentity(string,string).Version'></a>

`Version` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The version of the library.
### Properties

<a name='Myprysm.Tracing.Abstractions.TracerIdentity.Name'></a>

## TracerIdentity.Name Property

The name of the library.

```csharp
public string Name { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='Myprysm.Tracing.Abstractions.TracerIdentity.Version'></a>

## TracerIdentity.Version Property

The version of the library.

```csharp
public string? Version { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')