#### [Myprysm.Converter.Abstractions](index.md 'index')
### [Myprysm.Converter.Abstractions.Exceptions](index.md#Myprysm_Converter_Abstractions_Exceptions 'Myprysm.Converter.Abstractions.Exceptions')
## ConversionReadException Class
Exception thrown when an [IConverter](Myprysm_Converter_Abstractions_IConverter.md 'Myprysm.Converter.Abstractions.IConverter') cannot read data.  
```csharp
public class ConversionReadException : Myprysm.SharedKernel.Exceptions.ManagedException
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') &#129106; [Myprysm.SharedKernel.Exceptions.ManagedException](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.SharedKernel.Exceptions.ManagedException 'Myprysm.SharedKernel.Exceptions.ManagedException') &#129106; ConversionReadException  
### Constructors
<a name='Myprysm_Converter_Abstractions_Exceptions_ConversionReadException_ConversionReadException(string_System_Exception)'></a>
## ConversionReadException.ConversionReadException(string, Exception) Constructor
Create a new [ConversionReadException](Myprysm_Converter_Abstractions_Exceptions_ConversionReadException.md 'Myprysm.Converter.Abstractions.Exceptions.ConversionReadException') with the provided message and base exception.  
```csharp
public ConversionReadException(string message, System.Exception baseException);
```
#### Parameters
<a name='Myprysm_Converter_Abstractions_Exceptions_ConversionReadException_ConversionReadException(string_System_Exception)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The message.
  
<a name='Myprysm_Converter_Abstractions_Exceptions_ConversionReadException_ConversionReadException(string_System_Exception)_baseException'></a>
`baseException` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')  
The base exception.
  
  
<a name='Myprysm_Converter_Abstractions_Exceptions_ConversionReadException_ConversionReadException(string)'></a>
## ConversionReadException.ConversionReadException(string) Constructor
Create a new [ConversionReadException](Myprysm_Converter_Abstractions_Exceptions_ConversionReadException.md 'Myprysm.Converter.Abstractions.Exceptions.ConversionReadException') with the provided message.  
```csharp
public ConversionReadException(string message);
```
#### Parameters
<a name='Myprysm_Converter_Abstractions_Exceptions_ConversionReadException_ConversionReadException(string)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The message.
  
  
