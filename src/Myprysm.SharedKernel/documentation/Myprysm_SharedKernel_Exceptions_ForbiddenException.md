#### [Myprysm.SharedKernel](index.md 'index')
### [Myprysm.SharedKernel.Exceptions](index.md#Myprysm_SharedKernel_Exceptions 'Myprysm.SharedKernel.Exceptions')
## ForbiddenException Class
Represents an exceptional case when the current user cannot perform the requested procedure.  
```csharp
public class ForbiddenException : Myprysm.SharedKernel.Exceptions.DomainException
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') &#129106; [ManagedException](Myprysm_SharedKernel_Exceptions_ManagedException.md 'Myprysm.SharedKernel.Exceptions.ManagedException') &#129106; [DomainException](Myprysm_SharedKernel_Exceptions_DomainException.md 'Myprysm.SharedKernel.Exceptions.DomainException') &#129106; ForbiddenException  
### Constructors
<a name='Myprysm_SharedKernel_Exceptions_ForbiddenException_ForbiddenException()'></a>
## ForbiddenException.ForbiddenException() Constructor
Creates an empty [ForbiddenException](Myprysm_SharedKernel_Exceptions_ForbiddenException.md 'Myprysm.SharedKernel.Exceptions.ForbiddenException').  
```csharp
public ForbiddenException();
```
  
<a name='Myprysm_SharedKernel_Exceptions_ForbiddenException_ForbiddenException(string_System_Exception)'></a>
## ForbiddenException.ForbiddenException(string, Exception) Constructor
Creates a new [ForbiddenException](Myprysm_SharedKernel_Exceptions_ForbiddenException.md 'Myprysm.SharedKernel.Exceptions.ForbiddenException') with the provided message.  
```csharp
public ForbiddenException(string message, System.Exception innerException);
```
#### Parameters
<a name='Myprysm_SharedKernel_Exceptions_ForbiddenException_ForbiddenException(string_System_Exception)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The reason of the conflict.
  
<a name='Myprysm_SharedKernel_Exceptions_ForbiddenException_ForbiddenException(string_System_Exception)_innerException'></a>
`innerException` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')  
The source exception of the conflict.
  
  
<a name='Myprysm_SharedKernel_Exceptions_ForbiddenException_ForbiddenException(string)'></a>
## ForbiddenException.ForbiddenException(string) Constructor
Creates a new [ForbiddenException](Myprysm_SharedKernel_Exceptions_ForbiddenException.md 'Myprysm.SharedKernel.Exceptions.ForbiddenException') with the provided message.  
```csharp
public ForbiddenException(string message);
```
#### Parameters
<a name='Myprysm_SharedKernel_Exceptions_ForbiddenException_ForbiddenException(string)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The reason of the conflict.
  
  
