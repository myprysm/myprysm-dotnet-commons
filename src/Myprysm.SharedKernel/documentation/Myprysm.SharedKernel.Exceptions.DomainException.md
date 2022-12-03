#### [Myprysm.SharedKernel](index.md 'index')
### [Myprysm.SharedKernel.Exceptions](index.md#Myprysm.SharedKernel.Exceptions 'Myprysm.SharedKernel.Exceptions')

## DomainException Class

Represents an exceptional case encountered as part of the domain of an application.  
  
You can an should specialize this exception when an unhandled case happens in your domain.

```csharp
public class DomainException : Myprysm.SharedKernel.Exceptions.ManagedException
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') &#129106; [ManagedException](Myprysm.SharedKernel.Exceptions.ManagedException.md 'Myprysm.SharedKernel.Exceptions.ManagedException') &#129106; DomainException

Derived  
&#8627; [ConflictException](Myprysm.SharedKernel.Exceptions.ConflictException.md 'Myprysm.SharedKernel.Exceptions.ConflictException')  
&#8627; [ForbiddenException](Myprysm.SharedKernel.Exceptions.ForbiddenException.md 'Myprysm.SharedKernel.Exceptions.ForbiddenException')  
&#8627; [NotFoundException](Myprysm.SharedKernel.Exceptions.NotFoundException.md 'Myprysm.SharedKernel.Exceptions.NotFoundException')  
&#8627; [ValidationException](Myprysm.SharedKernel.Exceptions.ValidationException.md 'Myprysm.SharedKernel.Exceptions.ValidationException')
### Constructors

<a name='Myprysm.SharedKernel.Exceptions.DomainException.DomainException()'></a>

## DomainException() Constructor

Creates an empty [DomainException](Myprysm.SharedKernel.Exceptions.DomainException.md 'Myprysm.SharedKernel.Exceptions.DomainException').

```csharp
public DomainException();
```

<a name='Myprysm.SharedKernel.Exceptions.DomainException.DomainException(string,System.Exception)'></a>

## DomainException(string, Exception) Constructor

Creates a new [DomainException](Myprysm.SharedKernel.Exceptions.DomainException.md 'Myprysm.SharedKernel.Exceptions.DomainException') with the provided message.

```csharp
public DomainException(string message, System.Exception innerException);
```
#### Parameters

<a name='Myprysm.SharedKernel.Exceptions.DomainException.DomainException(string,System.Exception).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The reason of the conflict.

<a name='Myprysm.SharedKernel.Exceptions.DomainException.DomainException(string,System.Exception).innerException'></a>

`innerException` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')

The source exception of the conflict.

<a name='Myprysm.SharedKernel.Exceptions.DomainException.DomainException(string)'></a>

## DomainException(string) Constructor

Creates a new [DomainException](Myprysm.SharedKernel.Exceptions.DomainException.md 'Myprysm.SharedKernel.Exceptions.DomainException') with the provided message.

```csharp
public DomainException(string message);
```
#### Parameters

<a name='Myprysm.SharedKernel.Exceptions.DomainException.DomainException(string).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The reason of the conflict.