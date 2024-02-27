using FileApiLesson.Domain.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace FileApiLesson.Domain.Entities.DTOs
{
    public class UserProfileDTO
    {
        public string FullName { get; set; }
        public Role UserRole { get; set; }
        public string Phone { get; set; }

        [MinLength(5), MaxLength(20)]
        public required string Login { get; set; }

        [MinLength(6)]
        public required string Password { get; set; }

    }
}
