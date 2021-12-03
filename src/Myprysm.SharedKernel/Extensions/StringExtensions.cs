namespace Myprysm.SharedKernel.Extensions;

/// <summary>
/// <see cref="string"/> extensions.
/// </summary>
public static class StringExtensions
{
    /// <summary>
    /// Format fluently a <see cref="string"/>.
    /// </summary>
    /// <param name="subject">The <see cref="string"/> subject.</param>
    /// <param name="items">The parameter items for the formatting.</param>
    /// <returns>The fluently formatted string.</returns>
    public static string Fmt(this string subject, params object[] items)
    {
        return string.Format(subject, items);
    }
}
