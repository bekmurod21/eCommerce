using eCommerce.Domain.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace eCommerce.Service.DTOs.Users
{
    public class UserCreationDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [MinLength(8)]
        public string Password { get; set; }
        public UserRole Role { get; set; } = UserRole.User;
    }
}
