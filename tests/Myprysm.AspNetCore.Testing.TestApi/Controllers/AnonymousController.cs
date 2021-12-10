namespace Myprysm.AspNetCore.Testing.Tests;

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("anonymous")]
public class AnonymousController : ControllerBase
{
    [HttpGet("")]
    public IActionResult GetAnonymousResource()
    {
        return this.Ok(new Response(3));
    }
}
