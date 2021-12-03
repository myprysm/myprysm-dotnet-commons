namespace Myprysm.ImageService.ImageSharp;

using Myprysm.ImageService.Abstractions;

/// <summary>
/// <see cref="ImageSharpImageService"/> options to resize images.
/// </summary>
public class ImageSharpImageServiceOptions : ImageServiceOptions
{
    /// <summary>
    /// The memory pool kind.
    /// </summary>
    public MemoryPoolKind MemoryPoolKind { get; set; } = MemoryPoolKind.Default;
}
