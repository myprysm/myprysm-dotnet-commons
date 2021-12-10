#### [Myprysm.AspNetCore.Testing](index.md 'index')
### [Myprysm.AspNetCore.Testing](index.md#Myprysm_AspNetCore_Testing 'Myprysm.AspNetCore.Testing')
## IntegrationTests&lt;TStartup&gt; Class
Base integration test to remotely assert the behaviour of an API.   
```csharp
public abstract class IntegrationTests<TStartup> : Myprysm.Testing.NUnit.FixtureTests
    where TStartup : class
```
#### Type parameters
<a name='Myprysm_AspNetCore_Testing_IntegrationTests_TStartup__TStartup'></a>
`TStartup`  
The entry point of the API under test.
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Myprysm.Testing.NUnit.FixtureTests](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.Testing.NUnit.FixtureTests 'Myprysm.Testing.NUnit.FixtureTests') &#129106; IntegrationTests&lt;TStartup&gt;  
### Methods
<a name='Myprysm_AspNetCore_Testing_IntegrationTests_TStartup__SetUpApi()'></a>
## IntegrationTests&lt;TStartup&gt;.SetUpApi() Method
Configure the [Myprysm.AspNetCore.Testing.IntegrationTests&lt;&gt;.Client](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.AspNetCore.Testing.IntegrationTests-1.Client 'Myprysm.AspNetCore.Testing.IntegrationTests`1.Client') and [Myprysm.AspNetCore.Testing.IntegrationTests&lt;&gt;.Services](https://docs.microsoft.com/en-us/dotnet/api/Myprysm.AspNetCore.Testing.IntegrationTests-1.Services 'Myprysm.AspNetCore.Testing.IntegrationTests`1.Services') for the current test suite.  
```csharp
public void SetUpApi();
```
  
