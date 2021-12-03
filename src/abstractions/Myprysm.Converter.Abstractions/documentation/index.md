#### [Myprysm.Converter.Abstractions](index.md 'index')
### Namespaces
<a name='Myprysm_Converter_Abstractions'></a>
## Myprysm.Converter.Abstractions Namespace

| Classes | |
| :--- | :--- |
| [ConverterOptions](Myprysm_Converter_Abstractions_ConverterOptions.md 'Myprysm.Converter.Abstractions.ConverterOptions') | Base converter options.<br/><br/>You should extend those options and use the dependency injection extensions if you want to enable tracing<br/> |
| [DependencyInjection](Myprysm_Converter_Abstractions_DependencyInjection.md 'Myprysm.Converter.Abstractions.DependencyInjection') | Dependency injection extensions<br/> |

| Interfaces | |
| :--- | :--- |
| [IConverter](Myprysm_Converter_Abstractions_IConverter.md 'Myprysm.Converter.Abstractions.IConverter') | Represents a converter from binary to object representation and vice-versa.<br/> |
  
<a name='Myprysm_Converter_Abstractions_Exceptions'></a>
## Myprysm.Converter.Abstractions.Exceptions Namespace

| Classes | |
| :--- | :--- |
| [ConversionReadException](Myprysm_Converter_Abstractions_Exceptions_ConversionReadException.md 'Myprysm.Converter.Abstractions.Exceptions.ConversionReadException') | Exception thrown when an [IConverter](Myprysm_Converter_Abstractions_IConverter.md 'Myprysm.Converter.Abstractions.IConverter') cannot read data.<br/> |
| [ConversionWriteException](Myprysm_Converter_Abstractions_Exceptions_ConversionWriteException.md 'Myprysm.Converter.Abstractions.Exceptions.ConversionWriteException') | Exception thrown when an [IConverter](Myprysm_Converter_Abstractions_IConverter.md 'Myprysm.Converter.Abstractions.IConverter') cannot write data.<br/> |
  
