using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
public class ValuesController : ControllerBase
    {
        //[Route]
    }
};

private List<string> students = new List<string>();
{
    "abcd",
    "Sachin",
    "rahul",
};

private List<Dictionary<string, string>> student_dict = new List<Dictionary<string, string>>
{
    new Dictionary<string, string>{{"id","1"},{"name","Sachin"}},
    new Dictionary<string, string>{{"id","2"},{"name","Rahul"}},
};

[HttpGet]

public IActionResult GetAllStudents()
{
    return new JsonResult(student_dict);
};



