using FileApiLesson.Domain.Entities.DTOs;
using FileApiLesson.Domain.Entities.Models;
using FileApiLesson.Infrastructure.Persistance;

namespace FileApiLesson.Application.Services.UserProfileServices
{
    public class UserProfileService : IUserProfileService
    {
        private readonly ApplicationDbContext _context;

        public UserProfileService(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<UserProfileDTO> CreateUserProfileAsync(UserProfileDTO userDTO)
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
                PicturePath = userDTO.Path
            };

            _context.Users.Add(model);
            await _context.SaveChangesAsync();

            return userDTO;
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


