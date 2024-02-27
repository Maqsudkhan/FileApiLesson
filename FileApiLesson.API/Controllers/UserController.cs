using FileApiLesson.API.ExternalServices;
using FileApiLesson.Application.Services.UserProfileServices;
using FileApiLesson.Domain.Entities.DTOs;
using FileApiLesson.Domain.Entities.Models;
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
            var result = _userProfileService.CreateUserProfileAsync(userProfileDTO, picturePath).Result;
            return Ok(result);
        }


        [HttpDelete]
        public async Task<bool> DeleteUser(int id)
        {
            var result = _userProfileService.DeleteUserProfileAsync(id).Result;
            return result;
        }


        [HttpGet]
        public async Task<List<UserProfile>> GelAllUser()
        {
            var result = _userProfileService.GetAllUserProfileAsync().Result;
            return result;
        }

        [HttpGet]
        public async Task<UserProfile> GetByIdUser(int id)
        {
            var x = _userProfileService.GetByIdUserProfileAsync(id).Result;
            return x;
        }

        [HttpPut]
        public async Task<UserProfile> UpdateUser(int id, UserProfileDTO userDTO)
        {
            var res = _userProfileService.UpdateUserProfileAsync(id, userDTO).Result;
            return res;
        }

        [HttpPut]

        public async Task<string> UpdatePictureByIdUser (int id, IFormFile picture)
        {
            UserProfileExternalService service = new UserProfileExternalService(_env);
            string picturepath = await service.AddPictureAndGetPath(picture);
            return _userProfileService.UpdateByPictureUserProfileAsync(id, picturepath).Result;
        }

    }
}
