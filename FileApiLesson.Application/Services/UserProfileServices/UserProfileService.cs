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

            await _context.Users.AddAsync(model);
            await _context.SaveChangesAsync();

            return "Successful was created ✅";
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


