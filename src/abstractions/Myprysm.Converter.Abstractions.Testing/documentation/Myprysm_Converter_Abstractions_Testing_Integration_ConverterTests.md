#### [Myprysm.Converter.Abstractions.Testing](index.md 'index')
### [Myprysm.Converter.Abstractions.Testing.Integration](index.md#Myprysm_Converter_Abstractions_Testing_Integration 'Myprysm.Converter.Abstractions.Testing.Integration')
## ConverterTests Class
Base test suite for [Myprysm.Converter.Abstractions.IConverter](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Converter.Abstractions.IConverter 'Myprysm.Converter.Abstractions.IConverter').  
```csharp
public abstract class ConverterTests : Myprysm.Testing.NUnit.ServiceTests
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Myprysm.Testing.NUnit.FixtureTests](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Testing.NUnit.FixtureTests 'Myprysm.Testing.NUnit.FixtureTests') &#129106; [Myprysm.Testing.NUnit.ServiceTests](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Testing.NUnit.ServiceTests 'Myprysm.Testing.NUnit.ServiceTests') &#129106; ConverterTests  
### Methods
<a name='Myprysm_Converter_Abstractions_Testing_Integration_ConverterTests_CanReadShape_FromConverterWriteBytes()'></a>
## ConverterTests.CanReadShape_FromConverterWriteBytes() Method
You should ensure that given a [Shape](Myprysm_Converter_Abstractions_Testing_Integration_ConverterTests_Shape.md 'Myprysm.Converter.Abstractions.Testing.Integration.ConverterTests.Shape'),  
When the [Shape](Myprysm_Converter_Abstractions_Testing_Integration_ConverterTests_Shape.md 'Myprysm.Converter.Abstractions.Testing.Integration.ConverterTests.Shape') is serialized to byte array  
And the byte array is read as a [Shape](Myprysm_Converter_Abstractions_Testing_Integration_ConverterTests_Shape.md 'Myprysm.Converter.Abstractions.Testing.Integration.ConverterTests.Shape')  
Then both shapes are equivalent.  
```csharp
public void CanReadShape_FromConverterWriteBytes();
```
  
<a name='Myprysm_Converter_Abstractions_Testing_Integration_ConverterTests_CanReadShape_FromConverterWriteStream()'></a>
## ConverterTests.CanReadShape_FromConverterWriteStream() Method
You should ensure that given a [Shape](Myprysm_Converter_Abstractions_Testing_Integration_ConverterTests_Shape.md 'Myprysm.Converter.Abstractions.Testing.Integration.ConverterTests.Shape'),  
When the [Shape](Myprysm_Converter_Abstractions_Testing_Integration_ConverterTests_Shape.md 'Myprysm.Converter.Abstractions.Testing.Integration.ConverterTests.Shape') is serialized to Stream  
And the Stream is read as a [Shape](Myprysm_Converter_Abstractions_Testing_Integration_ConverterTests_Shape.md 'Myprysm.Converter.Abstractions.Testing.Integration.ConverterTests.Shape')  
Then both shapes are equivalent.  
```csharp
public void CanReadShape_FromConverterWriteStream();
```
  
<a name='Myprysm_Converter_Abstractions_Testing_Integration_ConverterTests_CanReadShape_FromConverterWriteString()'></a>
## ConverterTests.CanReadShape_FromConverterWriteString() Method
You should ensure that given a [Shape](Myprysm_Converter_Abstractions_Testing_Integration_ConverterTests_Shape.md 'Myprysm.Converter.Abstractions.Testing.Integration.ConverterTests.Shape'),  
When the [Shape](Myprysm_Converter_Abstractions_Testing_Integration_ConverterTests_Shape.md 'Myprysm.Converter.Abstractions.Testing.Integration.ConverterTests.Shape') is serialized to string  
And the string is read as a [Shape](Myprysm_Converter_Abstractions_Testing_Integration_ConverterTests_Shape.md 'Myprysm.Converter.Abstractions.Testing.Integration.ConverterTests.Shape')  
Then both shapes are equivalent.  
```csharp
public void CanReadShape_FromConverterWriteString();
```
  
<a name='Myprysm_Converter_Abstractions_Testing_Integration_ConverterTests_Convert_ConvertsToAnotherObjectOfTheSameShape()'></a>
## ConverterTests.Convert_ConvertsToAnotherObjectOfTheSameShape() Method
You should ensure that given a [Shape](Myprysm_Converter_Abstractions_Testing_Integration_ConverterTests_Shape.md 'Myprysm.Converter.Abstractions.Testing.Integration.ConverterTests.Shape'),  
When the [Shape](Myprysm_Converter_Abstractions_Testing_Integration_ConverterTests_Shape.md 'Myprysm.Converter.Abstractions.Testing.Integration.ConverterTests.Shape') is converted to [SimilarShape](Myprysm_Converter_Abstractions_Testing_Integration_ConverterTests_SimilarShape.md 'Myprysm.Converter.Abstractions.Testing.Integration.ConverterTests.SimilarShape')  
Then both shapes are equivalent.  
```csharp
public void Convert_ConvertsToAnotherObjectOfTheSameShape();
```
  
<a name='Myprysm_Converter_Abstractions_Testing_Integration_ConverterTests_Convert_WhenShapesDontMatch_ButBothShapesAreObjects_ReturnsObjectWithEmptyProperties()'></a>
## ConverterTests.Convert_WhenShapesDontMatch_ButBothShapesAreObjects_ReturnsObjectWithEmptyProperties() Method
You should ensure that given a [Shape](Myprysm_Converter_Abstractions_Testing_Integration_ConverterTests_Shape.md 'Myprysm.Converter.Abstractions.Testing.Integration.ConverterTests.Shape'),  
When the [Shape](Myprysm_Converter_Abstractions_Testing_Integration_ConverterTests_Shape.md 'Myprysm.Converter.Abstractions.Testing.Integration.ConverterTests.Shape') is converted to [NotShape](Myprysm_Converter_Abstractions_Testing_Integration_ConverterTests_NotShape.md 'Myprysm.Converter.Abstractions.Testing.Integration.ConverterTests.NotShape')  
Then the conversion returns a [NotShape](Myprysm_Converter_Abstractions_Testing_Integration_ConverterTests_NotShape.md 'Myprysm.Converter.Abstractions.Testing.Integration.ConverterTests.NotShape')  
And the value of A is null  
And the value of B is null  
And the value of Name is the same as [Name](Myprysm_Converter_Abstractions_Testing_Integration_ConverterTests_Shape.md#Myprysm_Converter_Abstractions_Testing_Integration_ConverterTests_Shape_Name 'Myprysm.Converter.Abstractions.Testing.Integration.ConverterTests.Shape.Name')
```csharp
public void Convert_WhenShapesDontMatch_ButBothShapesAreObjects_ReturnsObjectWithEmptyProperties();
```
  
<a name='Myprysm_Converter_Abstractions_Testing_Integration_ConverterTests_Convert_WhenSourceIsEnumerable_AndTargetIsObject_ShouldThrow()'></a>
## ConverterTests.Convert_WhenSourceIsEnumerable_AndTargetIsObject_ShouldThrow() Method
You should ensure that given a an [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1'),  
When the [Shape](Myprysm_Converter_Abstractions_Testing_Integration_ConverterTests_Shape.md 'Myprysm.Converter.Abstractions.Testing.Integration.ConverterTests.Shape') is converted to [Shape](Myprysm_Converter_Abstractions_Testing_Integration_ConverterTests_Shape.md 'Myprysm.Converter.Abstractions.Testing.Integration.ConverterTests.Shape')  
Then the conversion throws a [Myprysm.Converter.Abstractions.Exceptions.ConversionReadException](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Converter.Abstractions.Exceptions.ConversionReadException 'Myprysm.Converter.Abstractions.Exceptions.ConversionReadException')
```csharp
public void Convert_WhenSourceIsEnumerable_AndTargetIsObject_ShouldThrow();
```
  
<a name='Myprysm_Converter_Abstractions_Testing_Integration_ConverterTests_Convert_WhenSourceIsObject_AndTargetIsEnumerable_ShouldThrow()'></a>
## ConverterTests.Convert_WhenSourceIsObject_AndTargetIsEnumerable_ShouldThrow() Method
You should ensure that given a [Shape](Myprysm_Converter_Abstractions_Testing_Integration_ConverterTests_Shape.md 'Myprysm.Converter.Abstractions.Testing.Integration.ConverterTests.Shape'),  
When the [Shape](Myprysm_Converter_Abstractions_Testing_Integration_ConverterTests_Shape.md 'Myprysm.Converter.Abstractions.Testing.Integration.ConverterTests.Shape') is converted to an [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
Then the conversion throws a [Myprysm.Converter.Abstractions.Exceptions.ConversionReadException](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Converter.Abstractions.Exceptions.ConversionReadException 'Myprysm.Converter.Abstractions.Exceptions.ConversionReadException')
```csharp
public void Convert_WhenSourceIsObject_AndTargetIsEnumerable_ShouldThrow();
```
  
<a name='Myprysm_Converter_Abstractions_Testing_Integration_ConverterTests_Convert_WhenSourceIsPrimitive_AndTargetIsObject_ShouldThrow()'></a>
## ConverterTests.Convert_WhenSourceIsPrimitive_AndTargetIsObject_ShouldThrow() Method
You should ensure that given a primitive type,  
When the [Shape](Myprysm_Converter_Abstractions_Testing_Integration_ConverterTests_Shape.md 'Myprysm.Converter.Abstractions.Testing.Integration.ConverterTests.Shape') is converted to [Shape](Myprysm_Converter_Abstractions_Testing_Integration_ConverterTests_Shape.md 'Myprysm.Converter.Abstractions.Testing.Integration.ConverterTests.Shape')  
Then the conversion throws a [Myprysm.Converter.Abstractions.Exceptions.ConversionReadException](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Converter.Abstractions.Exceptions.ConversionReadException 'Myprysm.Converter.Abstractions.Exceptions.ConversionReadException')
```csharp
public void Convert_WhenSourceIsPrimitive_AndTargetIsObject_ShouldThrow();
```
  
<a name='Myprysm_Converter_Abstractions_Testing_Integration_ConverterTests_Read_WhenDataIsInvalid_ShouldThrow()'></a>
## ConverterTests.Read_WhenDataIsInvalid_ShouldThrow() Method
You should ensure that given invalid data  
Then the converter throws a [Myprysm.Converter.Abstractions.Exceptions.ConversionReadException](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Converter.Abstractions.Exceptions.ConversionReadException 'Myprysm.Converter.Abstractions.Exceptions.ConversionReadException').  
```csharp
public void Read_WhenDataIsInvalid_ShouldThrow();
```
  
<a name='Myprysm_Converter_Abstractions_Testing_Integration_ConverterTests_Write_WhenStreamIsDisposed_ShouldThrow()'></a>
## ConverterTests.Write_WhenStreamIsDisposed_ShouldThrow() Method
You should ensure that given an already disposed stream  
Then the converter throws a [Myprysm.Converter.Abstractions.Exceptions.ConversionWriteException](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Converter.Abstractions.Exceptions.ConversionWriteException 'Myprysm.Converter.Abstractions.Exceptions.ConversionWriteException').  
```csharp
public void Write_WhenStreamIsDisposed_ShouldThrow();
```
  
