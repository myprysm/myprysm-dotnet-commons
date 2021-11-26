namespace Myprysm.ImageService.Abstractions;

using System.Diagnostics.CodeAnalysis;

[ExcludeFromCodeCoverage]
public class ImageServiceOptions
{
    public bool WithTracing { get; set; } = true;
}
