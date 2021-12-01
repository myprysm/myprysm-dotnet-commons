namespace Myprysm.ImageService.Abstractions.Exceptions;

using Myprysm.SharedKernel.Exceptions;

/// <summary>
/// Exception thrown when an image cannot be processed by an <see cref="IImageService"/>.
/// </summary>
public class ImageProcessingException : ManagedException
{
    /// <summary>
    /// Creates an instance of <see cref="ImageProcessingException"/>.
    /// </summary>
    /// <param name="message">The reason of the exception.</param>
    /// <param name="exception">The original exception.</param>
    public ImageProcessingException(string message, Exception exception)
        : base(message, exception)
    {
    }
}
