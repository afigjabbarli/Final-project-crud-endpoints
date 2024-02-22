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
        public Guid ColorID { get; set; }
        public Guid SizeID { get; set; }
        public Guid StoreID { get; set; }
        public Guid WarrantyID { get; set; }
    }
}
