using FirstCodeInC.Model;
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

    [HttpPost]
    [Route("AddStudent")]
    public IActionResult AddStudent([FromBody] StudentModel Student)
    {
        try
        {
            if (!Student.BirthdayIsValid())
            {
                return new BadRequestObjectResult("Data de nascimento invalida");
            }
            Student.CalculateAge();
            return new OkObjectResult("Ola novo estudante " + Student.Name + " de idade " + Student.Age +" e matricula " + Student.Enrollment + " é um prazer lhe conhecer");
        }
        catch (Exception e)
        {
            return new BadRequestObjectResult(e.Message);
        }
    }
}