using FileApiLesson.Domain.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace FileApiLesson.Domain.Entities.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public Role UserRole { get; set; }
        public string Phone { get; set; }

        [MinLength(3), MaxLength(40)]
        public required string Login { get; set; }

        [MinLength(3)]
        public required string Password { get; set; }
        public string PicturePath { get; set; }

    }
}
