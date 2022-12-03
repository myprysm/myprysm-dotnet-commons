#### [Myprysm.SharedKernel](index.md 'index')
### [Myprysm.SharedKernel.Exceptions](index.md#Myprysm.SharedKernel.Exceptions 'Myprysm.SharedKernel.Exceptions')

## ManagedException Class

Represents an exceptional case that is considered to be managed in the context of the application.

```csharp
public class ManagedException : System.Exception
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') &#129106; ManagedException

Derived  
&#8627; [DomainException](Myprysm.SharedKernel.Exceptions.DomainException.md 'Myprysm.SharedKernel.Exceptions.DomainException')  
&#8627; [IllegalOperationException](Myprysm.SharedKernel.Exceptions.IllegalOperationException.md 'Myprysm.SharedKernel.Exceptions.IllegalOperationException')  
&#8627; [NotImplementedException](Myprysm.SharedKernel.Exceptions.NotImplementedException.md 'Myprysm.SharedKernel.Exceptions.NotImplementedException')
### Constructors

<a name='Myprysm.SharedKernel.Exceptions.ManagedException.ManagedException()'></a>

## ManagedException() Constructor

Creates an empty [ManagedException](Myprysm.SharedKernel.Exceptions.ManagedException.md 'Myprysm.SharedKernel.Exceptions.ManagedException').

```csharp
public ManagedException();
```

<a name='Myprysm.SharedKernel.Exceptions.ManagedException.ManagedException(string,System.Exception)'></a>

## ManagedException(string, Exception) Constructor

Creates a new [ManagedException](Myprysm.SharedKernel.Exceptions.ManagedException.md 'Myprysm.SharedKernel.Exceptions.ManagedException') with the provided message.

```csharp
public ManagedException(string message, System.Exception innerException);
```
#### Parameters

<a name='Myprysm.SharedKernel.Exceptions.ManagedException.ManagedException(string,System.Exception).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The reason of the conflict.

<a name='Myprysm.SharedKernel.Exceptions.ManagedException.ManagedException(string,System.Exception).innerException'></a>

`innerException` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')

The source exception of the conflict.

<a name='Myprysm.SharedKernel.Exceptions.ManagedException.ManagedException(string)'></a>

## ManagedException(string) Constructor

Creates a new [ManagedException](Myprysm.SharedKernel.Exceptions.ManagedException.md 'Myprysm.SharedKernel.Exceptions.ManagedException') with the provided message.

```csharp
public ManagedException(string message);
```
#### Parameters

<a name='Myprysm.SharedKernel.Exceptions.ManagedException.ManagedException(string).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The reason of the conflict.