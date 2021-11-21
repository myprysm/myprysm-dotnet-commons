namespace Myprysm.Testing;

public static class StringExtensions
{
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
