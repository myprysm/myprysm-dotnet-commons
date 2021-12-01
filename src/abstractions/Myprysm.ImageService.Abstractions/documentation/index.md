#### [Myprysm.ImageService.Abstractions](index.md 'index')
### Namespaces
<a name='Myprysm_ImageService_Abstractions'></a>
## Myprysm.ImageService.Abstractions Namespace

| Classes | |
| :--- | :--- |
| [DependencyInjection](Myprysm_ImageService_Abstractions_DependencyInjection.md 'Myprysm.ImageService.Abstractions.DependencyInjection') | Dependency injection extensions.<br/> |
| [ImageMetadata](Myprysm_ImageService_Abstractions_ImageMetadata.md 'Myprysm.ImageService.Abstractions.ImageMetadata') | Represents the metadata of an image.<br/> |
| [ImageServiceOptions](Myprysm_ImageService_Abstractions_ImageServiceOptions.md 'Myprysm.ImageService.Abstractions.ImageServiceOptions') | Base image service options.<br/><br/>You should extend those options and use the dependency injection extensions if you want to enable tracing<br/> |
| [Point](Myprysm_ImageService_Abstractions_Point.md 'Myprysm.ImageService.Abstractions.Point') | Represents a point in a 2-dimensional space.<br/> |
| [Rectangle](Myprysm_ImageService_Abstractions_Rectangle.md 'Myprysm.ImageService.Abstractions.Rectangle') | Represents a rectangle with an origin [Myprysm.ImageService.Abstractions.Rectangle.Point](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.ImageService.Abstractions.Rectangle.Point 'Myprysm.ImageService.Abstractions.Rectangle.Point') and a [Myprysm.ImageService.Abstractions.Rectangle.Size](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.ImageService.Abstractions.Rectangle.Size 'Myprysm.ImageService.Abstractions.Rectangle.Size') dimension.<br/> |
| [Size](Myprysm_ImageService_Abstractions_Size.md 'Myprysm.ImageService.Abstractions.Size') | Represents a size as a rectangle of a given width and height.<br/> |

| Interfaces | |
| :--- | :--- |
| [IImageService](Myprysm_ImageService_Abstractions_IImageService.md 'Myprysm.ImageService.Abstractions.IImageService') | Handles image processing operations.<br/> |

| Enums | |
| :--- | :--- |
| [ImageFormat](Myprysm_ImageService_Abstractions_ImageFormat.md 'Myprysm.ImageService.Abstractions.ImageFormat') | The supported image formats for image processing operations.<br/> |
  
<a name='Myprysm_ImageService_Abstractions_Exceptions'></a>
## Myprysm.ImageService.Abstractions.Exceptions Namespace

| Classes | |
| :--- | :--- |
| [ImageProcessingException](Myprysm_ImageService_Abstractions_Exceptions_ImageProcessingException.md 'Myprysm.ImageService.Abstractions.Exceptions.ImageProcessingException') | Exception thrown when an image cannot be processed by an [IImageService](Myprysm_ImageService_Abstractions_IImageService.md 'Myprysm.ImageService.Abstractions.IImageService').<br/> |
  
