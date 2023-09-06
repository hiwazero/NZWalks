using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NZWalksAPI.Controllers
{
    // http://localhost:portnumber/api/students
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        // GET: http://localhost:portnumber/api/students
        [HttpGet]
        public IActionResult GetAllStudents() 
        {
            string[] studentNames = new string[] { "Butch", "Rhenalyn", "Jomar", "Cj" };
            return Ok(studentNames);
        }
    }
}
