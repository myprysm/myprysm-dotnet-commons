#### [Myprysm.SharedKernel](index.md 'index')
### [Myprysm.SharedKernel.Exceptions](index.md#Myprysm.SharedKernel.Exceptions 'Myprysm.SharedKernel.Exceptions')

## ForbiddenException Class

Represents an exceptional case when the current user cannot perform the requested procedure.

```csharp
public class ForbiddenException : Myprysm.SharedKernel.Exceptions.DomainException
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') &#129106; [ManagedException](Myprysm.SharedKernel.Exceptions.ManagedException.md 'Myprysm.SharedKernel.Exceptions.ManagedException') &#129106; [DomainException](Myprysm.SharedKernel.Exceptions.DomainException.md 'Myprysm.SharedKernel.Exceptions.DomainException') &#129106; ForbiddenException
### Constructors

<a name='Myprysm.SharedKernel.Exceptions.ForbiddenException.ForbiddenException()'></a>

## ForbiddenException() Constructor

Creates an empty [ForbiddenException](Myprysm.SharedKernel.Exceptions.ForbiddenException.md 'Myprysm.SharedKernel.Exceptions.ForbiddenException').

```csharp
public ForbiddenException();
```

<a name='Myprysm.SharedKernel.Exceptions.ForbiddenException.ForbiddenException(string,System.Exception)'></a>

## ForbiddenException(string, Exception) Constructor

Creates a new [ForbiddenException](Myprysm.SharedKernel.Exceptions.ForbiddenException.md 'Myprysm.SharedKernel.Exceptions.ForbiddenException') with the provided message.

```csharp
public ForbiddenException(string message, System.Exception innerException);
```
#### Parameters

<a name='Myprysm.SharedKernel.Exceptions.ForbiddenException.ForbiddenException(string,System.Exception).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The reason of the conflict.

<a name='Myprysm.SharedKernel.Exceptions.ForbiddenException.ForbiddenException(string,System.Exception).innerException'></a>

`innerException` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')

The source exception of the conflict.

<a name='Myprysm.SharedKernel.Exceptions.ForbiddenException.ForbiddenException(string)'></a>

## ForbiddenException(string) Constructor

Creates a new [ForbiddenException](Myprysm.SharedKernel.Exceptions.ForbiddenException.md 'Myprysm.SharedKernel.Exceptions.ForbiddenException') with the provided message.

```csharp
public ForbiddenException(string message);
```
#### Parameters

<a name='Myprysm.SharedKernel.Exceptions.ForbiddenException.ForbiddenException(string).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The reason of the conflict.