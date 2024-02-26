using FileApiLesson.API.ExternalServices;
using FileApiLesson.Domain.Entities.DTOs;
using FileApiLesson.Domain.Entities.Models;
using FileApiLesson.Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileApiLesson.Application.Services.UserProfileServices
{
    public class UserProfileService : IUserProfileServices
    {
        private readonly ApplicationDbContext _context;

        public UserProfileService(ApplicationDbContext context)
        {
            _context = context;
        }

  
        public Task<UserProfileDTO> CreateUserProfileAsync(UserProfileDTO userDTO)
        {
            UserProfileExternalService obj = new UserProfileExternalService(); 

            var model = new UserProfile()
            {
                FullName = userDTO.FullName,
                Phone = userDTO.Phone,
                UserRole = userDTO.UserRole,
                Login = userDTO.Login,
                Password = userDTO.Password,
                PicturePath = userDTO.PicturePath,
            };
        }

        public Task<bool> DeleteUserProfileAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserProfile>> GetAllUserProfileAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserProfile> GetByIdUserProfileAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UserProfile> UpdateUserProfileAsync(int id, UserProfileDTO userDTO)
        {
            throw new NotImplementedException();
        }
    }
}


