namespace Myprysm.ImageService.Abstractions;

public interface IImageService
{
    Task<ImageMetadata> GetMetadataAsync(
        Stream source,
        CancellationToken cancellation = default);

    Task<Stream> CropAsync(
        Stream source,
        Rectangle cropArea,
        ImageFormat format = ImageFormat.Original,
        CancellationToken cancellation = default);

    Task<Stream> ResizeAsync(
        Stream source,
        Size size,
        ImageFormat format = ImageFormat.Original,
        CancellationToken cancellation = default);
}