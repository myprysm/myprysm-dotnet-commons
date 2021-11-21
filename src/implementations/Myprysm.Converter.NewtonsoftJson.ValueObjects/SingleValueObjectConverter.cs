namespace Myprysm.Converter.NewtonsoftJson.ValueObjects;

using System.Collections.Concurrent;
using System.Reflection;
using Myprysm.SharedKernel.ValueObjects;
using Newtonsoft.Json;

public class SingleValueObjectConverter : JsonConverter
{
    private static readonly ConcurrentDictionary<Type, Type> ConstructorArgumentTypes = new();

    public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
    {
        if (value is not ISingleValueObject singleValueObject)
        {
            return;
        }

        serializer.Serialize(writer, singleValueObject.GetValue());
    }

    public override object? ReadJson(
        JsonReader reader,
        Type objectType,
        object? existingValue,
        JsonSerializer serializer)
    {
        if (reader.Value == null)
        {
            return null;
        }

        var parameterType = ConstructorArgumentTypes.GetOrAdd(
            objectType,
            static (_, ot) =>
            {
                var constructorInfo = ot.GetTypeInfo()
                    .GetConstructors(BindingFlags.Public | BindingFlags.Instance)
                    .Single();
                var parameterInfo = constructorInfo.GetParameters().Single();
                return parameterInfo.ParameterType;
            },
            objectType);

        var value = serializer.Deserialize(reader, parameterType);

        return Activator.CreateInstance(objectType, value);
    }

    public override bool CanConvert(Type objectType)
    {
        return typeof(ISingleValueObject).GetTypeInfo().IsAssignableFrom(objectType);
    }
}
