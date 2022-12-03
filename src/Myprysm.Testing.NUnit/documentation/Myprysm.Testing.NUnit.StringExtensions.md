#### [Myprysm.Testing.NUnit](index.md 'index')
### [Myprysm.Testing.NUnit](index.md#Myprysm.Testing.NUnit 'Myprysm.Testing.NUnit')

## StringExtensions Class

String extensions useful for testing.

```csharp
public static class StringExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; StringExtensions
### Methods

<a name='Myprysm.Testing.NUnit.StringExtensions.GetFileStream(thisstring)'></a>

## StringExtensions.GetFileStream(this string) Method

Get the content of a file at the given path as a [System.IO.Stream](https://docs.microsoft.com/en-us/dotnet/api/System.IO.Stream 'System.IO.Stream').

```csharp
public static System.IO.Stream GetFileStream(this string path);
```
#### Parameters

<a name='Myprysm.Testing.NUnit.StringExtensions.GetFileStream(thisstring).path'></a>

`path` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The path of the file, absolute or relative to the current running project target.

#### Returns
[System.IO.Stream](https://docs.microsoft.com/en-us/dotnet/api/System.IO.Stream 'System.IO.Stream')  
The file as a [System.IO.Stream](https://docs.microsoft.com/en-us/dotnet/api/System.IO.Stream 'System.IO.Stream').

#### Exceptions

[System.IO.FileNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/System.IO.FileNotFoundException 'System.IO.FileNotFoundException')  
When the file does not exist at the given path.