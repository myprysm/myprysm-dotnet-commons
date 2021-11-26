namespace Myprysm.ImageService.Abstractions;

public sealed record ImageMetadata(
    ImageFormat Format,
    Size Size,
    string ContentType);
