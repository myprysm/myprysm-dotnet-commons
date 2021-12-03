namespace Myprysm.ImageService.Abstractions;

using Myprysm.ImageService.Abstractions.Exceptions;

/// <summary>
/// Handles image processing operations.
/// </summary>
public interface IImageService
{
    /// <summary>
    /// Gets the metadata of an image stream source.
    /// </summary>
    /// <param name="source">The image stream source.</param>
    /// <param name="cancellation">The cancellation token.</param>
    /// <returns>The image metadata when the stream is a valid image.</returns>
    /// <exception cref="ImageProcessingException">When the image is not a valid image.</exception>
    Task<ImageMetadata> GetMetadataAsync(
        Stream source,
        CancellationToken cancellation = default);

    /// <summary>
    /// Crops a given area of an image stream source.
    /// </summary>
    /// <param name="source">The image stream source.</param>
    /// <param name="cropArea">The area to crop from the original image.</param>
    /// <param name="format">The output format for the cropped image.</param>
    /// <param name="cancellation">The cancellation token.</param>
    /// <returns>The cropped area from the original image in the given format.</returns>
    /// <exception cref="ImageProcessingException">When an error occured during the processing of the image.</exception>
    Task<Stream> CropAsync(
        Stream source,
        Rectangle cropArea,
        ImageFormat format = ImageFormat.Original,
        CancellationToken cancellation = default);


    /// <summary>
    /// Resizes an image stream source.
    /// </summary>
    /// <param name="source">The image stream source.</param>
    /// <param name="size">The output size to generate from the original image.</param>
    /// <param name="format">The output format for the resized image.</param>
    /// <param name="cancellation">The cancellation token.</param>
    /// <returns>The resized image in the given format.</returns>
    /// <exception cref="ImageProcessingException">When an error occured during the processing of the image.</exception>
    Task<Stream> ResizeAsync(
        Stream source,
        Size size,
        ImageFormat format = ImageFormat.Original,
        CancellationToken cancellation = default);
}
