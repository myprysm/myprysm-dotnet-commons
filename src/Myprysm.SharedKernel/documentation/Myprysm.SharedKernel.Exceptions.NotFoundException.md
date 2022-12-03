#### [Myprysm.SharedKernel](index.md 'index')
### [Myprysm.SharedKernel.Exceptions](index.md#Myprysm.SharedKernel.Exceptions 'Myprysm.SharedKernel.Exceptions')

## NotFoundException Class

Represents an exceptional case when a resource could not be found during a procedure.

```csharp
public class NotFoundException : Myprysm.SharedKernel.Exceptions.DomainException
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') &#129106; [ManagedException](Myprysm.SharedKernel.Exceptions.ManagedException.md 'Myprysm.SharedKernel.Exceptions.ManagedException') &#129106; [DomainException](Myprysm.SharedKernel.Exceptions.DomainException.md 'Myprysm.SharedKernel.Exceptions.DomainException') &#129106; NotFoundException
### Constructors

<a name='Myprysm.SharedKernel.Exceptions.NotFoundException.NotFoundException()'></a>

## NotFoundException() Constructor

Creates an empty [NotFoundException](Myprysm.SharedKernel.Exceptions.NotFoundException.md 'Myprysm.SharedKernel.Exceptions.NotFoundException').

```csharp
public NotFoundException();
```

<a name='Myprysm.SharedKernel.Exceptions.NotFoundException.NotFoundException(string,object)'></a>

## NotFoundException(string, object) Constructor

Creates a new [NotFoundException](Myprysm.SharedKernel.Exceptions.NotFoundException.md 'Myprysm.SharedKernel.Exceptions.NotFoundException') with the provided message.

```csharp
public NotFoundException(string name, object key);
```
#### Parameters

<a name='Myprysm.SharedKernel.Exceptions.NotFoundException.NotFoundException(string,object).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the entity that could not be found.

<a name='Myprysm.SharedKernel.Exceptions.NotFoundException.NotFoundException(string,object).key'></a>

`key` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The key that threw the exception for the entity.

<a name='Myprysm.SharedKernel.Exceptions.NotFoundException.NotFoundException(string,System.Exception)'></a>

## NotFoundException(string, Exception) Constructor

Creates a new [NotFoundException](Myprysm.SharedKernel.Exceptions.NotFoundException.md 'Myprysm.SharedKernel.Exceptions.NotFoundException') with the provided message.

```csharp
public NotFoundException(string message, System.Exception innerException);
```
#### Parameters

<a name='Myprysm.SharedKernel.Exceptions.NotFoundException.NotFoundException(string,System.Exception).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The reason of the conflict.

<a name='Myprysm.SharedKernel.Exceptions.NotFoundException.NotFoundException(string,System.Exception).innerException'></a>

`innerException` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')

The source exception of the conflict.

<a name='Myprysm.SharedKernel.Exceptions.NotFoundException.NotFoundException(string)'></a>

## NotFoundException(string) Constructor

Creates a new [NotFoundException](Myprysm.SharedKernel.Exceptions.NotFoundException.md 'Myprysm.SharedKernel.Exceptions.NotFoundException') with the provided message.

```csharp
public NotFoundException(string message);
```
#### Parameters

<a name='Myprysm.SharedKernel.Exceptions.NotFoundException.NotFoundException(string).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The reason of the conflict.