namespace Myprysm.ImageService.Abstractions;

/// <summary>
/// The supported image formats for image processing operations.
/// </summary>
public enum ImageFormat
{
    /// <summary>
    /// Indicates that the output of an image processing should be in the same format as the original image.
    /// </summary>
    Original,
    
    /// <summary>
    /// Indicates that the output of an image processing should be in the PNG format.
    /// </summary>
    Png,
    
    /// <summary>
    /// Indicates that the output of an image processing should be in the JPEG format.
    /// </summary>
    Jpg,
    
    /// <summary>
    /// Indicates that the output of an image processing should be in the GIF format.
    /// </summary>
    Gif,
}
