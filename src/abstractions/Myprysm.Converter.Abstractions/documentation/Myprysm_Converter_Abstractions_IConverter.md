#### [Myprysm.Converter.Abstractions](index.md 'index')
### [Myprysm.Converter.Abstractions](index.md#Myprysm_Converter_Abstractions 'Myprysm.Converter.Abstractions')
## IConverter Interface
Represents a converter from binary to object representation and vice-versa.  
```csharp
public interface IConverter
```
### Fields
<a name='Myprysm_Converter_Abstractions_IConverter_DefaultEncoding'></a>
## IConverter.DefaultEncoding Field
The default encoding for string conversions.  
```csharp
static readonly Encoding DefaultEncoding;
```
#### Field Value
[System.Text.Encoding](https://docs.microsoft.com/en-us/dotnet/api/System.Text.Encoding 'System.Text.Encoding')
  
### Methods
<a name='Myprysm_Converter_Abstractions_IConverter_Convert(object_System_Type)'></a>
## IConverter.Convert(object, Type) Method
Convert the data to the requested type.  
```csharp
object? Convert(object data, System.Type type);
```
#### Parameters
<a name='Myprysm_Converter_Abstractions_IConverter_Convert(object_System_Type)_data'></a>
`data` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The data to convert.
  
<a name='Myprysm_Converter_Abstractions_IConverter_Convert(object_System_Type)_type'></a>
`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
The destination type.
  
#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
An optional object of the requested type.
#### Exceptions
[ConversionReadException](Myprysm_Converter_Abstractions_Exceptions_ConversionReadException.md 'Myprysm.Converter.Abstractions.Exceptions.ConversionReadException')  
When the converter cannot read the data.
[ConversionWriteException](Myprysm_Converter_Abstractions_Exceptions_ConversionWriteException.md 'Myprysm.Converter.Abstractions.Exceptions.ConversionWriteException')  
When the converter cannot write the data.
  
<a name='Myprysm_Converter_Abstractions_IConverter_Convert_TObj_(object)'></a>
## IConverter.Convert&lt;TObj&gt;(object) Method
Convert the data to the requested type.  
```csharp
TObj? Convert<TObj>(object data);
```
#### Type parameters
<a name='Myprysm_Converter_Abstractions_IConverter_Convert_TObj_(object)_TObj'></a>
`TObj`  
The destination type.
  
#### Parameters
<a name='Myprysm_Converter_Abstractions_IConverter_Convert_TObj_(object)_data'></a>
`data` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The data to convert.
  
#### Returns
[TObj](Myprysm_Converter_Abstractions_IConverter.md#Myprysm_Converter_Abstractions_IConverter_Convert_TObj_(object)_TObj 'Myprysm.Converter.Abstractions.IConverter.Convert&lt;TObj&gt;(object).TObj')  
An optional object of the requested type.
#### Exceptions
[ConversionReadException](Myprysm_Converter_Abstractions_Exceptions_ConversionReadException.md 'Myprysm.Converter.Abstractions.Exceptions.ConversionReadException')  
When the converter cannot read the data.
[ConversionWriteException](Myprysm_Converter_Abstractions_Exceptions_ConversionWriteException.md 'Myprysm.Converter.Abstractions.Exceptions.ConversionWriteException')  
When the converter cannot write the data.
  
<a name='Myprysm_Converter_Abstractions_IConverter_Read(byte___System_Type)'></a>
## IConverter.Read(byte[], Type) Method
Read the byte array and returns optionally an object of the provided type.   
```csharp
object? Read(byte[] data, System.Type type);
```
#### Parameters
<a name='Myprysm_Converter_Abstractions_IConverter_Read(byte___System_Type)_data'></a>
`data` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The byte array.
  
<a name='Myprysm_Converter_Abstractions_IConverter_Read(byte___System_Type)_type'></a>
`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
The type of the data.
  
#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
An optional object of the provided type.
#### Exceptions
[ConversionReadException](Myprysm_Converter_Abstractions_Exceptions_ConversionReadException.md 'Myprysm.Converter.Abstractions.Exceptions.ConversionReadException')  
When the converter cannot read the data.
  
<a name='Myprysm_Converter_Abstractions_IConverter_Read(string_System_Type)'></a>
## IConverter.Read(string, Type) Method
Read the stream and returns optionally an object of the provided type.   
```csharp
object? Read(string data, System.Type type);
```
#### Parameters
<a name='Myprysm_Converter_Abstractions_IConverter_Read(string_System_Type)_data'></a>
`data` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The stream.
  
<a name='Myprysm_Converter_Abstractions_IConverter_Read(string_System_Type)_type'></a>
`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
The type of the data.
  
#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
An optional object of the provided type.
#### Exceptions
[ConversionReadException](Myprysm_Converter_Abstractions_Exceptions_ConversionReadException.md 'Myprysm.Converter.Abstractions.Exceptions.ConversionReadException')  
When the converter cannot read the data.
  
<a name='Myprysm_Converter_Abstractions_IConverter_Read(System_IO_Stream_System_Type)'></a>
## IConverter.Read(Stream, Type) Method
Read the data stream and returns optionally an object of the provided type.   
```csharp
object? Read(System.IO.Stream data, System.Type type);
```
#### Parameters
<a name='Myprysm_Converter_Abstractions_IConverter_Read(System_IO_Stream_System_Type)_data'></a>
`data` [System.IO.Stream](https://docs.microsoft.com/en-us/dotnet/api/System.IO.Stream 'System.IO.Stream')  
The data stream.
  
<a name='Myprysm_Converter_Abstractions_IConverter_Read(System_IO_Stream_System_Type)_type'></a>
`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')  
The type of the data.
  
#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
An optional object of the provided type.
#### Exceptions
[ConversionReadException](Myprysm_Converter_Abstractions_Exceptions_ConversionReadException.md 'Myprysm.Converter.Abstractions.Exceptions.ConversionReadException')  
When the converter cannot read the data.
  
<a name='Myprysm_Converter_Abstractions_IConverter_Read_TObj_(byte__)'></a>
## IConverter.Read&lt;TObj&gt;(byte[]) Method
Read the byte array and returns optionally an object of the provided type.   
```csharp
TObj? Read<TObj>(byte[] data);
```
#### Type parameters
<a name='Myprysm_Converter_Abstractions_IConverter_Read_TObj_(byte__)_TObj'></a>
`TObj`  
The type of the data.
  
#### Parameters
<a name='Myprysm_Converter_Abstractions_IConverter_Read_TObj_(byte__)_data'></a>
`data` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The byte array.
  
#### Returns
[TObj](Myprysm_Converter_Abstractions_IConverter.md#Myprysm_Converter_Abstractions_IConverter_Read_TObj_(byte__)_TObj 'Myprysm.Converter.Abstractions.IConverter.Read&lt;TObj&gt;(byte[]).TObj')  
An optional object of the provided type.
#### Exceptions
[ConversionReadException](Myprysm_Converter_Abstractions_Exceptions_ConversionReadException.md 'Myprysm.Converter.Abstractions.Exceptions.ConversionReadException')  
When the converter cannot read the data.
  
<a name='Myprysm_Converter_Abstractions_IConverter_Read_TObj_(string)'></a>
## IConverter.Read&lt;TObj&gt;(string) Method
Read the string and returns optionally an object of the provided type.   
```csharp
TObj? Read<TObj>(string data);
```
#### Type parameters
<a name='Myprysm_Converter_Abstractions_IConverter_Read_TObj_(string)_TObj'></a>
`TObj`  
The type of the data.
  
#### Parameters
<a name='Myprysm_Converter_Abstractions_IConverter_Read_TObj_(string)_data'></a>
`data` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The string.
  
#### Returns
[TObj](Myprysm_Converter_Abstractions_IConverter.md#Myprysm_Converter_Abstractions_IConverter_Read_TObj_(string)_TObj 'Myprysm.Converter.Abstractions.IConverter.Read&lt;TObj&gt;(string).TObj')  
An optional object of the provided type.
#### Exceptions
[ConversionReadException](Myprysm_Converter_Abstractions_Exceptions_ConversionReadException.md 'Myprysm.Converter.Abstractions.Exceptions.ConversionReadException')  
When the converter cannot read the data.
  
<a name='Myprysm_Converter_Abstractions_IConverter_Read_TObj_(System_IO_Stream)'></a>
## IConverter.Read&lt;TObj&gt;(Stream) Method
Read the data stream and returns optionally an object of the provided type.   
```csharp
TObj? Read<TObj>(System.IO.Stream data);
```
#### Type parameters
<a name='Myprysm_Converter_Abstractions_IConverter_Read_TObj_(System_IO_Stream)_TObj'></a>
`TObj`  
The type of the data.
  
#### Parameters
<a name='Myprysm_Converter_Abstractions_IConverter_Read_TObj_(System_IO_Stream)_data'></a>
`data` [System.IO.Stream](https://docs.microsoft.com/en-us/dotnet/api/System.IO.Stream 'System.IO.Stream')  
The data stream.
  
#### Returns
[TObj](Myprysm_Converter_Abstractions_IConverter.md#Myprysm_Converter_Abstractions_IConverter_Read_TObj_(System_IO_Stream)_TObj 'Myprysm.Converter.Abstractions.IConverter.Read&lt;TObj&gt;(System.IO.Stream).TObj')  
An optional object of the provided type.
#### Exceptions
[ConversionReadException](Myprysm_Converter_Abstractions_Exceptions_ConversionReadException.md 'Myprysm.Converter.Abstractions.Exceptions.ConversionReadException')  
When the converter cannot read the data.
  
<a name='Myprysm_Converter_Abstractions_IConverter_WriteBytes(object_)'></a>
## IConverter.WriteBytes(object?) Method
Write the data as a byte array representation.  
```csharp
byte[] WriteBytes(object? data);
```
#### Parameters
<a name='Myprysm_Converter_Abstractions_IConverter_WriteBytes(object_)_data'></a>
`data` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The data to write.
  
#### Returns
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The byte array representation of the data.
#### Exceptions
[ConversionWriteException](Myprysm_Converter_Abstractions_Exceptions_ConversionWriteException.md 'Myprysm.Converter.Abstractions.Exceptions.ConversionWriteException')  
When the converter cannot write the data.
  
<a name='Myprysm_Converter_Abstractions_IConverter_WriteString(object_)'></a>
## IConverter.WriteString(object?) Method
Write the data as a string representation.  
```csharp
string WriteString(object? data);
```
#### Parameters
<a name='Myprysm_Converter_Abstractions_IConverter_WriteString(object_)_data'></a>
`data` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The data to write.
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The string representation of the data.
#### Exceptions
[ConversionWriteException](Myprysm_Converter_Abstractions_Exceptions_ConversionWriteException.md 'Myprysm.Converter.Abstractions.Exceptions.ConversionWriteException')  
When the converter cannot write the data.
  
<a name='Myprysm_Converter_Abstractions_IConverter_WriteToStream(object__System_IO_Stream)'></a>
## IConverter.WriteToStream(object?, Stream) Method
Write the data to the provided stream.  
```csharp
void WriteToStream(object? data, System.IO.Stream stream);
```
#### Parameters
<a name='Myprysm_Converter_Abstractions_IConverter_WriteToStream(object__System_IO_Stream)_data'></a>
`data` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The data to write.
  
<a name='Myprysm_Converter_Abstractions_IConverter_WriteToStream(object__System_IO_Stream)_stream'></a>
`stream` [System.IO.Stream](https://docs.microsoft.com/en-us/dotnet/api/System.IO.Stream 'System.IO.Stream')  
The stream to write the data into.
  
#### Exceptions
[ConversionWriteException](Myprysm_Converter_Abstractions_Exceptions_ConversionWriteException.md 'Myprysm.Converter.Abstractions.Exceptions.ConversionWriteException')  
When the converter cannot write the data.
### Remarks
The stream should not be disposed, the position should not be changed after writing.  
  
