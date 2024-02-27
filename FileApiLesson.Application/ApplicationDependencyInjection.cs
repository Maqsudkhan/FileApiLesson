using FileApiLesson.Application.Services.UserProfileServices;
using FileApiLesson.Infrastructure.IRepository;
using FileApiLesson.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace FileApiLesson.Application
{
    public static class ApplicationDependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IUserProfileService, UserProfileService>();
            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }
    }
}
