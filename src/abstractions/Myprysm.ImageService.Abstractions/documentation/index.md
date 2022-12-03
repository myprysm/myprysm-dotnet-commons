#### [Myprysm.ImageService.Abstractions](index.md 'index')

## Myprysm.ImageService.Abstractions Assembly
### Namespaces

<a name='Myprysm.ImageService.Abstractions'></a>

## Myprysm.ImageService.Abstractions Namespace

| Classes | |
| :--- | :--- |
| [DependencyInjection](Myprysm.ImageService.Abstractions.DependencyInjection.md 'Myprysm.ImageService.Abstractions.DependencyInjection') | Dependency injection extensions. |
| [ImageMetadata](Myprysm.ImageService.Abstractions.ImageMetadata.md 'Myprysm.ImageService.Abstractions.ImageMetadata') | Represents the metadata of an image. |
| [ImageServiceOptions](Myprysm.ImageService.Abstractions.ImageServiceOptions.md 'Myprysm.ImageService.Abstractions.ImageServiceOptions') | Base image service options.<br/><br/>You should extend those options and use the dependency injection extensions if you want to enable tracing |
| [Point](Myprysm.ImageService.Abstractions.Point.md 'Myprysm.ImageService.Abstractions.Point') | Represents a point in a 2-dimensional space. |
| [Rectangle](Myprysm.ImageService.Abstractions.Rectangle.md 'Myprysm.ImageService.Abstractions.Rectangle') | Represents a rectangle with an origin [Point](Myprysm.ImageService.Abstractions.Rectangle.md#Myprysm.ImageService.Abstractions.Rectangle.Point 'Myprysm.ImageService.Abstractions.Rectangle.Point') and a [Size](Myprysm.ImageService.Abstractions.Rectangle.md#Myprysm.ImageService.Abstractions.Rectangle.Size 'Myprysm.ImageService.Abstractions.Rectangle.Size') dimension. |
| [Size](Myprysm.ImageService.Abstractions.Size.md 'Myprysm.ImageService.Abstractions.Size') | Represents a size as a rectangle of a given width and height. |

| Interfaces | |
| :--- | :--- |
| [IImageService](Myprysm.ImageService.Abstractions.IImageService.md 'Myprysm.ImageService.Abstractions.IImageService') | Handles image processing operations. |

| Enums | |
| :--- | :--- |
| [ImageFormat](Myprysm.ImageService.Abstractions.ImageFormat.md 'Myprysm.ImageService.Abstractions.ImageFormat') | The supported image formats for image processing operations. |

<a name='Myprysm.ImageService.Abstractions.Exceptions'></a>

## Myprysm.ImageService.Abstractions.Exceptions Namespace

| Classes | |
| :--- | :--- |
| [ImageProcessingException](Myprysm.ImageService.Abstractions.Exceptions.ImageProcessingException.md 'Myprysm.ImageService.Abstractions.Exceptions.ImageProcessingException') | Exception thrown when an image cannot be processed by an [IImageService](Myprysm.ImageService.Abstractions.IImageService.md 'Myprysm.ImageService.Abstractions.IImageService'). |
