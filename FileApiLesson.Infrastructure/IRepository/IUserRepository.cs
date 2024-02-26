namespace FileApiLesson.Infrastructure.IRepository
{
    public interface IUserRepository
    {
        Task<string> Update(int id);
    }
}
