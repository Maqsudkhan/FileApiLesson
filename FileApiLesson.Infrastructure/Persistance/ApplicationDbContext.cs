using FileApiLesson.Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace FileApiLesson.Infrastructure.Persistance
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<UserProfile> Users { get; set; }
    }
}
