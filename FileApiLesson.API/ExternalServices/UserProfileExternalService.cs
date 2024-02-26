﻿namespace FileApiLesson.API.ExternalServices
{
    public class UserProfileExternalService
    {
        private readonly IWebHostEnvironment _env;

        public UserProfileExternalService(IWebHostEnvironment env)
        {
            _env = env;
        }
        public UserProfileExternalService()
        {

        }

        public async Task<string> AddPictureAndGetPath(IFormFile formFile)
        {
            string path  = Path.Combine(_env.WebRootPath, "images", Guid.NewGuid() + formFile.Name);
            using(var stream = File.Create(path))
            {
                await formFile.CopyToAsync(stream);
            }
            return path;
        } 
    }
}
