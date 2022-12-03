#### [Myprysm.SharedKernel](index.md 'index')
### [Myprysm.SharedKernel.Exceptions](index.md#Myprysm.SharedKernel.Exceptions 'Myprysm.SharedKernel.Exceptions')

## IllegalOperationException Class

Represents an illegal operation request in the current procedure.

```csharp
public class IllegalOperationException : Myprysm.SharedKernel.Exceptions.ManagedException
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') &#129106; [ManagedException](Myprysm.SharedKernel.Exceptions.ManagedException.md 'Myprysm.SharedKernel.Exceptions.ManagedException') &#129106; IllegalOperationException
### Constructors

<a name='Myprysm.SharedKernel.Exceptions.IllegalOperationException.IllegalOperationException()'></a>

## IllegalOperationException() Constructor

Creates an empty [IllegalOperationException](Myprysm.SharedKernel.Exceptions.IllegalOperationException.md 'Myprysm.SharedKernel.Exceptions.IllegalOperationException').

```csharp
public IllegalOperationException();
```

<a name='Myprysm.SharedKernel.Exceptions.IllegalOperationException.IllegalOperationException(string,System.Exception)'></a>

## IllegalOperationException(string, Exception) Constructor

Creates a new [IllegalOperationException](Myprysm.SharedKernel.Exceptions.IllegalOperationException.md 'Myprysm.SharedKernel.Exceptions.IllegalOperationException') with the provided message.

```csharp
public IllegalOperationException(string message, System.Exception innerException);
```
#### Parameters

<a name='Myprysm.SharedKernel.Exceptions.IllegalOperationException.IllegalOperationException(string,System.Exception).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The reason of the conflict.

<a name='Myprysm.SharedKernel.Exceptions.IllegalOperationException.IllegalOperationException(string,System.Exception).innerException'></a>

`innerException` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')

The source exception of the conflict.

<a name='Myprysm.SharedKernel.Exceptions.IllegalOperationException.IllegalOperationException(string)'></a>

## IllegalOperationException(string) Constructor

Creates a new [IllegalOperationException](Myprysm.SharedKernel.Exceptions.IllegalOperationException.md 'Myprysm.SharedKernel.Exceptions.IllegalOperationException') with the provided message.

```csharp
public IllegalOperationException(string message);
```
#### Parameters

<a name='Myprysm.SharedKernel.Exceptions.IllegalOperationException.IllegalOperationException(string).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The reason of the conflict.