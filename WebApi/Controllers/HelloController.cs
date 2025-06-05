using Microsoft.AspNetCore.Mvc;
using WebApi.Services;

namespace WebApi.Controllers;

[ApiController]
[Route("hello-test")]
public class HelloController : ControllerBase
{
    private readonly IHelloService _service;

    public HelloController(IHelloService service)
    {
        _service = service;
    }

    [HttpGet]
    public ActionResult<string> GetGreeting()
    {
        return _service.GetGreeting();
    }
}
