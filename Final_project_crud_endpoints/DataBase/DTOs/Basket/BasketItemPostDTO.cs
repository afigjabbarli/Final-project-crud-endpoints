using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final_project_crud_endpoints.DataBase.DTOs.Basket
{
    [NotMapped]
    public class BasketItemPostDTO
    {
        [Required]
        public Guid Product_ID { get; set; }
        [Required]
        public byte Quantity { get; set; }
        [Required]  
        public Guid[] Color_IDs { get; set; }
        [Required]
        public Guid[] Size_IDs { get; set; }
        [Required]  
        public Guid[] Warranty_IDs { get; set; }
        [Required]
        public Guid[] Store_IDs { get; set; }
    }

}
