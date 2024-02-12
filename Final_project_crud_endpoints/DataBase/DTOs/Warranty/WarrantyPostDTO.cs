using System.ComponentModel.DataAnnotations;

namespace Final_project_crud_endpoints.DataBase.DTOs.Warranty
{
    public class WarrantyPostDTO
    {
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name field cannot be empty! Please fill in the relevant field...")]
        public string Name { get; set; } = string.Empty;
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description field cannot be empty! Please fill in the relevant field...")]
        public string Description { get; set; } = string.Empty;
        [Display(Name = "Expire year")]
        [Required(ErrorMessage = "Expire year field cannot be empty! Please fill in the relevant field...")]
        public int ExpireYear { get; set; }
    }
}
