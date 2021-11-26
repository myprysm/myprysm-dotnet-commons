namespace Myprysm.ImageService.ImageSharp;

using Myprysm.ImageService.Abstractions;

public class ImageSharpImageServiceOptions : ImageServiceOptions
{
    public MemoryPoolKind MemoryPoolKind { get; set; } = MemoryPoolKind.Default;
}
