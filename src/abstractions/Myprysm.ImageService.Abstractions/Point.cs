namespace Myprysm.ImageService.Abstractions;

public sealed record Point
{
    public Point(double x, double y)
    {
        this.X = x;
        this.Y = y;
        this.xAsInt = new Lazy<int>(() => Convert.ToInt32(x));
        this.yAsInt = new Lazy<int>(() => Convert.ToInt32(y));
    }


    public double X { get; }

    public double Y { get; }

    private readonly Lazy<int> xAsInt;

    public int XAsInt => this.xAsInt.Value;

    private readonly Lazy<int> yAsInt;

    public int YAsInt => this.yAsInt.Value;
}
