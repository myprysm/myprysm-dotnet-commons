#### [Myprysm.ImageService.ImageSharp](index.md 'index')
### [Myprysm.ImageService.ImageSharp](index.md#Myprysm.ImageService.ImageSharp 'Myprysm.ImageService.ImageSharp')

## ImageSharpImageService Class

[Myprysm.ImageService.Abstractions.IImageService](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.ImageService.Abstractions.IImageService 'Myprysm.ImageService.Abstractions.IImageService') implementation with [ImageSharp](https://github.com/SixLabors/ImageSharp 'https://github.com/SixLabors/ImageSharp').

```csharp
public class ImageSharpImageService :
Myprysm.ImageService.Abstractions.IImageService
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ImageSharpImageService

Implements [Myprysm.ImageService.Abstractions.IImageService](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.ImageService.Abstractions.IImageService 'Myprysm.ImageService.Abstractions.IImageService')
### Constructors

<a name='Myprysm.ImageService.ImageSharp.ImageSharpImageService.ImageSharpImageService(Microsoft.Extensions.Logging.ILogger_Myprysm.ImageService.ImageSharp.ImageSharpImageService_)'></a>

## ImageSharpImageService(ILogger<ImageSharpImageService>) Constructor

Creates a new [ImageSharpImageService](Myprysm.ImageService.ImageSharp.ImageSharpImageService.md 'Myprysm.ImageService.ImageSharp.ImageSharpImageService') with the given logger.

```csharp
public ImageSharpImageService(Microsoft.Extensions.Logging.ILogger<Myprysm.ImageService.ImageSharp.ImageSharpImageService> logger);
```
#### Parameters

<a name='Myprysm.ImageService.ImageSharp.ImageSharpImageService.ImageSharpImageService(Microsoft.Extensions.Logging.ILogger_Myprysm.ImageService.ImageSharp.ImageSharpImageService_).logger'></a>

`logger` [Microsoft.Extensions.Logging.ILogger&lt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.ILogger-1 'Microsoft.Extensions.Logging.ILogger`1')[ImageSharpImageService](Myprysm.ImageService.ImageSharp.ImageSharpImageService.md 'Myprysm.ImageService.ImageSharp.ImageSharpImageService')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.ILogger-1 'Microsoft.Extensions.Logging.ILogger`1')

The logger.
### Methods

<a name='Myprysm.ImageService.ImageSharp.ImageSharpImageService.CropAsync(System.IO.Stream,Myprysm.ImageService.Abstractions.Rectangle,Myprysm.ImageService.Abstractions.ImageFormat,System.Threading.CancellationToken)'></a>

## ImageSharpImageService.CropAsync(Stream, Rectangle, ImageFormat, CancellationToken) Method

Crops a given area of an image stream source.

```csharp
public System.Threading.Tasks.Task<System.IO.Stream> CropAsync(System.IO.Stream source, Myprysm.ImageService.Abstractions.Rectangle cropArea, Myprysm.ImageService.Abstractions.ImageFormat format=Myprysm.ImageService.Abstractions.ImageFormat.Original, System.Threading.CancellationToken cancellation=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='Myprysm.ImageService.ImageSharp.ImageSharpImageService.CropAsync(System.IO.Stream,Myprysm.ImageService.Abstractions.Rectangle,Myprysm.ImageService.Abstractions.ImageFormat,System.Threading.CancellationToken).source'></a>

`source` [System.IO.Stream](https://docs.microsoft.com/en-us/dotnet/api/System.IO.Stream 'System.IO.Stream')

The image stream source.

<a name='Myprysm.ImageService.ImageSharp.ImageSharpImageService.CropAsync(System.IO.Stream,Myprysm.ImageService.Abstractions.Rectangle,Myprysm.ImageService.Abstractions.ImageFormat,System.Threading.CancellationToken).cropArea'></a>

`cropArea` [Myprysm.ImageService.Abstractions.Rectangle](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.ImageService.Abstractions.Rectangle 'Myprysm.ImageService.Abstractions.Rectangle')

The area to crop from the original image.

<a name='Myprysm.ImageService.ImageSharp.ImageSharpImageService.CropAsync(System.IO.Stream,Myprysm.ImageService.Abstractions.Rectangle,Myprysm.ImageService.Abstractions.ImageFormat,System.Threading.CancellationToken).format'></a>

`format` [Myprysm.ImageService.Abstractions.ImageFormat](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.ImageService.Abstractions.ImageFormat 'Myprysm.ImageService.Abstractions.ImageFormat')

The output format for the cropped image.

<a name='Myprysm.ImageService.ImageSharp.ImageSharpImageService.CropAsync(System.IO.Stream,Myprysm.ImageService.Abstractions.Rectangle,Myprysm.ImageService.Abstractions.ImageFormat,System.Threading.CancellationToken).cancellation'></a>

`cancellation` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

The cancellation token.

Implements [CropAsync(Stream, Rectangle, ImageFormat, CancellationToken)](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.ImageService.Abstractions.IImageService.CropAsync#Myprysm_ImageService_Abstractions_IImageService_CropAsync_System_IO_Stream,Myprysm_ImageService_Abstractions_Rectangle,Myprysm_ImageService_Abstractions_ImageFormat,System_Threading_CancellationToken_ 'Myprysm.ImageService.Abstractions.IImageService.CropAsync(System.IO.Stream,Myprysm.ImageService.Abstractions.Rectangle,Myprysm.ImageService.Abstractions.ImageFormat,System.Threading.CancellationToken)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.IO.Stream](https://docs.microsoft.com/en-us/dotnet/api/System.IO.Stream 'System.IO.Stream')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The cropped area from the original image in the given format.

#### Exceptions

[Myprysm.ImageService.Abstractions.Exceptions.ImageProcessingException](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.ImageService.Abstractions.Exceptions.ImageProcessingException 'Myprysm.ImageService.Abstractions.Exceptions.ImageProcessingException')  
When an error occured during the processing of the image.

<a name='Myprysm.ImageService.ImageSharp.ImageSharpImageService.GetMetadataAsync(System.IO.Stream,System.Threading.CancellationToken)'></a>

## ImageSharpImageService.GetMetadataAsync(Stream, CancellationToken) Method

Gets the metadata of an image stream source.

```csharp
public System.Threading.Tasks.Task<Myprysm.ImageService.Abstractions.ImageMetadata> GetMetadataAsync(System.IO.Stream source, System.Threading.CancellationToken cancellation=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='Myprysm.ImageService.ImageSharp.ImageSharpImageService.GetMetadataAsync(System.IO.Stream,System.Threading.CancellationToken).source'></a>

`source` [System.IO.Stream](https://docs.microsoft.com/en-us/dotnet/api/System.IO.Stream 'System.IO.Stream')

The image stream source.

<a name='Myprysm.ImageService.ImageSharp.ImageSharpImageService.GetMetadataAsync(System.IO.Stream,System.Threading.CancellationToken).cancellation'></a>

`cancellation` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

The cancellation token.

Implements [GetMetadataAsync(Stream, CancellationToken)](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.ImageService.Abstractions.IImageService.GetMetadataAsync#Myprysm_ImageService_Abstractions_IImageService_GetMetadataAsync_System_IO_Stream,System_Threading_CancellationToken_ 'Myprysm.ImageService.Abstractions.IImageService.GetMetadataAsync(System.IO.Stream,System.Threading.CancellationToken)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[Myprysm.ImageService.Abstractions.ImageMetadata](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.ImageService.Abstractions.ImageMetadata 'Myprysm.ImageService.Abstractions.ImageMetadata')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The image metadata when the stream is a valid image.

#### Exceptions

[Myprysm.ImageService.Abstractions.Exceptions.ImageProcessingException](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.ImageService.Abstractions.Exceptions.ImageProcessingException 'Myprysm.ImageService.Abstractions.Exceptions.ImageProcessingException')  
When the image is not a valid image.

<a name='Myprysm.ImageService.ImageSharp.ImageSharpImageService.ResizeAsync(System.IO.Stream,Myprysm.ImageService.Abstractions.Size,Myprysm.ImageService.Abstractions.ImageFormat,System.Threading.CancellationToken)'></a>

## ImageSharpImageService.ResizeAsync(Stream, Size, ImageFormat, CancellationToken) Method

Resizes an image stream source.

```csharp
public System.Threading.Tasks.Task<System.IO.Stream> ResizeAsync(System.IO.Stream source, Myprysm.ImageService.Abstractions.Size size, Myprysm.ImageService.Abstractions.ImageFormat format=Myprysm.ImageService.Abstractions.ImageFormat.Original, System.Threading.CancellationToken cancellation=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='Myprysm.ImageService.ImageSharp.ImageSharpImageService.ResizeAsync(System.IO.Stream,Myprysm.ImageService.Abstractions.Size,Myprysm.ImageService.Abstractions.ImageFormat,System.Threading.CancellationToken).source'></a>

`source` [System.IO.Stream](https://docs.microsoft.com/en-us/dotnet/api/System.IO.Stream 'System.IO.Stream')

The image stream source.

<a name='Myprysm.ImageService.ImageSharp.ImageSharpImageService.ResizeAsync(System.IO.Stream,Myprysm.ImageService.Abstractions.Size,Myprysm.ImageService.Abstractions.ImageFormat,System.Threading.CancellationToken).size'></a>

`size` [Myprysm.ImageService.Abstractions.Size](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.ImageService.Abstractions.Size 'Myprysm.ImageService.Abstractions.Size')

The output size to generate from the original image.

<a name='Myprysm.ImageService.ImageSharp.ImageSharpImageService.ResizeAsync(System.IO.Stream,Myprysm.ImageService.Abstractions.Size,Myprysm.ImageService.Abstractions.ImageFormat,System.Threading.CancellationToken).format'></a>

`format` [Myprysm.ImageService.Abstractions.ImageFormat](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.ImageService.Abstractions.ImageFormat 'Myprysm.ImageService.Abstractions.ImageFormat')

The output format for the resized image.

<a name='Myprysm.ImageService.ImageSharp.ImageSharpImageService.ResizeAsync(System.IO.Stream,Myprysm.ImageService.Abstractions.Size,Myprysm.ImageService.Abstractions.ImageFormat,System.Threading.CancellationToken).cancellation'></a>

`cancellation` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

The cancellation token.

Implements [ResizeAsync(Stream, Size, ImageFormat, CancellationToken)](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.ImageService.Abstractions.IImageService.ResizeAsync#Myprysm_ImageService_Abstractions_IImageService_ResizeAsync_System_IO_Stream,Myprysm_ImageService_Abstractions_Size,Myprysm_ImageService_Abstractions_ImageFormat,System_Threading_CancellationToken_ 'Myprysm.ImageService.Abstractions.IImageService.ResizeAsync(System.IO.Stream,Myprysm.ImageService.Abstractions.Size,Myprysm.ImageService.Abstractions.ImageFormat,System.Threading.CancellationToken)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.IO.Stream](https://docs.microsoft.com/en-us/dotnet/api/System.IO.Stream 'System.IO.Stream')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The resized image in the given format.

#### Exceptions

[Myprysm.ImageService.Abstractions.Exceptions.ImageProcessingException](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.ImageService.Abstractions.Exceptions.ImageProcessingException 'Myprysm.ImageService.Abstractions.Exceptions.ImageProcessingException')  
When an error occured during the processing of the image.