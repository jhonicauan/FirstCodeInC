using Microsoft.AspNetCore.Mvc;

namespace FirstCodeInC.Controller;

[ApiController]
[Route("Student")]
public class StudentController
{
    [HttpGet]
    [Route("Test")]
    public IActionResult HelloWorld()
    {
        try
        {
            return new OkObjectResult("Hello World");
        }
        catch (Exception e)
        {
            return new BadRequestObjectResult(e.Message);
        }
    }
}