using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FileApiLesson.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IWebHostEnvironment _webHostEnvironment;


        // POST api/<UserController>
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return Ok(value);
        }


        // POST api/<UserController>
        [HttpPost]
        public IActionResult PostForm([FromForm] string value)
        {
            return Ok(value);
        }

   

    }
}
