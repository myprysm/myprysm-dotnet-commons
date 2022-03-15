namespace Myprysm.ImageService.ImageSharp;

using Microsoft.Extensions.Logging;
using Myprysm.ImageService.Abstractions;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using Point = SixLabors.ImageSharp.Point;
using Rectangle = Myprysm.ImageService.Abstractions.Rectangle;
using Size = Myprysm.ImageService.Abstractions.Size;

/// <summary>
/// <see cref="IImageService"/> implementation with <see href="https://github.com/SixLabors/ImageSharp">ImageSharp</see>.
/// </summary>
public class ImageSharpImageService : IImageService
{
    private readonly ILogger<ImageSharpImageService> logger;

    /// <summary>
    /// Creates a new <see cref="ImageSharpImageService"/> with the given logger.
    /// </summary>
    /// <param name="logger">The logger.</param>
    public ImageSharpImageService(
        ILogger<ImageSharpImageService> logger)
    {
        this.logger = logger;
    }

    /// <inheritdoc />
    public async Task<ImageMetadata> GetMetadataAsync(Stream source, CancellationToken cancellation = default)
    {
        try
        {
            var (info, format) = await Image.IdentifyWithFormatAsync(source, cancellation).ConfigureAwait(false);

            return new ImageMetadata(
                format.GetImageFormat(),
                new Size(info.Width, info.Height),
                format.DefaultMimeType);
        }
        catch (Exception exception)
        {
            this.logger.LogError(exception, "Unable to read metadata for image: {Message}", exception.Message);
            throw new Abstractions.Exceptions.ImageProcessingException("Unable to read metadata for image", exception);
        }
    }

    /// <inheritdoc />
    public async Task<Stream> CropAsync(
        Stream source,
        Rectangle cropArea,
        ImageFormat format = ImageFormat.Original,
        CancellationToken cancellation = default)
    {
        try
        {
            var originalFormat = await Image.DetectFormatAsync(source, cancellation).ConfigureAwait(false);
            using var sourceImage = await Image.LoadAsync(source, cancellation).ConfigureAwait(false);

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
        catch (Exception exception)
        {
            this.logger.LogError(
                exception,
                "Unable to crop image to area {@Area} with format {Format}: {Message}",
                cropArea,
                format,
                exception.Message);
            throw new Abstractions.Exceptions.ImageProcessingException($"Unable to crop image to area {cropArea} with format {format}", exception);
        }
    }

    /// <inheritdoc />
    public async Task<Stream> ResizeAsync(
        Stream source,
        Size size,
        ImageFormat format = ImageFormat.Original,
        CancellationToken cancellation = default)
    {
        try
        {
            var originalFormat = await Image.DetectFormatAsync(source, cancellation).ConfigureAwait(false);
            using var sourceImage = await Image.LoadAsync(source, cancellation).ConfigureAwait(false);

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
        catch (Exception exception)
        {
            this.logger.LogError(
                exception,
                "Unable to resize image to size {@Size} with format {Format}: {Message}",
                size,
                format,
                exception.Message);
            throw new Abstractions.Exceptions.ImageProcessingException($"Unable to resize image to size {size} with format {format}", exception);
        }
    }
}
