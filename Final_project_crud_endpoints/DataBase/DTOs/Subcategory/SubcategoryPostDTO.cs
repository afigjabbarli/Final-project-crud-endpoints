using System.ComponentModel.DataAnnotations;

namespace Final_project_crud_endpoints.DataBase.DTOs.Subcategory
{
    public class SubcategoryPostDTO
    {
        [Required(ErrorMessage = "Name is required!")]
        [Display(Name = "Name")]
        [StringLength(60, MinimumLength = 10, ErrorMessage = "Name must be between 10 and 60 characters!")]
        [RegularExpression(pattern: @"^[a-zA-Z0-9\s,]*$", ErrorMessage = "Only alphanumeric characters, spaces, and commas are allowed!")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Description is required!")]
        [Display(Name = "Description")]
        [StringLength(360, MinimumLength = 60, ErrorMessage = "Description must be between 60 and 600 characters!")]
        [RegularExpression(pattern: @"^[a-zA-Z0-9\s.,-]*$", ErrorMessage = "Only textual characters, upper or lowercase letters, numbers and special characters are allowed!")]
        public string Description { get; set; } = string.Empty;
        [Display(Name = "Image")]
        [Required(ErrorMessage = "Pick an Image!")]
        [FileSize(5, ErrorMessage = "The file size must be less than 5 MB!")]
        public IFormFile File { get; set; }
        [Display(Name = "Current_Category_Id")]
        [Required(ErrorMessage = "Current_Category_Id is required!")]
        [RegularExpression(@"^(?:\{{0,1}(?:[0-9a-fA-F]){8}-(?:[0-9a-fA-F]){4}-(?:[0-9a-fA-F]){4}-(?:[0-9a-fA-F]){4}-(?:[0-9a-fA-F]){12}\}{0,1})$",
         ErrorMessage = "The field must be a valid GUID.")]
        [FixedLength(36, ErrorMessage = "The field must be exactly 36 characters long!")]
        public Guid Current_Category_Id { get; set; }
    }
}
