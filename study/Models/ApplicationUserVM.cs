using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Study.Models
{
    public class ApplicationUserVM
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [DataType(DataType.Text)]
        [StringLength(30, MinimumLength = 3)]
        public string FirstName { get; set; }
        [DataType(DataType.Text)]
        [StringLength(30, MinimumLength = 3)]
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }

        [Required]
        [StringLength(18, ErrorMessage = "Password must be at least 8 characters long.", MinimumLength = 8)]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$", ErrorMessage = "Password must at least one uppercase letter, one lowercase letter, one number")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        //must be 11 digits
        [Required(ErrorMessage = "You must provide a phone number")]
        [RegularExpression(@"^(\d{11})$", ErrorMessage = "Invalid phone number")]
        public string Phone { get; set; }

        [Required]
        //[StringLength(128)]
        [EmailAddress]
        public string Email { get; set; }

        public List<string> RoleNames { get; set; }
        public string RoleName { get; set; }
        public List<IdentityRole> Roles { get; set; }

        public Gender MyGender { get; set; }

        public enum Gender
        {
            Male,
            Female,
            Other,
            PreferNotToSay
        }
    }
}
