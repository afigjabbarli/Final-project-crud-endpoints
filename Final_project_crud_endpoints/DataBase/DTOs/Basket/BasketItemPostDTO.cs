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
        public Guid ColorID { get; set; }
        [Required]
        public Guid SizeID { get; set; }
        [Required]
        public Guid StoreID { get; set; }
        [Required]
        public Guid WarrantyID { get; set; }
    }

}
