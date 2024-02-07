using System.ComponentModel.DataAnnotations;

namespace Final_project_crud_endpoints.DataBase.DTOs.User
{
    public class UserLoginDTO
    {
        [StringLength(50, MinimumLength = 10, ErrorMessage = "Username must be between 10 and 50 characters!")]
        [RegularExpression(pattern: @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@])[a-zA-Z\d@]+$", ErrorMessage = "The username must contain at least one lowercase letter, one uppercase letter, one digit, and one @ symbol!!!")]
        public string? Username { get; set; } = string.Empty;
        [EmailAddress(ErrorMessage = "Invalid email format! Please enter a valid email address...")]
        [RegularExpression(pattern: @"^[a-zA-Z0-9._%+-]{1,64}@[a-zA-Z0-9.-]{1,255}\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email format! Please enter a valid email address...")]
        public string? Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "Password field cannot be left blank! Please fill in the relevant field...")]
        [StringLength(16, MinimumLength = 10, ErrorMessage = "Password length must be minimum 10 characters and maximum 16 characters!")]
        [RegularExpression(pattern: @"^[a-zA-Z0-9]+$", ErrorMessage = "The entered password must consist of only uppercase, lowercase letters and numbers!")]
        public string Password { get; set; } = string.Empty;
    }
}
