namespace Myprysm.Testing.NUnit;

/// <summary>
/// Type extensions useful for testing.
/// </summary>
public static class TypeExtensions
{
    /// <summary>
    /// Get a resource located identified by the provided name
    /// and located in the same namespace/directory as the provided type.
    /// </summary>
    /// <param name="type">The type to locate relatively the resource.</param>
    /// <param name="resource">The resource to get.</param>
    /// <returns>The resource as a <see cref="Stream"/>.</returns>
    /// <exception cref="FileNotFoundException">When the requested resource does not exist.</exception>
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
