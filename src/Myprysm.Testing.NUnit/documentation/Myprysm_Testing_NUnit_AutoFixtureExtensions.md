#### [Myprysm.Testing.NUnit](index.md 'index')
### [Myprysm.Testing.NUnit](index.md#Myprysm_Testing_NUnit 'Myprysm.Testing.NUnit')
## AutoFixtureExtensions Class
Extensions to make AutoFixture configuration easier.  
```csharp
public static class AutoFixtureExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; AutoFixtureExtensions  
### Methods
<a name='Myprysm_Testing_NUnit_AutoFixtureExtensions_LoadCustomizations(AutoFixture_IFixture_System_Reflection_Assembly)'></a>
## AutoFixtureExtensions.LoadCustomizations(IFixture, Assembly) Method
Load the [AutoFixture.ICustomization](https://docs.microsoft.com/en-us/dotnet/api/AutoFixture.ICustomization 'AutoFixture.ICustomization') available in the provided assembly.  
```csharp
public static AutoFixture.IFixture LoadCustomizations(this AutoFixture.IFixture fixture, System.Reflection.Assembly customizationAssembly);
```
#### Parameters
<a name='Myprysm_Testing_NUnit_AutoFixtureExtensions_LoadCustomizations(AutoFixture_IFixture_System_Reflection_Assembly)_fixture'></a>
`fixture` [AutoFixture.IFixture](https://docs.microsoft.com/en-us/dotnet/api/AutoFixture.IFixture 'AutoFixture.IFixture')  
The fixture.
  
<a name='Myprysm_Testing_NUnit_AutoFixtureExtensions_LoadCustomizations(AutoFixture_IFixture_System_Reflection_Assembly)_customizationAssembly'></a>
`customizationAssembly` [System.Reflection.Assembly](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.Assembly 'System.Reflection.Assembly')  
The assembly to load customizations from.
  
#### Returns
[AutoFixture.IFixture](https://docs.microsoft.com/en-us/dotnet/api/AutoFixture.IFixture 'AutoFixture.IFixture')  
The fixture for fluent APIs.
  
