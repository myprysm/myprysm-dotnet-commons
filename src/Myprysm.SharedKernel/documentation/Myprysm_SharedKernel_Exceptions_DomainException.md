#### [Myprysm.SharedKernel](index.md 'index')
### [Myprysm.SharedKernel.Exceptions](index.md#Myprysm_SharedKernel_Exceptions 'Myprysm.SharedKernel.Exceptions')
## DomainException Class
Represents an exceptional case encountered as part of the domain of an application.  
  
You can an should specialize this exception when an unhandled case happens in your domain.  
```csharp
public class DomainException : Myprysm.SharedKernel.Exceptions.ManagedException
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') &#129106; [ManagedException](Myprysm_SharedKernel_Exceptions_ManagedException.md 'Myprysm.SharedKernel.Exceptions.ManagedException') &#129106; DomainException  

Derived  
&#8627; [ConflictException](Myprysm_SharedKernel_Exceptions_ConflictException.md 'Myprysm.SharedKernel.Exceptions.ConflictException')  
&#8627; [ForbiddenException](Myprysm_SharedKernel_Exceptions_ForbiddenException.md 'Myprysm.SharedKernel.Exceptions.ForbiddenException')  
&#8627; [NotFoundException](Myprysm_SharedKernel_Exceptions_NotFoundException.md 'Myprysm.SharedKernel.Exceptions.NotFoundException')  
&#8627; [ValidationException](Myprysm_SharedKernel_Exceptions_ValidationException.md 'Myprysm.SharedKernel.Exceptions.ValidationException')  
### Constructors
<a name='Myprysm_SharedKernel_Exceptions_DomainException_DomainException()'></a>
## DomainException.DomainException() Constructor
Creates an empty [DomainException](Myprysm_SharedKernel_Exceptions_DomainException.md 'Myprysm.SharedKernel.Exceptions.DomainException').  
```csharp
public DomainException();
```
  
<a name='Myprysm_SharedKernel_Exceptions_DomainException_DomainException(string_System_Exception)'></a>
## DomainException.DomainException(string, Exception) Constructor
Creates a new [DomainException](Myprysm_SharedKernel_Exceptions_DomainException.md 'Myprysm.SharedKernel.Exceptions.DomainException') with the provided message.  
```csharp
public DomainException(string message, System.Exception innerException);
```
#### Parameters
<a name='Myprysm_SharedKernel_Exceptions_DomainException_DomainException(string_System_Exception)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The reason of the conflict.
  
<a name='Myprysm_SharedKernel_Exceptions_DomainException_DomainException(string_System_Exception)_innerException'></a>
`innerException` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')  
The source exception of the conflict.
  
  
<a name='Myprysm_SharedKernel_Exceptions_DomainException_DomainException(string)'></a>
## DomainException.DomainException(string) Constructor
Creates a new [DomainException](Myprysm_SharedKernel_Exceptions_DomainException.md 'Myprysm.SharedKernel.Exceptions.DomainException') with the provided message.  
```csharp
public DomainException(string message);
```
#### Parameters
<a name='Myprysm_SharedKernel_Exceptions_DomainException_DomainException(string)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The reason of the conflict.
  
  
