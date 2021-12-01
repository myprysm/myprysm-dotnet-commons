namespace Myprysm.ImageService.Abstractions;

/// <summary>
/// Represents a size as a rectangle of a given width and height.
/// </summary>
public sealed record Size
{
    /// <summary>
    /// Creates a new <see cref="Size"/>.
    /// </summary>
    /// <param name="width">The width.</param>
    /// <param name="height">The height.</param>
    public Size(double width, double height)
    {
        this.Width = width;
        this.Height = height;
        this.widthAsInt = new Lazy<int>(() => Convert.ToInt32(this.Width));
        this.heightAsInt = new Lazy<int>(() => Convert.ToInt32(this.Height));
    }

    /// <summary>
    /// Gets the width as double.
    /// </summary>
    public double Width { get; }

    /// <summary>
    /// Gets the height as double.
    /// </summary>
    public double Height { get; }

    private readonly Lazy<int> widthAsInt;

    /// <summary>
    /// Gets the width as integer.
    /// </summary>
    public int WidthAsInt => this.widthAsInt.Value;

    private readonly Lazy<int> heightAsInt;

    /// <summary>
    /// Gets the height as integer.
    /// </summary>
    public int HeightAsInt => this.heightAsInt.Value;
}
