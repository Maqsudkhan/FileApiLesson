using FileApiLesson.Domain.Entities.DTOs;
using FileApiLesson.Domain.Entities.Models;
using Microsoft.AspNetCore.Http;

namespace FileApiLesson.Infrastructure.IRepository
{
    public interface IUserRepository
    {
        public Task<string> CreateUserProfileAsync(UserProfile user);
        public Task<List<UserProfile>> GetAllUserProfileAsync();
        public Task<UserProfile> GetByIdUserProfileAsync(int id);
        public Task<bool> DeleteUserProfileAsync(int id);
        public Task<UserProfile> UpdateUserProfileAsync(int id, UserProfileDTO userDTO);
        public Task<string> UpdateByPictureUserProfileAsync(int id, string picturePath);

    }
}
