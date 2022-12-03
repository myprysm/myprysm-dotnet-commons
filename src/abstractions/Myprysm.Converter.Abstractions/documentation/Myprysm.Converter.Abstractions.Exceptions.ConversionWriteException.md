#### [Myprysm.Converter.Abstractions](index.md 'index')
### [Myprysm.Converter.Abstractions.Exceptions](index.md#Myprysm.Converter.Abstractions.Exceptions 'Myprysm.Converter.Abstractions.Exceptions')

## ConversionWriteException Class

Exception thrown when an [IConverter](Myprysm.Converter.Abstractions.IConverter.md 'Myprysm.Converter.Abstractions.IConverter') cannot write data.

```csharp
public class ConversionWriteException : Myprysm.SharedKernel.Exceptions.ManagedException
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') &#129106; [Myprysm.SharedKernel.Exceptions.ManagedException](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.SharedKernel.Exceptions.ManagedException 'Myprysm.SharedKernel.Exceptions.ManagedException') &#129106; ConversionWriteException
### Constructors

<a name='Myprysm.Converter.Abstractions.Exceptions.ConversionWriteException.ConversionWriteException(string,System.Exception)'></a>

## ConversionWriteException(string, Exception) Constructor

Create a new [ConversionWriteException](Myprysm.Converter.Abstractions.Exceptions.ConversionWriteException.md 'Myprysm.Converter.Abstractions.Exceptions.ConversionWriteException') with the provided message and base exception.

```csharp
public ConversionWriteException(string message, System.Exception baseException);
```
#### Parameters

<a name='Myprysm.Converter.Abstractions.Exceptions.ConversionWriteException.ConversionWriteException(string,System.Exception).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The message.

<a name='Myprysm.Converter.Abstractions.Exceptions.ConversionWriteException.ConversionWriteException(string,System.Exception).baseException'></a>

`baseException` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')

The base exception.

<a name='Myprysm.Converter.Abstractions.Exceptions.ConversionWriteException.ConversionWriteException(string)'></a>

## ConversionWriteException(string) Constructor

Create a new [ConversionWriteException](Myprysm.Converter.Abstractions.Exceptions.ConversionWriteException.md 'Myprysm.Converter.Abstractions.Exceptions.ConversionWriteException') with the provided message.

```csharp
public ConversionWriteException(string message);
```
#### Parameters

<a name='Myprysm.Converter.Abstractions.Exceptions.ConversionWriteException.ConversionWriteException(string).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The message.