using FileApiLesson.Domain.Entities.DTOs;
using FileApiLesson.Domain.Entities.Models;
using FileApiLesson.Infrastructure.IRepository;
using FileApiLesson.Infrastructure.Persistance;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace FileApiLesson.Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> CreateUserProfileAsync(UserProfile user)
        {
            _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return "Successful was created ✅";
        }

        public async Task<bool> DeleteUserProfileAsync(int id)
        {
            var a = _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            if (id != null)
            {
                _context.Remove(a.Result);
                await _context.SaveChangesAsync();
                File.Delete(a.Result.PicturePath);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<UserProfile>> GetAllUserProfileAsync()
        {
            var a = _context.Users.ToListAsync();
            return a.Result;
        }

        public Task<UserProfile> GetByIdUserProfileAsync(int id)
        {
            var user = _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            return user;
        }


        public async Task<UserProfile> UpdateUserProfileAsync(int id, UserProfileDTO userDTO)
        {
            var res = _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            if (res != null)
            {
                res.Result.FullName = userDTO.FullName;
                res.Result.Phone = userDTO.Phone;
                res.Result.UserRole = userDTO.UserRole;
                res.Result.Login = userDTO.Login;
                res.Result.Password = userDTO.Password;

                await _context.SaveChangesAsync();
                return res.Result;
            }
            return null;
        }

        public async Task<string> UpdateByPictureUserProfileAsync(int id, string picturePath)
        {
            var res = _context.Users.FirstOrDefaultAsync(x=>x.Id == id);
            var OldPicturePath = res.Result.PicturePath;
            if (id!= null)
            {
                res.Result.PicturePath = picturePath;
                await _context.SaveChangesAsync();
                File.Delete(OldPicturePath);

                return "O'zgartirlidikuuu😎";
            }
            return null;

        }
    }

}




