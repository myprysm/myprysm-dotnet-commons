#### [Myprysm.Tracing.Abstractions](index.md 'index')
### [Myprysm.Tracing.Abstractions](index.md#Myprysm_Tracing_Abstractions 'Myprysm.Tracing.Abstractions')
## TracerIdentity Class
Represents the identity of a [ITracer](Myprysm_Tracing_Abstractions_ITracer.md 'Myprysm.Tracing.Abstractions.ITracer'), usually for a single library.  
```csharp
public class TracerIdentity :
System.IEquatable<Myprysm.Tracing.Abstractions.TracerIdentity>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; TracerIdentity  

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[TracerIdentity](Myprysm_Tracing_Abstractions_TracerIdentity.md 'Myprysm.Tracing.Abstractions.TracerIdentity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')  
### Constructors
<a name='Myprysm_Tracing_Abstractions_TracerIdentity_TracerIdentity(string_string_)'></a>
## TracerIdentity.TracerIdentity(string, string?) Constructor
Represents the identity of a [ITracer](Myprysm_Tracing_Abstractions_ITracer.md 'Myprysm.Tracing.Abstractions.ITracer'), usually for a single library.  
```csharp
public TracerIdentity(string Name, string? Version);
```
#### Parameters
<a name='Myprysm_Tracing_Abstractions_TracerIdentity_TracerIdentity(string_string_)_Name'></a>
`Name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The name of the library.
  
<a name='Myprysm_Tracing_Abstractions_TracerIdentity_TracerIdentity(string_string_)_Version'></a>
`Version` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The version of the library.
  
  
