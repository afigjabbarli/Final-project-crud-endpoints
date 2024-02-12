using Final_project_crud_endpoints.Validations;
using System.ComponentModel.DataAnnotations;

namespace Final_project_crud_endpoints.DataBase.DTOs.Brand
{
    public class BrandPostDTO
    {
        [Display(Name = "Name")]    
        [Required(ErrorMessage = "Name field cannot be empty! Please fill in the relevant field...")]
        [StringLength(24, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 24 characters!")]
        [RegularExpression(pattern: @"^[a-zA-Z]+$", ErrorMessage = "The entered name must consist of only uppercase and lowercase letters!")]
        public string Name { get; set; } = string.Empty;
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description field cannot be empty! Please fill in the relevant field...")]
        [StringLength(360, MinimumLength = 60, ErrorMessage = "Description must be between 60 and 600 characters!")]
        [RegularExpression(pattern: @"^[a-zA-Z0-9\s.,-]*$", ErrorMessage = "Only textual characters, upper or lowercase letters, numbers and special characters are allowed!")]
        public string Description { get; set; } = string.Empty;
        [Display(Name = "Image")]
        [Required(ErrorMessage = "Pick an Image!")]
        [FileSize(5, ErrorMessage = "The file size must be less than 5 MB!")]
        public IFormFile File { get; set; }
        [Display(Name = "Since")]
        [Required(ErrorMessage = "Since field cannot be empty! Please fill in the relevant field...")]
        [Range(typeof(DateTime), "1900-02-12 12:00:00", "2024-02-12 12:00:00", ErrorMessage = "Since field must be between <<1900-02-12 12:00:00>> and <<2024-02-12 12:00:00>>!")]
        [DataType(DataType.DateTime, ErrorMessage = "Enter a valid date time format!")]
        [ValidateSince("2024-02-12 12:00:00")]
        public DateTime Since { get; set; }
        [Display(Name = "Location")]
        [Required(ErrorMessage = "Location field cannot be empty! Please fill in the relevant field...")]
        [StringLength(125, MinimumLength = 25, ErrorMessage = "Location must be between 25 and 125 characters!")]
        [RegularExpression(pattern: @"^[a-zA-Z0-9\s.,-]*$", ErrorMessage = "Only textual characters, upper or lowercase letters, numbers and special characters are allowed!")]
        public string Location { get; set; } = string.Empty;
    }
}
