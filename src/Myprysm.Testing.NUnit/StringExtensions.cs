namespace Myprysm.Testing.NUnit;

/// <summary>
/// String extensions useful for testing.
/// </summary>
public static class StringExtensions
{
    /// <summary>
    /// Get the content of a file at the given path as a <see cref="Stream"/>.
    /// </summary>
    /// <param name="path">The path of the file, absolute or relative to the current running project target.</param>
    /// <returns>The file as a <see cref="Stream"/>.</returns>
    /// <exception cref="FileNotFoundException">When the file does not exist at the given path.</exception>
    public static Stream GetFileStream(this string path)
    {
        var fileInfo = new FileInfo(path);

        if (!fileInfo.Exists)
        {
            throw new FileNotFoundException($"Can't find file with name {path}", path);
        }

        return fileInfo.OpenRead();
    }
}
