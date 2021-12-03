namespace Myprysm.ImageService.Abstractions;

using System.Globalization;
using Myprysm.ImageService.Abstractions.Exceptions;
using Myprysm.Tracing.Abstractions;

internal class TracedImageService : IImageService
{
    private readonly IImageService delegated;
    private readonly ITracer tracer;

    internal TracedImageService(
        IImageService delegated,
        ITracer tracer)
    {
        this.delegated = delegated;
        this.tracer = tracer;
    }

    public async Task<ImageMetadata> GetMetadataAsync(
        Stream source,
        CancellationToken cancellation = default)
    {
        using var trace = this.tracer.StartTrace(nameof(this.GetMetadataAsync));

        try
        {
            return await this.delegated.GetMetadataAsync(source, cancellation).ConfigureAwait(false);
        }
        catch (ImageProcessingException exception)
        {
            trace?.AddTag("otel.status_code", "ERROR");
            trace?.AddTag("otel.status_description", $"Image processing exception: {exception.Message}");
            throw;
        }
        catch (Exception exception)
        {
            trace?.AddTag("otel.status_code", "ERROR");
            trace?.AddTag("otel.status_description", $"Unhandled exception: {exception.Message}");
            throw;
        }
    }

    public async Task<Stream> CropAsync(
        Stream source,
        Rectangle cropArea,
        ImageFormat format = ImageFormat.Original,
        CancellationToken cancellation = default)
    {
        using var trace = this.tracer.StartTrace(nameof(this.CropAsync));
        trace?.AddTag("image_service.crop_area.x", cropArea.Point.X.ToString(CultureInfo.InvariantCulture));
        trace?.AddTag("image_service.crop_area.y", cropArea.Point.Y.ToString(CultureInfo.InvariantCulture));
        trace?.AddTag("image_service.crop_area.width", cropArea.Size.Width.ToString(CultureInfo.InvariantCulture));
        trace?.AddTag("image_service.crop_area.height", cropArea.Size.Height.ToString(CultureInfo.InvariantCulture));
        trace?.AddTag("image_service.format", format.ToString());

        try
        {
            return await this.delegated.CropAsync(source, cropArea, format, cancellation).ConfigureAwait(false);
        }
        catch (ImageProcessingException exception)
        {
            trace?.AddTag("otel.status_code", "ERROR");
            trace?.AddTag("otel.status_description", $"Image processing exception: {exception.Message}");
            throw;
        }
        catch (Exception exception)
        {
            trace?.AddTag("otel.status_code", "ERROR");
            trace?.AddTag("otel.status_description", $"Unhandled exception: {exception.Message}");
            throw;
        }
    }

    public async Task<Stream> ResizeAsync(
        Stream source,
        Size size,
        ImageFormat format = ImageFormat.Original,
        CancellationToken cancellation = default)
    {
        using var trace = this.tracer.StartTrace(nameof(this.ResizeAsync));
        trace?.AddTag("image_service.size.width", size.Width.ToString(CultureInfo.InvariantCulture));
        trace?.AddTag("image_service.size.height", size.Height.ToString(CultureInfo.InvariantCulture));
        trace?.AddTag("image_service.format", format.ToString());

        try
        {
            return await this.delegated.ResizeAsync(source, size, format, cancellation).ConfigureAwait(false);
        }
        catch (ImageProcessingException exception)
        {
            trace?.AddTag("otel.status_code", "ERROR");
            trace?.AddTag("otel.status_description", $"Image processing exception: {exception.Message}");
            throw;
        }
        catch (Exception exception)
        {
            trace?.AddTag("otel.status_code", "ERROR");
            trace?.AddTag("otel.status_description", $"Unhandled exception: {exception.Message}");
            throw;
        }
    }
}
