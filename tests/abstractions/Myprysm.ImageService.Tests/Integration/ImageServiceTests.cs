namespace Myprysm.ImageService.Tests.Integration;

using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.ImageService.Abstractions;
using Myprysm.Testing;
using NUnit.Framework;

[Category(Categories.Integration)]
public abstract class ImageServiceTests : ServiceTests
{
    private const string TestImage = "bender.jpeg";

    [Test]
    [TestCase(640, 392)]
    [TestCase(1920, 1176)]
    public async Task ResizeImage(double width, double height)
    {
        // Arrange
        var size = new Size(width, height);
        await using var resourceStream = typeof(ImageServiceTests).GetResourceStream(TestImage);

        // Act
        await using var actualImage = await this.GetSut().ResizeAsync(resourceStream, size).ConfigureAwait(false);

        // Assert
        var actualMetadata = await this.GetSut().GetMetadataAsync(actualImage).ConfigureAwait(false);

        actualMetadata.Size.Should().BeEquivalentTo(size);
    }

    [Test]
    [TestCase(ImageFormat.Gif)]
    [TestCase(ImageFormat.Png)]
    public async Task ResizeImage_ConvertsImage(ImageFormat format)
    {
        // Arrange
        var size = new Size(640, 392);
        await using var resourceStream = typeof(ImageServiceTests).GetResourceStream(TestImage);

        // Act
        await using var actualImage = await this.GetSut().ResizeAsync(resourceStream, size, format).ConfigureAwait(false);

        // Assert
        var actualMetadata = await this.GetSut().GetMetadataAsync(actualImage).ConfigureAwait(false);

        actualMetadata.Format.Should().Be(format);
    }
        
    [Test]
    public async Task CropImage()
    {
        // Arrange
        var point = new Point(850, 50);
        var size = new Size(420, 420);
        var rectangle = new Rectangle(point, size);
        await using var resourceStream = typeof(ImageServiceTests).GetResourceStream(TestImage);

        // Act
        await using var actualImage = await this.GetSut().CropAsync(resourceStream, rectangle).ConfigureAwait(false);

        // Assert
        var actualMetadata = await this.GetSut().GetMetadataAsync(actualImage).ConfigureAwait(false);

        actualMetadata.Size.Should().BeEquivalentTo(size);
    }

    [Test]
    [TestCase(ImageFormat.Gif)]
    [TestCase(ImageFormat.Png)]
    public async Task CropImage_ConvertsImage(ImageFormat format)
    {
        // Arrange
        var point = new Point(850, 50);
        var size = new Size(420, 420);
        var rectangle = new Rectangle(point, size);
        await using var resourceStream = typeof(ImageServiceTests).GetResourceStream(TestImage);

        // Act
        await using var actualImage = await this.GetSut().CropAsync(resourceStream, rectangle, format).ConfigureAwait(false);

        // Assert
        var actualMetadata = await this.GetSut().GetMetadataAsync(actualImage).ConfigureAwait(false);

        actualMetadata.Format.Should().Be(format);
    }


    private IImageService GetSut()
    {
        return this.Services.GetRequiredService<IImageService>();
    }
}