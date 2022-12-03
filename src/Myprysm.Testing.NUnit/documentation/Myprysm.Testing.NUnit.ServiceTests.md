#### [Myprysm.Testing.NUnit](index.md 'index')
### [Myprysm.Testing.NUnit](index.md#Myprysm.Testing.NUnit 'Myprysm.Testing.NUnit')

## ServiceTests Class

Base class that provides dependency injection and fixture support.

```csharp
public abstract class ServiceTests : Myprysm.Testing.NUnit.FixtureTests
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [FixtureTests](Myprysm.Testing.NUnit.FixtureTests.md 'Myprysm.Testing.NUnit.FixtureTests') &#129106; ServiceTests
### Methods

<a name='Myprysm.Testing.NUnit.ServiceTests.SetUpDependencyInjection()'></a>

## ServiceTests.SetUpDependencyInjection() Method

Create the service provider used in each test.

```csharp
public void SetUpDependencyInjection();
```

<a name='Myprysm.Testing.NUnit.ServiceTests.TearDownDependencyInjection()'></a>

## ServiceTests.TearDownDependencyInjection() Method

Dispose the [System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider') use in the test.

```csharp
public void TearDownDependencyInjection();
```