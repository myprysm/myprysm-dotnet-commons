#### [Myprysm.Converter.Abstractions](index.md 'index')

## Myprysm.Converter.Abstractions Assembly
### Namespaces

<a name='Myprysm.Converter.Abstractions'></a>

## Myprysm.Converter.Abstractions Namespace

| Classes | |
| :--- | :--- |
| [ConverterOptions](Myprysm.Converter.Abstractions.ConverterOptions.md 'Myprysm.Converter.Abstractions.ConverterOptions') | Base converter options.<br/><br/>You should extend those options and use the dependency injection extensions if you want to enable tracing |
| [DependencyInjection](Myprysm.Converter.Abstractions.DependencyInjection.md 'Myprysm.Converter.Abstractions.DependencyInjection') | Dependency injection extensions |

| Interfaces | |
| :--- | :--- |
| [IConverter](Myprysm.Converter.Abstractions.IConverter.md 'Myprysm.Converter.Abstractions.IConverter') | Represents a converter from binary to object representation and vice-versa. |

<a name='Myprysm.Converter.Abstractions.Exceptions'></a>

## Myprysm.Converter.Abstractions.Exceptions Namespace

| Classes | |
| :--- | :--- |
| [ConversionReadException](Myprysm.Converter.Abstractions.Exceptions.ConversionReadException.md 'Myprysm.Converter.Abstractions.Exceptions.ConversionReadException') | Exception thrown when an [IConverter](Myprysm.Converter.Abstractions.IConverter.md 'Myprysm.Converter.Abstractions.IConverter') cannot read data. |
| [ConversionWriteException](Myprysm.Converter.Abstractions.Exceptions.ConversionWriteException.md 'Myprysm.Converter.Abstractions.Exceptions.ConversionWriteException') | Exception thrown when an [IConverter](Myprysm.Converter.Abstractions.IConverter.md 'Myprysm.Converter.Abstractions.IConverter') cannot write data. |
