#### [Myprysm.SharedKernel](index.md 'index')
### [Myprysm.SharedKernel.Exceptions](index.md#Myprysm_SharedKernel_Exceptions 'Myprysm.SharedKernel.Exceptions')
## ManagedException Class
Represents an exceptional case that is considered to be managed in the context of the application.  
```csharp
public class ManagedException : System.Exception
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') &#129106; ManagedException  

Derived  
&#8627; [DomainException](Myprysm_SharedKernel_Exceptions_DomainException.md 'Myprysm.SharedKernel.Exceptions.DomainException')  
&#8627; [IllegalOperationException](Myprysm_SharedKernel_Exceptions_IllegalOperationException.md 'Myprysm.SharedKernel.Exceptions.IllegalOperationException')  
&#8627; [NotImplementedException](Myprysm_SharedKernel_Exceptions_NotImplementedException.md 'Myprysm.SharedKernel.Exceptions.NotImplementedException')  
### Constructors
<a name='Myprysm_SharedKernel_Exceptions_ManagedException_ManagedException()'></a>
## ManagedException.ManagedException() Constructor
Creates an empty [ManagedException](Myprysm_SharedKernel_Exceptions_ManagedException.md 'Myprysm.SharedKernel.Exceptions.ManagedException').  
```csharp
public ManagedException();
```
  
<a name='Myprysm_SharedKernel_Exceptions_ManagedException_ManagedException(string_System_Exception)'></a>
## ManagedException.ManagedException(string, Exception) Constructor
Creates a new [ManagedException](Myprysm_SharedKernel_Exceptions_ManagedException.md 'Myprysm.SharedKernel.Exceptions.ManagedException') with the provided message.  
```csharp
public ManagedException(string message, System.Exception innerException);
```
#### Parameters
<a name='Myprysm_SharedKernel_Exceptions_ManagedException_ManagedException(string_System_Exception)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The reason of the conflict.
  
<a name='Myprysm_SharedKernel_Exceptions_ManagedException_ManagedException(string_System_Exception)_innerException'></a>
`innerException` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')  
The source exception of the conflict.
  
  
<a name='Myprysm_SharedKernel_Exceptions_ManagedException_ManagedException(string)'></a>
## ManagedException.ManagedException(string) Constructor
Creates a new [ManagedException](Myprysm_SharedKernel_Exceptions_ManagedException.md 'Myprysm.SharedKernel.Exceptions.ManagedException') with the provided message.  
```csharp
public ManagedException(string message);
```
#### Parameters
<a name='Myprysm_SharedKernel_Exceptions_ManagedException_ManagedException(string)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The reason of the conflict.
  
  
