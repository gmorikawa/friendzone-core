using Microsoft.AspNetCore.Mvc;

namespace Friendzone.Http.Controllers;

[ApiController]
[Route("/")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Content("Hello World", "text/plain");
    }
}
