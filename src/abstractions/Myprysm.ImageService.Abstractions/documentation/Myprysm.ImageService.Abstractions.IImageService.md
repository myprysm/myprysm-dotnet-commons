#### [Myprysm.ImageService.Abstractions](index.md 'index')
### [Myprysm.ImageService.Abstractions](index.md#Myprysm.ImageService.Abstractions 'Myprysm.ImageService.Abstractions')

## IImageService Interface

Handles image processing operations.

```csharp
public interface IImageService
```
### Methods

<a name='Myprysm.ImageService.Abstractions.IImageService.CropAsync(System.IO.Stream,Myprysm.ImageService.Abstractions.Rectangle,Myprysm.ImageService.Abstractions.ImageFormat,System.Threading.CancellationToken)'></a>

## IImageService.CropAsync(Stream, Rectangle, ImageFormat, CancellationToken) Method

Crops a given area of an image stream source.

```csharp
System.Threading.Tasks.Task<System.IO.Stream> CropAsync(System.IO.Stream source, Myprysm.ImageService.Abstractions.Rectangle cropArea, Myprysm.ImageService.Abstractions.ImageFormat format=Myprysm.ImageService.Abstractions.ImageFormat.Original, System.Threading.CancellationToken cancellation=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='Myprysm.ImageService.Abstractions.IImageService.CropAsync(System.IO.Stream,Myprysm.ImageService.Abstractions.Rectangle,Myprysm.ImageService.Abstractions.ImageFormat,System.Threading.CancellationToken).source'></a>

`source` [System.IO.Stream](https://docs.microsoft.com/en-us/dotnet/api/System.IO.Stream 'System.IO.Stream')

The image stream source.

<a name='Myprysm.ImageService.Abstractions.IImageService.CropAsync(System.IO.Stream,Myprysm.ImageService.Abstractions.Rectangle,Myprysm.ImageService.Abstractions.ImageFormat,System.Threading.CancellationToken).cropArea'></a>

`cropArea` [Rectangle](Myprysm.ImageService.Abstractions.Rectangle.md 'Myprysm.ImageService.Abstractions.Rectangle')

The area to crop from the original image.

<a name='Myprysm.ImageService.Abstractions.IImageService.CropAsync(System.IO.Stream,Myprysm.ImageService.Abstractions.Rectangle,Myprysm.ImageService.Abstractions.ImageFormat,System.Threading.CancellationToken).format'></a>

`format` [ImageFormat](Myprysm.ImageService.Abstractions.ImageFormat.md 'Myprysm.ImageService.Abstractions.ImageFormat')

The output format for the cropped image.

<a name='Myprysm.ImageService.Abstractions.IImageService.CropAsync(System.IO.Stream,Myprysm.ImageService.Abstractions.Rectangle,Myprysm.ImageService.Abstractions.ImageFormat,System.Threading.CancellationToken).cancellation'></a>

`cancellation` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

The cancellation token.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.IO.Stream](https://docs.microsoft.com/en-us/dotnet/api/System.IO.Stream 'System.IO.Stream')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The cropped area from the original image in the given format.

#### Exceptions

[ImageProcessingException](Myprysm.ImageService.Abstractions.Exceptions.ImageProcessingException.md 'Myprysm.ImageService.Abstractions.Exceptions.ImageProcessingException')  
When an error occured during the processing of the image.

<a name='Myprysm.ImageService.Abstractions.IImageService.GetMetadataAsync(System.IO.Stream,System.Threading.CancellationToken)'></a>

## IImageService.GetMetadataAsync(Stream, CancellationToken) Method

Gets the metadata of an image stream source.

```csharp
System.Threading.Tasks.Task<Myprysm.ImageService.Abstractions.ImageMetadata> GetMetadataAsync(System.IO.Stream source, System.Threading.CancellationToken cancellation=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='Myprysm.ImageService.Abstractions.IImageService.GetMetadataAsync(System.IO.Stream,System.Threading.CancellationToken).source'></a>

`source` [System.IO.Stream](https://docs.microsoft.com/en-us/dotnet/api/System.IO.Stream 'System.IO.Stream')

The image stream source.

<a name='Myprysm.ImageService.Abstractions.IImageService.GetMetadataAsync(System.IO.Stream,System.Threading.CancellationToken).cancellation'></a>

`cancellation` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

The cancellation token.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[ImageMetadata](Myprysm.ImageService.Abstractions.ImageMetadata.md 'Myprysm.ImageService.Abstractions.ImageMetadata')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The image metadata when the stream is a valid image.

#### Exceptions

[ImageProcessingException](Myprysm.ImageService.Abstractions.Exceptions.ImageProcessingException.md 'Myprysm.ImageService.Abstractions.Exceptions.ImageProcessingException')  
When the image is not a valid image.

<a name='Myprysm.ImageService.Abstractions.IImageService.ResizeAsync(System.IO.Stream,Myprysm.ImageService.Abstractions.Size,Myprysm.ImageService.Abstractions.ImageFormat,System.Threading.CancellationToken)'></a>

## IImageService.ResizeAsync(Stream, Size, ImageFormat, CancellationToken) Method

Resizes an image stream source.

```csharp
System.Threading.Tasks.Task<System.IO.Stream> ResizeAsync(System.IO.Stream source, Myprysm.ImageService.Abstractions.Size size, Myprysm.ImageService.Abstractions.ImageFormat format=Myprysm.ImageService.Abstractions.ImageFormat.Original, System.Threading.CancellationToken cancellation=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='Myprysm.ImageService.Abstractions.IImageService.ResizeAsync(System.IO.Stream,Myprysm.ImageService.Abstractions.Size,Myprysm.ImageService.Abstractions.ImageFormat,System.Threading.CancellationToken).source'></a>

`source` [System.IO.Stream](https://docs.microsoft.com/en-us/dotnet/api/System.IO.Stream 'System.IO.Stream')

The image stream source.

<a name='Myprysm.ImageService.Abstractions.IImageService.ResizeAsync(System.IO.Stream,Myprysm.ImageService.Abstractions.Size,Myprysm.ImageService.Abstractions.ImageFormat,System.Threading.CancellationToken).size'></a>

`size` [Size](Myprysm.ImageService.Abstractions.Size.md 'Myprysm.ImageService.Abstractions.Size')

The output size to generate from the original image.

<a name='Myprysm.ImageService.Abstractions.IImageService.ResizeAsync(System.IO.Stream,Myprysm.ImageService.Abstractions.Size,Myprysm.ImageService.Abstractions.ImageFormat,System.Threading.CancellationToken).format'></a>

`format` [ImageFormat](Myprysm.ImageService.Abstractions.ImageFormat.md 'Myprysm.ImageService.Abstractions.ImageFormat')

The output format for the resized image.

<a name='Myprysm.ImageService.Abstractions.IImageService.ResizeAsync(System.IO.Stream,Myprysm.ImageService.Abstractions.Size,Myprysm.ImageService.Abstractions.ImageFormat,System.Threading.CancellationToken).cancellation'></a>

`cancellation` [System.Threading.CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.CancellationToken 'System.Threading.CancellationToken')

The cancellation token.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.IO.Stream](https://docs.microsoft.com/en-us/dotnet/api/System.IO.Stream 'System.IO.Stream')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The resized image in the given format.

#### Exceptions

[ImageProcessingException](Myprysm.ImageService.Abstractions.Exceptions.ImageProcessingException.md 'Myprysm.ImageService.Abstractions.Exceptions.ImageProcessingException')  
When an error occured during the processing of the image.