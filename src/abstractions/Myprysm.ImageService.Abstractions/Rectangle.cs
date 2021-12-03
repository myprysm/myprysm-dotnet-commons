namespace Myprysm.ImageService.Abstractions;

/// <summary>
/// Represents a rectangle with an origin <see cref="Point"/> and a <see cref="Size"/> dimension.
/// </summary>
/// <param name="Point">The origin of the rectangle.</param>
/// <param name="Size">The size of the rectangle.</param>
public sealed record Rectangle(
    Point Point,
    Size Size);
