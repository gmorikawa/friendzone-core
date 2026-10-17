using Microsoft.AspNetCore.Mvc;

namespace Friendzone.Http.Controllers;

[ApiController]
[Route("/")]
public class HelloController : ControllerBase
{
    private readonly Core.Email.Sender emailSender;

    public HelloController(Core.Email.Sender emailSender)
    {
        this.emailSender = emailSender;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Content("Hello World", "text/plain");
    }

    [HttpGet("email-test")]
    public IActionResult EmailTest()
    {
        emailSender.Send(
            to: "test@example.com",
            subject: "Test Email",
            body: "This is a test email."
        );

        return Content("Email test endpoint", "text/plain");
    }
}
