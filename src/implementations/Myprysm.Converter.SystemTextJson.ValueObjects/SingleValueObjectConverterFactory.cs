using System.Text.Json;
using Myprysm.SharedKernel.ValueObjects;

namespace Myprysm.Converter.SystemTextJson.ValueObjects;

using System.Collections.Concurrent;
using System.Reflection;
using System.Text.Json.Serialization;

internal class SingleValueObjectConverterFactory : JsonConverterFactory
{
    private readonly Type converterGenericType = typeof(SingleValueObjectConverter<,>);
    private readonly ConcurrentDictionary<Type, JsonConverter> converters = new();

    public override bool CanConvert(Type typeToConvert)
    {
        return typeof(ISingleValueObject).GetTypeInfo().IsAssignableFrom(typeToConvert);
    }

    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        var converter = this.converters.GetOrAdd(
            typeToConvert,
            t =>
            {
                var wrappedType = t.BaseType?.GetGenericArguments() ?? throw new InvalidOperationException();
                var types = new[] { t }.Concat(wrappedType).ToArray();
                var constructedType = this.converterGenericType.MakeGenericType(types);
                return Activator.CreateInstance(constructedType) as JsonConverter ?? throw new InvalidOperationException();
            });

        return converter;
    }
}
