#### [Myprysm.SharedKernel](index.md 'index')
### [Myprysm.SharedKernel.Exceptions](index.md#Myprysm.SharedKernel.Exceptions 'Myprysm.SharedKernel.Exceptions')

## ConflictException Class

Represents an exceptional case  
when a conflict occurs while processing a resource.  
  
The conflict can be of any source, e.g. a resource version lock check failed  
or an identical resource got created/updated at the same time.

```csharp
public class ConflictException : Myprysm.SharedKernel.Exceptions.DomainException
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') &#129106; [ManagedException](Myprysm.SharedKernel.Exceptions.ManagedException.md 'Myprysm.SharedKernel.Exceptions.ManagedException') &#129106; [DomainException](Myprysm.SharedKernel.Exceptions.DomainException.md 'Myprysm.SharedKernel.Exceptions.DomainException') &#129106; ConflictException
### Constructors

<a name='Myprysm.SharedKernel.Exceptions.ConflictException.ConflictException()'></a>

## ConflictException() Constructor

Creates an empty [ConflictException](Myprysm.SharedKernel.Exceptions.ConflictException.md 'Myprysm.SharedKernel.Exceptions.ConflictException').

```csharp
public ConflictException();
```

<a name='Myprysm.SharedKernel.Exceptions.ConflictException.ConflictException(string,System.Exception)'></a>

## ConflictException(string, Exception) Constructor

Creates a new [ConflictException](Myprysm.SharedKernel.Exceptions.ConflictException.md 'Myprysm.SharedKernel.Exceptions.ConflictException') with the provided message.

```csharp
public ConflictException(string message, System.Exception innerException);
```
#### Parameters

<a name='Myprysm.SharedKernel.Exceptions.ConflictException.ConflictException(string,System.Exception).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The reason of the conflict.

<a name='Myprysm.SharedKernel.Exceptions.ConflictException.ConflictException(string,System.Exception).innerException'></a>

`innerException` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')

The source exception of the conflict.

<a name='Myprysm.SharedKernel.Exceptions.ConflictException.ConflictException(string)'></a>

## ConflictException(string) Constructor

Creates a new [ConflictException](Myprysm.SharedKernel.Exceptions.ConflictException.md 'Myprysm.SharedKernel.Exceptions.ConflictException') with the provided message.

```csharp
public ConflictException(string message);
```
#### Parameters

<a name='Myprysm.SharedKernel.Exceptions.ConflictException.ConflictException(string).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The reason of the conflict.