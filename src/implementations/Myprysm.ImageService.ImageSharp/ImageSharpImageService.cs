namespace Myprysm.ImageService.ImageSharp;

using Myprysm.ImageService.Abstractions;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using Point = SixLabors.ImageSharp.Point;
using Rectangle = Myprysm.ImageService.Abstractions.Rectangle;
using Size = Myprysm.ImageService.Abstractions.Size;

public class ImageSharpImageService : IImageService
{
    public async Task<ImageMetadata> GetMetadataAsync(Stream source, CancellationToken cancellation = default)
    {
        var (info, format) = await Image.IdentifyWithFormatAsync(source, cancellation).ConfigureAwait(false);

        return new ImageMetadata(
            format.GetImageFormat(),
            new Size(info.Width, info.Height),
            format.DefaultMimeType);
    }

    public async Task<Stream> CropAsync(
        Stream source,
        Rectangle cropArea,
        ImageFormat format = ImageFormat.Original,
        CancellationToken cancellation = default)
    {
        var originalFormat = await Image.DetectFormatAsync(source).ConfigureAwait(false);
        using var sourceImage = await Image.LoadAsync(source).ConfigureAwait(false);

        var (point, size) = cropArea;

        var rectangle = new SixLabors.ImageSharp.Rectangle(
            new Point(point.XAsInt, point.YAsInt),
            new SixLabors.ImageSharp.Size(size.WidthAsInt, size.HeightAsInt));

        await Task.Run(
                // ReSharper disable once AccessToDisposedClosure
                () => sourceImage.Mutate(i => i.Crop(rectangle)),
                cancellation)
            .ConfigureAwait(false);

        var outputFormat = format.GetImageFormat(originalFormat);

        var outputStream = new MemoryStream();
        await sourceImage.SaveAsync(outputStream, outputFormat, cancellation).ConfigureAwait(false);

        outputStream.Position = 0;
        return outputStream;
    }

    public async Task<Stream> ResizeAsync(
        Stream source,
        Size size,
        ImageFormat format = ImageFormat.Original,
        CancellationToken cancellation = default)
    {
        var originalFormat = await Image.DetectFormatAsync(source).ConfigureAwait(false);
        using var sourceImage = await Image.LoadAsync(source).ConfigureAwait(false);

        var newSize = new SixLabors.ImageSharp.Size(size.WidthAsInt, size.HeightAsInt);

        await Task.Run(
                // ReSharper disable once AccessToDisposedClosure
                () => sourceImage.Mutate(i => i.Resize(newSize)),
                cancellation)
            .ConfigureAwait(false);

        var outputFormat = format.GetImageFormat(originalFormat);
        var outputStream = new MemoryStream();
        await sourceImage.SaveAsync(outputStream, outputFormat, cancellation).ConfigureAwait(false);

        outputStream.Position = 0;
        return outputStream;
    }
}
