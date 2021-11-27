namespace Myprysm.Testing.NUnit;

public static class TypeExtensions
{
    public static Stream GetResourceStream(this Type type, string resource)
    {
        var stream = type.Assembly.GetManifestResourceStream(type, resource);

        if (stream is null)
        {
            throw new FileNotFoundException($"Can't find resource with name {resource}", resource);
        }

        return stream;
    }
}
