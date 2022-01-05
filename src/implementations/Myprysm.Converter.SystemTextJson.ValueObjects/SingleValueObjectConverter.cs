using System.Text.Json;
using System.Text.Json.Serialization;
using Myprysm.SharedKernel.ValueObjects;

namespace Myprysm.Converter.SystemTextJson.ValueObjects;

using System.Reflection;

internal class SingleValueObjectConverter<TSvo, TWrapped> : JsonConverter<TSvo>
    where TSvo : SingleValueObject<TWrapped>
    where TWrapped : IComparable
{
    // ReSharper disable once StaticMemberInGenericType
    private static readonly Type UnderlyingType;
    private static readonly TypeInfo SvoTypeInfo;
    
    static SingleValueObjectConverter()
    {
        SvoTypeInfo = typeof(TSvo).GetTypeInfo();
        UnderlyingType = typeof(TWrapped);
    }
    
    public override bool CanConvert(Type typeToConvert)
    {
        return SvoTypeInfo.IsAssignableFrom(typeToConvert);
    }

    public override TSvo? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return default;
        }

        var value = JsonSerializer.Deserialize(ref reader, UnderlyingType, options);

        return (TSvo?)Activator.CreateInstance(typeToConvert, value);
    }

    public override void Write(Utf8JsonWriter writer, TSvo value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value.Value, options);
    }
}
