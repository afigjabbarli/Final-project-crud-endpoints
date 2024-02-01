using System.ComponentModel.DataAnnotations;

namespace Final_project_crud_endpoints.DataBase.DTOs.Category
{
    public class CategoryPostDTO
    {
        [Required(ErrorMessage = "Name is required!")]
        [StringLength(60, MinimumLength = 10, ErrorMessage = "Name must be between 10 and 60 characters!")]
        [RegularExpression(pattern: @"^[a-zA-Z0-9\s,]*$", ErrorMessage = "Only alphanumeric characters, spaces, and commas are allowed!")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Description is required!")]
        [StringLength(360, MinimumLength = 60, ErrorMessage = "Description must be between 60 and 600 characters!")]
        [RegularExpression(pattern:@"^[a-zA-Z0-9\s.,-]*$", ErrorMessage = "Only textual characters, upper or lowercase letters, numbers and special characters are allowed!")]
        public string Description { get; set; } = string.Empty;
        [Display(Name = "Image")]
        [Required(ErrorMessage = "Pick an Image!")]
        [FileSize(5, ErrorMessage = "The file size must be less than 5 MB!")]
        public IFormFile File { get; set; }
    }
}
      
     

