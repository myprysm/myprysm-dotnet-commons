namespace Myprysm.AspNetCore.Testing;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

/// <summary>
/// An authenticated <see cref="WebApplicationFactory{TEntryPoint}"/> that configures the <see cref="MockJwtTokens"/> issuer for testing.
/// </summary>
/// <typeparam name="TStartup"></typeparam>
public abstract class AuthenticatedWebApplicationFactory<TStartup> : WebApplicationFactory<TStartup>
    where TStartup : class
{
    /// <inheritdoc />
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        base.ConfigureWebHost(builder);
        builder.ConfigureServices(services =>
            services.Configure<JwtBearerOptions>(JwtBearerDefaults.AuthenticationScheme,
                options =>
                {
                    var config = new OpenIdConnectConfiguration { Issuer = MockJwtTokens.Issuer };

                    config.SigningKeys.Add(MockJwtTokens.SecurityKey);
                    options.Configuration = config;
                    options.TokenValidationParameters.ValidateAudience = false;
                }));
    }
}
