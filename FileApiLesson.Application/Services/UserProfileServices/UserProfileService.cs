using FileApiLesson.Domain.Entities.DTOs;
using FileApiLesson.Domain.Entities.Models;
using FileApiLesson.Infrastructure.IRepository;
using Microsoft.AspNetCore.Http;

namespace FileApiLesson.Application.Services.UserProfileServices
{
    public class UserProfileService : IUserProfileService
    {
        private readonly IUserRepository _userRepository;

        public UserProfileService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public async Task<string> CreateUserProfileAsync(UserProfileDTO userDTO, string picturePath)
        {
            //UserProfileExternalService obj = new UserProfileExternalService(); 

            var model = new UserProfile()
            {
                FullName = userDTO.FullName,
                Phone = userDTO.Phone,
                UserRole = userDTO.UserRole,
                Login = userDTO.Login,
                Password = userDTO.Password,
                //PicturePath = await obj.AddPictureAndGetPath(userDTO.Picture),
                PicturePath = picturePath,
            };

            /*await _context.Users.AddAsync(model);
            await _context.SaveChangesAsync();*/
            var result = _userRepository.CreateUserProfileAsync(model);
            return result.Result;
        }

        public Task<bool> DeleteUserProfileAsync(int id)
        {
            return _userRepository.DeleteUserProfileAsync(id);
        }

        public Task<List<UserProfile>> GetAllUserProfileAsync()
        {
            var result = _userRepository.GetAllUserProfileAsync();
            return result;
        }

        public Task<UserProfile> GetByIdUserProfileAsync(int id)
        {
            var result = _userRepository.GetByIdUserProfileAsync(id);
            return result;
        }

        public async Task<string> UpdateByPictureUserProfileAsync(int id, string picturePath)
        {
            var x = _userRepository.UpdateByPictureUserProfileAsync(id, picturePath).Result;
            return x;
        }

        public Task<UserProfile> UpdateUserProfileAsync(int id, UserProfileDTO userDTO)
        {
            var result = _userRepository.UpdateUserProfileAsync(id, userDTO);
            return result;
        }
    }
}


