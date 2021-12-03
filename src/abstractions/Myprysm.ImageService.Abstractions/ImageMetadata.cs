namespace Myprysm.ImageService.Abstractions;

/// <summary>
/// Represents the metadata of an image.
/// </summary>
/// <param name="Format">The format of the image.</param>
/// <param name="Size">The size of the image.</param>
/// <param name="ContentType">The content type of the image.</param>
public sealed record ImageMetadata(
    ImageFormat Format,
    Size Size,
    string ContentType);
