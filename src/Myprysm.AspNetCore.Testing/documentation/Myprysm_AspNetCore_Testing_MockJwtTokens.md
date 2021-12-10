#### [Myprysm.AspNetCore.Testing](index.md 'index')
### [Myprysm.AspNetCore.Testing](index.md#Myprysm_AspNetCore_Testing 'Myprysm.AspNetCore.Testing')
## MockJwtTokens Class
Mock token issuer that can be used to generate JWTs for integration testing.  
```csharp
public static class MockJwtTokens
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; MockJwtTokens  
### Properties
<a name='Myprysm_AspNetCore_Testing_MockJwtTokens_Issuer'></a>
## MockJwtTokens.Issuer Property
The issuer name for the current test session.  
```csharp
public static string Issuer { get; }
```
#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
  
<a name='Myprysm_AspNetCore_Testing_MockJwtTokens_SecurityKey'></a>
## MockJwtTokens.SecurityKey Property
The security key for the current session.  
```csharp
public static Microsoft.IdentityModel.Tokens.SecurityKey SecurityKey { get; }
```
#### Property Value
[Microsoft.IdentityModel.Tokens.SecurityKey](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.IdentityModel.Tokens.SecurityKey 'Microsoft.IdentityModel.Tokens.SecurityKey')
  
<a name='Myprysm_AspNetCore_Testing_MockJwtTokens_SigningCredentials'></a>
## MockJwtTokens.SigningCredentials Property
The signing credentials for the current session.  
```csharp
public static Microsoft.IdentityModel.Tokens.SigningCredentials SigningCredentials { get; }
```
#### Property Value
[Microsoft.IdentityModel.Tokens.SigningCredentials](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.IdentityModel.Tokens.SigningCredentials 'Microsoft.IdentityModel.Tokens.SigningCredentials')
  
### Methods
<a name='Myprysm_AspNetCore_Testing_MockJwtTokens_GenerateJwtToken(System_Security_Claims_Claim__)'></a>
## MockJwtTokens.GenerateJwtToken(Claim[]) Method
Generate a JWT with the provided claims.  
```csharp
public static string GenerateJwtToken(params System.Security.Claims.Claim[] claims);
```
#### Parameters
<a name='Myprysm_AspNetCore_Testing_MockJwtTokens_GenerateJwtToken(System_Security_Claims_Claim__)_claims'></a>
`claims` [System.Security.Claims.Claim](https://docs.microsoft.com/en-us/dotnet/api/System.Security.Claims.Claim 'System.Security.Claims.Claim')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The claims to add in the JWT.
  
#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The JWT with the claims, signed with 
  
