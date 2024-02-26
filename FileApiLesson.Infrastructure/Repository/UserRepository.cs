using FileApiLesson.Infrastructure.IRepository;

namespace FileApiLesson.Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        public Task<string> Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
