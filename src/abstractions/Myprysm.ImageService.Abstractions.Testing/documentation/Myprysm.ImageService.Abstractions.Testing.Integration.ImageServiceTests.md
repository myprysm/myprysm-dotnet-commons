#### [Myprysm.ImageService.Abstractions.Testing](index.md 'index')
### [Myprysm.ImageService.Abstractions.Testing.Integration](index.md#Myprysm.ImageService.Abstractions.Testing.Integration 'Myprysm.ImageService.Abstractions.Testing.Integration')

## ImageServiceTests Class

Base test suite for [Myprysm.ImageService.Abstractions.IImageService](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.ImageService.Abstractions.IImageService 'Myprysm.ImageService.Abstractions.IImageService').

```csharp
public abstract class ImageServiceTests : Myprysm.Testing.NUnit.ServiceTests
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Myprysm.Testing.NUnit.FixtureTests](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Testing.NUnit.FixtureTests 'Myprysm.Testing.NUnit.FixtureTests') &#129106; [Myprysm.Testing.NUnit.ServiceTests](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Testing.NUnit.ServiceTests 'Myprysm.Testing.NUnit.ServiceTests') &#129106; ImageServiceTests
### Methods

<a name='Myprysm.ImageService.Abstractions.Testing.Integration.ImageServiceTests.CropImage_ConvertsImage(Myprysm.ImageService.Abstractions.ImageFormat)'></a>

## ImageServiceTests.CropImage_ConvertsImage(ImageFormat) Method

You should ensure that given a valid image stream  
When the image stream is cropped with the provided output format  
Then the output stream has the expected format.

```csharp
public System.Threading.Tasks.Task CropImage_ConvertsImage(Myprysm.ImageService.Abstractions.ImageFormat format);
```
#### Parameters

<a name='Myprysm.ImageService.Abstractions.Testing.Integration.ImageServiceTests.CropImage_ConvertsImage(Myprysm.ImageService.Abstractions.ImageFormat).format'></a>

`format` [Myprysm.ImageService.Abstractions.ImageFormat](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.ImageService.Abstractions.ImageFormat 'Myprysm.ImageService.Abstractions.ImageFormat')

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')

<a name='Myprysm.ImageService.Abstractions.Testing.Integration.ImageServiceTests.CropImage_WhenImageIsInvalid_ShouldThrow()'></a>

## ImageServiceTests.CropImage_WhenImageIsInvalid_ShouldThrow() Method

You should ensure that given an invalid image stream  
When the image stream is cropped  
Then the operations throws an [Myprysm.ImageService.Abstractions.Exceptions.ImageProcessingException](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.ImageService.Abstractions.Exceptions.ImageProcessingException 'Myprysm.ImageService.Abstractions.Exceptions.ImageProcessingException').

```csharp
public System.Threading.Tasks.Task CropImage_WhenImageIsInvalid_ShouldThrow();
```

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')

<a name='Myprysm.ImageService.Abstractions.Testing.Integration.ImageServiceTests.CropImage()'></a>

## ImageServiceTests.CropImage() Method

You should ensure that given a valid image stream  
When the image stream is cropped  
Then the output stream has the expected size.

```csharp
public System.Threading.Tasks.Task CropImage();
```

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')

<a name='Myprysm.ImageService.Abstractions.Testing.Integration.ImageServiceTests.GetMetadata_WhenImageIsInvalid_ShouldThrow()'></a>

## ImageServiceTests.GetMetadata_WhenImageIsInvalid_ShouldThrow() Method

You should ensure that given an invalid image stream  
When the metadata of the image stream are extracted  
Then the operations throws an [Myprysm.ImageService.Abstractions.Exceptions.ImageProcessingException](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.ImageService.Abstractions.Exceptions.ImageProcessingException 'Myprysm.ImageService.Abstractions.Exceptions.ImageProcessingException').

```csharp
public System.Threading.Tasks.Task GetMetadata_WhenImageIsInvalid_ShouldThrow();
```

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')

<a name='Myprysm.ImageService.Abstractions.Testing.Integration.ImageServiceTests.GetMetadata()'></a>

## ImageServiceTests.GetMetadata() Method

You should ensure that given a valid image stream  
When the metadata of the image stream are extracted  
Then the metadata matches the test image.

```csharp
public System.Threading.Tasks.Task GetMetadata();
```

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')

<a name='Myprysm.ImageService.Abstractions.Testing.Integration.ImageServiceTests.ResizeImage_ConvertsImage(Myprysm.ImageService.Abstractions.ImageFormat)'></a>

## ImageServiceTests.ResizeImage_ConvertsImage(ImageFormat) Method

You should ensure that given a valid image stream  
When the image stream is resized with the provided output format  
Then the output stream has the expected format.

```csharp
public System.Threading.Tasks.Task ResizeImage_ConvertsImage(Myprysm.ImageService.Abstractions.ImageFormat format);
```
#### Parameters

<a name='Myprysm.ImageService.Abstractions.Testing.Integration.ImageServiceTests.ResizeImage_ConvertsImage(Myprysm.ImageService.Abstractions.ImageFormat).format'></a>

`format` [Myprysm.ImageService.Abstractions.ImageFormat](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.ImageService.Abstractions.ImageFormat 'Myprysm.ImageService.Abstractions.ImageFormat')

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')

<a name='Myprysm.ImageService.Abstractions.Testing.Integration.ImageServiceTests.ResizeImage_WhenImageIsInvalid_ShouldThrow()'></a>

## ImageServiceTests.ResizeImage_WhenImageIsInvalid_ShouldThrow() Method

You should ensure that given an invalid image stream  
When the image stream is resized  
Then the operations throws an [Myprysm.ImageService.Abstractions.Exceptions.ImageProcessingException](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.ImageService.Abstractions.Exceptions.ImageProcessingException 'Myprysm.ImageService.Abstractions.Exceptions.ImageProcessingException').

```csharp
public System.Threading.Tasks.Task ResizeImage_WhenImageIsInvalid_ShouldThrow();
```

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')

<a name='Myprysm.ImageService.Abstractions.Testing.Integration.ImageServiceTests.ResizeImage(double,double)'></a>

## ImageServiceTests.ResizeImage(double, double) Method

You should ensure that given a valid image stream  
When the image stream is resized  
Then the output stream has the expected size.

```csharp
public System.Threading.Tasks.Task ResizeImage(double width, double height);
```
#### Parameters

<a name='Myprysm.ImageService.Abstractions.Testing.Integration.ImageServiceTests.ResizeImage(double,double).width'></a>

`width` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='Myprysm.ImageService.Abstractions.Testing.Integration.ImageServiceTests.ResizeImage(double,double).height'></a>

`height` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')