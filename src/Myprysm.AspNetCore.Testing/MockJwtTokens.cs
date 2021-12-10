namespace Myprysm.AspNetCore.Testing;

using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using Microsoft.IdentityModel.Tokens;

/// <summary>
/// Mock token issuer that can be used to generate JWTs for integration testing.
/// </summary>
public static class MockJwtTokens
{
    /// <summary>
    /// The issuer name for the current test session.
    /// </summary>
    public static string Issuer { get; } = Guid.NewGuid().ToString();

    /// <summary>
    /// The security key for the current session.
    /// </summary>
    public static SecurityKey SecurityKey { get; }

    /// <summary>
    /// The signing credentials for the current session.
    /// </summary>
    public static SigningCredentials SigningCredentials { get; }

    private static readonly JwtSecurityTokenHandler TokenHandler = new();
    private static readonly RandomNumberGenerator Rng = RandomNumberGenerator.Create();
    private static readonly byte[] Key = new byte[32];

    static MockJwtTokens()
    {
        Rng.GetBytes(Key);
        SecurityKey = new SymmetricSecurityKey(Key) { KeyId = Guid.NewGuid().ToString(), };
        SigningCredentials = new SigningCredentials(SecurityKey, SecurityAlgorithms.HmacSha256);
    }

    /// <summary>
    /// Generate a JWT with the provided claims.
    /// </summary>
    /// <param name="claims">The claims to add in the JWT.</param>
    /// <returns>The JWT with the claims, signed with </returns>
    public static string GenerateJwtToken(params Claim[] claims)
    {
        return TokenHandler.WriteToken(new JwtSecurityToken(Issuer, null, claims, null, DateTime.UtcNow.AddMinutes(20), SigningCredentials));
    }
}
