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
            throw new NotImplementedException();
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


