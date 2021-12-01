namespace Myprysm.FileService.Abstractions.ValueObjects;

using Myprysm.SharedKernel.ValueObjects;

/// <summary>
/// An ETag used for cache control.
/// </summary>
public class ETag : SingleValueObject<string>
{
    /// <summary>
    /// The representation for All ("*").
    /// </summary>
    public static readonly ETag All = From("*");

    /// <summary>
    /// Creates a new <see cref="ETag"/> with the provided value.
    /// </summary>
    /// <param name="value">The value.</param>
    public ETag(string value) : base(value)
    {
    }

    /// <summary>
    /// Factory method to create an <see cref="ETag"/> with the provided value.
    /// </summary>
    /// <param name="etag">The value.</param>
    /// <returns>The <see cref="ETag"/> with the value.</returns>
    public static ETag From(string etag)
    {
        return new ETag(etag);
    }
}
