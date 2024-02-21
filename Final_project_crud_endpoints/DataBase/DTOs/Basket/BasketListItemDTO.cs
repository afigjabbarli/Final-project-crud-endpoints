using System.ComponentModel.DataAnnotations;

namespace Final_project_crud_endpoints.DataBase.DTOs.Basket
{
    public class BasketListItemDTO
    {
        public string Product_Name { get; set; } = string.Empty;
        public string[] Phisical_image_URLs { get; set; } = new string[] {};
        public decimal Price { get; set; }
        public bool Is_Aviable { get; set; } 
        public byte Quantity { get; set; }
        public Guid Product_ID { get; set; }
        public Guid[] Color_IDs { get; set; }
        public Guid[] Size_IDs { get; set; }
        public Guid[] Warranty_IDs { get; set; }
        public Guid[] Store_IDs { get; set; }
    }
}
