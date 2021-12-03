namespace Myprysm.Converter.Abstractions.Tests.Unit;

using Myprysm.Converter.Abstractions;

public class FakeConverter : IConverter
{
    private readonly Func<object?> read;
    private readonly Action write;

    private FakeConverter(
        Func<object?> read,
        Action write)
    {
        this.read = read;
        this.write = write;
    }

    public object? Read(Stream data, Type type)
    {
        return this.read();
    }

    public void WriteToStream(object? data, Stream stream)
    {
        this.write();
    }

    public static FakeConverterBuilder Builder => new();

    public class FakeConverterBuilder
    {
        private Func<object?> read = () => null;
        private Action write = () => { };

        public FakeConverterBuilder ReadReturns(object? value)
        {
            this.read = () => value;
            return this;
        }

        public FakeConverterBuilder ReadThrows(Exception exception)
        {
            this.read = () => throw exception;
            return this;
        }

        public FakeConverterBuilder WriteSucceeds()
        {
            this.write = () => { };
            return this;
        }

        public FakeConverterBuilder WriteThrows(Exception exception)
        {
            this.write = () => throw exception;
            return this;
        }

        public FakeConverter Build()
        {
            return new FakeConverter(this.read, this.write);
        }
    }
}
