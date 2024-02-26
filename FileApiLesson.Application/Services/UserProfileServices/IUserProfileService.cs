using FileApiLesson.Domain.Entities.DTOs;
using FileApiLesson.Domain.Entities.Models;

namespace FileApiLesson.Application.Services.UserProfileServices
{
    public interface IUserProfileService
    {
        public Task<string> CreateUserProfileAsync(UserProfileDTO userDTO, string picturePath);
        public Task<List<UserProfile>> GetAllUserProfileAsync();
        public Task<UserProfile> GetByIdUserProfileAsync(int id);
        public Task<bool> DeleteUserProfileAsync(int id);
        public Task<UserProfile> UpdateUserProfileAsync(int id, UserProfileDTO userDTO);

    }
}
