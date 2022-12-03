#### [Myprysm.Converter.Abstractions](index.md 'index')
### [Myprysm.Converter.Abstractions.Exceptions](index.md#Myprysm.Converter.Abstractions.Exceptions 'Myprysm.Converter.Abstractions.Exceptions')

## ConversionReadException Class

Exception thrown when an [IConverter](Myprysm.Converter.Abstractions.IConverter.md 'Myprysm.Converter.Abstractions.IConverter') cannot read data.

```csharp
public class ConversionReadException : Myprysm.SharedKernel.Exceptions.ManagedException
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') &#129106; [Myprysm.SharedKernel.Exceptions.ManagedException](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.SharedKernel.Exceptions.ManagedException 'Myprysm.SharedKernel.Exceptions.ManagedException') &#129106; ConversionReadException
### Constructors

<a name='Myprysm.Converter.Abstractions.Exceptions.ConversionReadException.ConversionReadException(string,System.Exception)'></a>

## ConversionReadException(string, Exception) Constructor

Create a new [ConversionReadException](Myprysm.Converter.Abstractions.Exceptions.ConversionReadException.md 'Myprysm.Converter.Abstractions.Exceptions.ConversionReadException') with the provided message and base exception.

```csharp
public ConversionReadException(string message, System.Exception baseException);
```
#### Parameters

<a name='Myprysm.Converter.Abstractions.Exceptions.ConversionReadException.ConversionReadException(string,System.Exception).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The message.

<a name='Myprysm.Converter.Abstractions.Exceptions.ConversionReadException.ConversionReadException(string,System.Exception).baseException'></a>

`baseException` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')

The base exception.

<a name='Myprysm.Converter.Abstractions.Exceptions.ConversionReadException.ConversionReadException(string)'></a>

## ConversionReadException(string) Constructor

Create a new [ConversionReadException](Myprysm.Converter.Abstractions.Exceptions.ConversionReadException.md 'Myprysm.Converter.Abstractions.Exceptions.ConversionReadException') with the provided message.

```csharp
public ConversionReadException(string message);
```
#### Parameters

<a name='Myprysm.Converter.Abstractions.Exceptions.ConversionReadException.ConversionReadException(string).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The message.