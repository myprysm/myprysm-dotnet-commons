#### [Myprysm.ImageService.Abstractions](index.md 'index')
### [Myprysm.ImageService.Abstractions.Exceptions](index.md#Myprysm_ImageService_Abstractions_Exceptions 'Myprysm.ImageService.Abstractions.Exceptions')
## ImageProcessingException Class
Exception thrown when an image cannot be processed by an [IImageService](Myprysm_ImageService_Abstractions_IImageService.md 'Myprysm.ImageService.Abstractions.IImageService').  
```csharp
public class ImageProcessingException : Myprysm.SharedKernel.Exceptions.ManagedException
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') &#129106; [Myprysm.SharedKernel.Exceptions.ManagedException](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.SharedKernel.Exceptions.ManagedException 'Myprysm.SharedKernel.Exceptions.ManagedException') &#129106; ImageProcessingException  
### Constructors
<a name='Myprysm_ImageService_Abstractions_Exceptions_ImageProcessingException_ImageProcessingException(string_System_Exception)'></a>
## ImageProcessingException.ImageProcessingException(string, Exception) Constructor
Creates an instance of [ImageProcessingException](Myprysm_ImageService_Abstractions_Exceptions_ImageProcessingException.md 'Myprysm.ImageService.Abstractions.Exceptions.ImageProcessingException').  
```csharp
public ImageProcessingException(string message, System.Exception exception);
```
#### Parameters
<a name='Myprysm_ImageService_Abstractions_Exceptions_ImageProcessingException_ImageProcessingException(string_System_Exception)_message'></a>
`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The reason of the exception.
  
<a name='Myprysm_ImageService_Abstractions_Exceptions_ImageProcessingException_ImageProcessingException(string_System_Exception)_exception'></a>
`exception` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')  
The original exception.
  
  
