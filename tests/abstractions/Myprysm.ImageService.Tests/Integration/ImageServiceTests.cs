namespace Myprysm.ImageService.Tests.Integration;

using System.IO;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.ImageService.Abstractions;
using Myprysm.ImageService.Abstractions.Exceptions;
using Myprysm.Testing.NUnit;
using NUnit.Framework;

[Category(Categories.Integration)]
public abstract class ImageServiceTests : ServiceTests
{
    private const string TestImage = "bender.jpeg";

    private static Stream GetInvalidImage()
    {
        return new MemoryStream(Encoding.UTF8.GetBytes("a normal string"));
    }

    [Test]
    public async Task GetMetadata_WhenImageIsInvalid_ShouldThrow()
    {
        // Arrange
        await using var invalidImage = GetInvalidImage();

        // Act
        var act = () => this.GetSut().GetMetadataAsync(invalidImage);

        // Assert
        await act.Should().ThrowAsync<ImageProcessingException>();
    }

    [Test]
    public async Task GetMetadata()
    {
        // Arrange
        await using var resourceStream = typeof(ImageServiceTests).GetResourceStream(TestImage);

        // Act
        var metadata = await this.GetSut().GetMetadataAsync(resourceStream);

        // Assert
        metadata.Format.Should().Be(ImageFormat.Jpg);
        metadata.Size.Should().BeEquivalentTo(new Size(1280, 784));
        metadata.ContentType.Should().Be("image/jpeg");
    }

    [Test]
    public async Task ResizeImage_WhenImageIsInvalid_ShouldThrow()
    {
        // Arrange
        var size = this.A<Size>();
        await using var invalidImage = GetInvalidImage();

        // Act
        var act = () => this.GetSut().ResizeAsync(invalidImage, size);

        // Assert
        await act.Should().ThrowAsync<ImageProcessingException>();
    }

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
    public async Task CropImage_WhenImageIsInvalid_ShouldThrow()
    {
        // Arrange
        var rectangle = this.A<Rectangle>();
        await using var invalidImage = GetInvalidImage();

        // Act
        var act = () => this.GetSut().CropAsync(invalidImage, rectangle);

        // Assert
        await act.Should().ThrowAsync<ImageProcessingException>();
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
