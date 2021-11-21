namespace Myprysm.SharedKernel.Extensions;

public static class StringExtensions
{
    public static string Fmt(this string subject, params object[] items)
    {
        return string.Format(subject, items);
    }
}
