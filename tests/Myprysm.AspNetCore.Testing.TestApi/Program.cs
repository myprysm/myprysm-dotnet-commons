using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Myprysm.AspNetCore.Testing.TestApi;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddSingleton(new Response(1))
    .AddControllers();


builder.Services
    .AddAuthorization(options =>
    {
        options.DefaultPolicy = new AuthorizationPolicyBuilder(JwtBearerDefaults.AuthenticationScheme)
            .RequireAuthenticatedUser()
            .Build();


        options.AddPolicy(
            "custom-policy",
            b => b.RequireClaim("scope", "custom:claim"));
    })
    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

namespace Myprysm.AspNetCore.Testing.TestApi
{
    public partial class Program
    {
    }
}
