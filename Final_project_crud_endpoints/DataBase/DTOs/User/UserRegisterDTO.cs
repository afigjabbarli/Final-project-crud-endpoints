using Final_project_crud_endpoints.Contracts;
using Final_project_crud_endpoints.DataBase.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Final_project_crud_endpoints.DataBase.DTOs.User
{
    public class UserRegisterDTO
    {
        [Required(ErrorMessage = "Name field cannot be left blank! Please fill in the relevant field...")]
        [StringLength(24, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 24 characters!")]
        [RegularExpression(pattern: @"^[a-zA-Z]+$", ErrorMessage = "The entered name must consist of only uppercase and lowercase letters!")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Surname field cannot be left blank! Please fill in the relevant field...")]
        [StringLength(40, MinimumLength = 5, ErrorMessage = "Surname must be between 5 and 40 characters!")]
        [RegularExpression(pattern: @"^[a-zA-Z]+$", ErrorMessage = "The entered surname must consist of only uppercase and lowercase letters!")]
        public string Surname { get; set; } = string.Empty;
        [Required(ErrorMessage = "Username field cannot be left blank! Please fill in the relevant field...")]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "Username must be between 10 and 50 characters!")]
        [RegularExpression(pattern: @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@])[a-zA-Z\d@]+$", ErrorMessage = "The username must contain at least one lowercase letter, one uppercase letter, one digit, and one @ symbol!!!")]
        public string Username { get; set; } = string.Empty;
        [Required(ErrorMessage = "Email field cannot be left blank! Please fill in the relevant field...")]
        [EmailAddress(ErrorMessage = "Invalid email format! Please enter a valid email address...")]
        [RegularExpression(pattern: @"^[a-zA-Z0-9._%+-]{1,64}@[a-zA-Z0-9.-]{1,255}\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email format! Please enter a valid email address...")]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "Password field cannot be left blank! Please fill in the relevant field...")]
        [StringLength(16, MinimumLength = 10, ErrorMessage = "Password length must be minimum 10 characters and maximum 16 characters!")]
        [RegularExpression(pattern: @"^[a-zA-Z0-9]+$", ErrorMessage = "The entered password must consist of only uppercase, lowercase letters and numbers!")]
        public string Password { get; set; } = string.Empty;
        [Required(ErrorMessage = "Confirm password field cannot be left blank! Please fill in the relevant field...")]
        [Compare("Password", ErrorMessage = "Password's doesn't match")]
        [StringLength(16, MinimumLength = 10, ErrorMessage = "Confirm password length must be minimum 10 characters and maximum 16 characters!")]
        [RegularExpression(pattern: @"^[a-zA-Z0-9]+$", ErrorMessage = "The entered confirm password must consist of only uppercase, lowercase letters and numbers!")]
        public string ConfirmPassword { get; set; } = string.Empty;
        [Required(ErrorMessage = "Phone number field cannot be left blank! Please fill in the relevant field...")]
        [RegularExpression(@"^\+[1-9]\d{1,14}$", ErrorMessage = "Invalid phone number format! Please enter a valid phone number...")]
        [StringLength(20, ErrorMessage = "Phone number must be at most 20 characters long!")]
        [Phone(ErrorMessage = "Invalid phone number format! Please enter a valid phone number...")]
        public string PhoneNumber { get; set; } = string.Empty;
        [Display(Name = "Image")]
        [Required(ErrorMessage = "Pick an Image!")]
        [FileSize(5, ErrorMessage = "The file size must be less than 5 MB!")]
        public IFormFile File { get; set; }
    }
}
