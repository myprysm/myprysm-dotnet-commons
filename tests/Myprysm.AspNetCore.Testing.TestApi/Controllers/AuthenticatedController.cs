namespace Myprysm.AspNetCore.Testing.Tests;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Authorize]
[ApiController]
[Route("authorized")]
public class AuthenticatedController : ControllerBase
{
    [HttpGet("")]
    public IActionResult GetDefaultAuthorizedResource()
    {
        return this.Ok(new Response(42));
    }
    
    [Authorize("custom-policy")]
    [HttpGet("scoped")]
    public IActionResult GetScopeAuthorizedResource()
    {
        return this.Ok(new Response(69));
    }
}
