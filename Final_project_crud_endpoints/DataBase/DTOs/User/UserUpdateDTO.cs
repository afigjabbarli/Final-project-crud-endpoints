using System.ComponentModel.DataAnnotations;

namespace Final_project_crud_endpoints.DataBase.DTOs.User
{
    public class UserUpdateDTO
    {
        [Required(ErrorMessage = "Name field cannot be left blank! Please fill in the relevant field...")]
        [StringLength(24, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 24 characters!")]
        [RegularExpression(pattern: @"^[a-zA-Z]+$", ErrorMessage = "The entered name must consist of only uppercase and lowercase letters!")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Surname field cannot be left blank! Please fill in the relevant field...")]
        [StringLength(40, MinimumLength = 5, ErrorMessage = "Surname must be between 5 and 40 characters!")]
        [RegularExpression(pattern: @"^[a-zA-Z]+$", ErrorMessage = "The entered surname must consist of only uppercase and lowercase letters!")]
        public string Surname { get; set; } = string.Empty;
        [Required(ErrorMessage = "Phone number field cannot be left blank! Please fill in the relevant field...")]
        [RegularExpression(@"^\+[1-9]\d{1,14}$", ErrorMessage = "Invalid phone number format! Please enter a valid phone number...")]
        [StringLength(20, ErrorMessage = "Phone number must be at most 20 characters long!")]
        [Phone(ErrorMessage = "Invalid phone number format! Please enter a valid phone number...")]
        public string PhoneNumber { get; set; } = string.Empty;
        [Display(Name = "Image")]
        [FileSize(5, ErrorMessage = "The file size must be less than 5 MB!")]
        public IFormFile? File { get; set; }
    }
}
