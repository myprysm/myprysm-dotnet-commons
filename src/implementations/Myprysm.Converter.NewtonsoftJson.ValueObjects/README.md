# Myprysm Converter NewtonsoftJson ValueObjects

Custom `JsonConverter` to support clean serde for `SingleValueObject<T>` from `Myprysm.SharedKernel`.

This allows proper (un)wrapping of the value.

## Configuration and usage

You can load the latest version of this converter
from [Myprysm Nuget repository](https://baget.myprysm.fr/packages/myprysm.converter.newtonsoftjson.valueobjects).

You can configure the `SingleValueObjectConverter` in your `JsonSerializerSettings` by using the `JsonSerializerSettingsExtensions`.

You can also add the attribute `[JsonConverter(typeof(SingleValueObjectConverter))]` on your `SingleValueObject<T>`
on an individual basis.

## Example

Let's consider a `SingleValueObject<T>` configured on an object:

```c#
public class StringSVO : SingleValueObject<string>
{
    public StringSVO(string value) : base(value)
    {
    }
}

public record MyObject(StringSVO MyStringProperty);

var svo = new StringSVO("something");
var myObject = new MyObject(svo);
var stringValue = JsonConvert.SerializeObject(myObject);
```

Without the `SingleValueObjectConverter`, the JSON output would be:

```json
{
  "myStringProperty": {
    "value": "something"
  }
}
```

**With** the `SingleValueObjectConverter`, the JSON output would be:

```json
{
  "myStringProperty": "something"
}
```

## Documentation

The API documentation is available [here](documentation/index.md).
