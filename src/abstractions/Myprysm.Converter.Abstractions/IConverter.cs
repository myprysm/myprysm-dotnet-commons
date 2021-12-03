namespace Myprysm.Converter.Abstractions;

using System.Text;
using Myprysm.Converter.Abstractions.Exceptions;

/// <summary>
/// Represents a converter from binary to object representation and vice-versa.
/// </summary>
public interface IConverter
{
    /// <summary>
    /// The default encoding for string conversions.
    /// </summary>
    public static readonly Encoding DefaultEncoding = new UTF8Encoding(false, true);

    /// <summary>
    /// Read the data stream and returns optionally an object of the provided type. 
    /// </summary>
    /// <param name="data">The data stream.</param>
    /// <param name="type">The type of the data.</param>
    /// <returns>An optional object of the provided type.</returns>
    /// <exception cref="ConversionReadException">When the converter cannot read the data.</exception>
    object? Read(Stream data, Type type);

    /// <summary>
    /// Read the byte array and returns optionally an object of the provided type. 
    /// </summary>
    /// <param name="data">The byte array.</param>
    /// <param name="type">The type of the data.</param>
    /// <returns>An optional object of the provided type.</returns>
    /// <exception cref="ConversionReadException">When the converter cannot read the data.</exception>
    public object? Read(byte[] data, Type type)
    {
        using var stream = new MemoryStream(data);
        return this.Read(stream, type);
    }

    /// <summary>
    /// Read the stream and returns optionally an object of the provided type. 
    /// </summary>
    /// <param name="data">The stream.</param>
    /// <param name="type">The type of the data.</param>
    /// <returns>An optional object of the provided type.</returns>
    /// <exception cref="ConversionReadException">When the converter cannot read the data.</exception>
    public object? Read(string data, Type type)
    {
        var bytes = DefaultEncoding.GetBytes(data);
        return this.Read(bytes, type);
    }

    /// <summary>
    /// Read the data stream and returns optionally an object of the provided type. 
    /// </summary>
    /// <param name="data">The data stream.</param>
    /// <typeparam name="TObj">The type of the data.</typeparam>
    /// <returns>An optional object of the provided type.</returns>
    /// <exception cref="ConversionReadException">When the converter cannot read the data.</exception>
    public TObj? Read<TObj>(Stream data) => (TObj?)this.Read(data, typeof(TObj?));

    /// <summary>
    /// Read the byte array and returns optionally an object of the provided type. 
    /// </summary>
    /// <param name="data">The byte array.</param>
    /// <typeparam name="TObj">The type of the data.</typeparam>
    /// <returns>An optional object of the provided type.</returns>
    /// <exception cref="ConversionReadException">When the converter cannot read the data.</exception>
    public TObj? Read<TObj>(byte[] data) => (TObj?)this.Read(data, typeof(TObj));

    /// <summary>
    /// Read the string and returns optionally an object of the provided type. 
    /// </summary>
    /// <param name="data">The string.</param>
    /// <typeparam name="TObj">The type of the data.</typeparam>
    /// <returns>An optional object of the provided type.</returns>
    /// <exception cref="ConversionReadException">When the converter cannot read the data.</exception>
    public TObj? Read<TObj>(string data) => (TObj?)this.Read(data, typeof(TObj));

    /// <summary>
    /// Write the data to the provided stream.
    /// </summary>
    /// <remarks>
    /// The stream should not be disposed, the position should not be changed after writing.
    /// </remarks>
    /// <param name="data">The data to write.</param>
    /// <param name="stream">The stream to write the data into.</param>
    /// <exception cref="ConversionWriteException">When the converter cannot write the data.</exception>
    void WriteToStream(object? data, Stream stream);

    /// <summary>
    /// Write the data as a byte array representation.
    /// </summary>
    /// <param name="data">The data to write.</param>
    /// <returns>The byte array representation of the data.</returns>
    /// <exception cref="ConversionWriteException">When the converter cannot write the data.</exception>
    public byte[] WriteBytes(object? data)
    {
        using var stream = new MemoryStream();
        this.WriteToStream(data, stream);

        return stream.ToArray();
    }

    /// <summary>
    /// Write the data as a string representation.
    /// </summary>
    /// <param name="data">The data to write.</param>
    /// <returns>The string representation of the data.</returns>
    /// <exception cref="ConversionWriteException">When the converter cannot write the data.</exception>
    public string WriteString(object? data)
    {
        var bytes = this.WriteBytes(data);
        return DefaultEncoding.GetString(bytes);
    }

    /// <summary>
    /// Convert the data to the requested type.
    /// </summary>
    /// <param name="data">The data to convert.</param>
    /// <param name="type">The destination type.</param>
    /// <returns>An optional object of the requested type.</returns>
    /// <exception cref="ConversionReadException">When the converter cannot read the data.</exception>
    /// <exception cref="ConversionWriteException">When the converter cannot write the data.</exception>
    public object? Convert(object data, Type type)
    {
        using var stream = new MemoryStream();
        this.WriteToStream(data, stream);

        stream.Position = 0;
        return this.Read(stream, type);
    }

    /// <summary>
    /// Convert the data to the requested type.
    /// </summary>
    /// <param name="data">The data to convert.</param>
    /// <typeparam name="TObj">The destination type.</typeparam>
    /// <returns>An optional object of the requested type.</returns>
    /// <exception cref="ConversionReadException">When the converter cannot read the data.</exception>
    /// <exception cref="ConversionWriteException">When the converter cannot write the data.</exception>
    public TObj? Convert<TObj>(object data) => (TObj?)this.Convert(data, typeof(TObj?));
}
