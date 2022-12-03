namespace Myprysm.ImageService.Abstractions;

/// <summary>
/// Represents a point in a 2-dimensional space.
/// </summary>
public sealed record Point
{
    /// <summary>
    /// Creates a new <see cref="Point"/>.
    /// </summary>
    /// <param name="x">The x coordinate.</param>
    /// <param name="y">The y coordinate.</param>
    public Point(double x, double y)
    {
        this.X = x;
        this.Y = y;
        this.xAsInt = new Lazy<int>(() => Convert.ToInt32(x));
        this.yAsInt = new Lazy<int>(() => Convert.ToInt32(y));
    }

    /// <summary>
    /// Gets the x coordinate as double.
    /// </summary>
    public double X { get; }

    /// <summary>
    /// Gets the y coordinate as double.
    /// </summary>
    public double Y { get; }

    private readonly Lazy<int> xAsInt;

    /// <summary>
    /// Gets the x coordinate as integer.
    /// </summary>
    public int XAsInt => this.xAsInt.Value;

    private readonly Lazy<int> yAsInt;

    /// <summary>
    /// Gets the y coordinate as integer.
    /// </summary>
    public int YAsInt => this.yAsInt.Value;
}
