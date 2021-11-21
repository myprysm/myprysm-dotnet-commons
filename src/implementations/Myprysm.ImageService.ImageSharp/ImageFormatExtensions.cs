namespace Myprysm.ImageService.ImageSharp;

using Myprysm.ImageService.Abstractions;
using Myprysm.SharedKernel.Exceptions;
using SixLabors.ImageSharp.Formats;
using SixLabors.ImageSharp.Formats.Gif;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Formats.Png;

public static class ImageFormatExtensions
{
    public static IImageFormat GetImageFormat(this ImageFormat format, IImageFormat originalFormat)
    {
        return format switch
        {
            ImageFormat.Original => originalFormat,
            ImageFormat.Gif => GifFormat.Instance,
            ImageFormat.Jpg => JpegFormat.Instance,
            ImageFormat.Png => PngFormat.Instance,
            _ => throw new IllegalOperationException($"Image format {format} is not supported."),
        };
    }

    public static ImageFormat GetImageFormat(this IImageFormat format)
    {
        return format switch
        {
            var f when f.Name == GifFormat.Instance.Name => ImageFormat.Gif,
            var f when f.Name == PngFormat.Instance.Name => ImageFormat.Png,
            var f when f.Name == JpegFormat.Instance.Name => ImageFormat.Jpg,
            _ => throw new IllegalOperationException($"Image format {format.Name} is not supported."),
        };
    }
}
