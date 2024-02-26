using FileApiLesson.Application.Services.UserProfileServices;
using Microsoft.Extensions.DependencyInjection;

namespace FileApiLesson.Application
{
    public static class ApplicationDependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IUserProfileService, UserProfileService>();
            return services;
        }
    }
}
