using FileApiLesson.API.ExternalServices;
using FileApiLesson.Application.Services.UserProfileServices;
using FileApiLesson.Domain.Entities.DTOs;
using FileApiLesson.Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FileApiLesson.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserProfileService _userProfileService;
        private readonly IWebHostEnvironment _env;
        public UserController(IUserProfileService userProfileService, IWebHostEnvironment env)
        {
            _userProfileService = userProfileService;
            _env = env;
        }


        // POST api/<UserController>
        [HttpPost]
        public async Task<ActionResult<string>> CraeteUser([FromForm] UserProfileDTO userProfileDTO, IFormFile picture)
        {
            UserProfileExternalService service = new UserProfileExternalService(_env);

            string picturePath = await service.AddPictureAndGetPath(picture);
            var result =  _userProfileService.CreateUserProfileAsync(userProfileDTO, picturePath).Result;
            return Ok(result);
        }


        // POST api/<UserController>
        [HttpPost]
        public IActionResult PostForm([FromForm] string value)
        {
            return Ok(value);
        }

   

    }
}
