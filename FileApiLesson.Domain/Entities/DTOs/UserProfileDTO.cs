using FileApiLesson.Domain.Entities.Enums;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FileApiLesson.Domain.Entities.DTOs
{
    public class UserProfileDTO
    {
        public string FullName { get; set; }
        public Role UserRole { get; set; }
        public string Phone { get; set; }

        [NotMapped]
        public IFormFile Picture { get; set; }

        [MinLength(5), MaxLength(20)]
        public required string Login { get; set; }

        [MinLength(6)]
        public required string Password { get; set; }

        [JsonIgnore]
        public string PicturePath { get; set; }
    }
}
