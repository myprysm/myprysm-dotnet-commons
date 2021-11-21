namespace Myprysm.Converter.Abstractions;

using System.Text;

public interface IConverter
{
    public static readonly Encoding DefaultEncoding = new UTF8Encoding(false, true);

    object? Read(Stream data, Type type);

    public TObj? Read<TObj>(byte[] data) => (TObj?)this.Read(data, typeof(TObj));

    public TObj? Read<TObj>(string data) => (TObj?)this.Read(data, typeof(TObj));

    public TObj? Read<TObj>(Stream data) => (TObj?)this.Read(data, typeof(TObj?));

    public object? Read(byte[] data, Type tObj)
    {
        using var stream = new MemoryStream(data);
        return this.Read(stream, tObj);
    }

    public object? Read(string data, Type tObj)
    {
        var bytes = DefaultEncoding.GetBytes(data);
        return this.Read(bytes, tObj);
    }

    void WriteToStream(object data, Stream stream);


    public byte[] WriteBytes(object data)
    {
        using var stream = new MemoryStream();
        this.WriteToStream(data, stream);

        return stream.ToArray();
    }

    public string WriteString(object data)
    {
        var bytes = this.WriteBytes(data);
        return DefaultEncoding.GetString(bytes);
    }

    public object? Convert(object data, Type tObj)
    {
        using var stream = new MemoryStream();
        this.WriteToStream(data, stream);

        stream.Position = 0;
        return this.Read(stream, tObj);
    }

    public TObj? Convert<TObj>(object data)
    {
        return (TObj?)this.Convert(data, typeof(TObj?));
    }
}
