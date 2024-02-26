using FileApiLesson.Domain.Entities.DTOs;
using FileApiLesson.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileApiLesson.Application.Services.UserProfileServices
{
    public interface IUserProfileServices
    {
        public Task<UserProfileDTO> CreateUserProfileAsync(UserProfileDTO userDTO);
        public Task<List<UserProfile>> GetAllUserProfileAsync();
        public Task<UserProfile> GetByIdUserProfileAsync(int id);
        public Task<bool> DeleteUserProfileAsync(int id);
        public Task<UserProfile> UpdateUserProfileAsync(int id, UserProfileDTO userDTO);

    }
}
