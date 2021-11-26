namespace Myprysm.ImageService.Abstractions.Exceptions;

using Myprysm.SharedKernel.Exceptions;

public class ImageProcessingException : ManagedException
{
    public ImageProcessingException(string message, Exception exception)
        : base(message, exception)
    {
    }
}
