namespace Myprysm.ImageService.Abstractions;

public sealed record Size
{
    public Size(double width, double height)
    {
        this.Width = width;
        this.Height = height;
        this.widthAsInt = new Lazy<int>(() => Convert.ToInt32(this.Width));
        this.heightAsInt = new Lazy<int>(() => Convert.ToInt32(this.Height));
    }

    public double Width { get; }

    public double Height { get; }

    private readonly Lazy<int> widthAsInt;

    public int WidthAsInt => this.widthAsInt.Value;

    private readonly Lazy<int> heightAsInt;

    public int HeightAsInt => this.heightAsInt.Value;
}
