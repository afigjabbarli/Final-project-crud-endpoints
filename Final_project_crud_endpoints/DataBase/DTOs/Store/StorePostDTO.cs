using System.ComponentModel.DataAnnotations;

namespace Final_project_crud_endpoints.DataBase.DTOs.Store
{
    public class StorePostDTO
    {
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name field cannot be empty! Please fill in the relevant field...")]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "Name must be between 6 and 30 characters!")]
        [RegularExpression(pattern: @"^[a-zA-Z]+$", ErrorMessage = "The entered name must consist of only uppercase and lowercase letters!")]
        public string Name { get; set; } = string.Empty;
        [Display(Name= "Address")]
        [Required(ErrorMessage = "Address field cannot be empty! Please fill in the relevant field...")]
        [StringLength(100, MinimumLength = 25, ErrorMessage = "Address must be between 25 and 100 characters!")]
        public string Address { get; set; } = string.Empty;
        [Display(Name = "Phone number")]
        [Required(ErrorMessage = "Phone number field cannot be empty! Please fill in the relevant field...")]
        [Phone(ErrorMessage = "Please enter a valid phone number!")]
        public string Phone_Number { get; set; } = string.Empty;
        [Display(Name = "State")]
        [Required(ErrorMessage = "State field cannot be empty! Please fill in the relevant field...")]
        [StringLength(60, MinimumLength = 10, ErrorMessage = "State must be between 10 and 60 characters!")]
        public string State { get; set; } = string.Empty;
        [Display(Name = "Image")]
        [Required(ErrorMessage = "Pick an Image!")]
        [FileSize(5, ErrorMessage = "The file size must be less than 5 MB!")]
        public IFormFile File { get; set; }
    }
}
