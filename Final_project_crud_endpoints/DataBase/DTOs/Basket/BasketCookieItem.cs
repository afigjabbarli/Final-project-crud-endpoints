using System.ComponentModel.DataAnnotations.Schema;

namespace Final_project_crud_endpoints.DataBase.DTOs.Basket
{
    [NotMapped]
    public class BasketCookieItem
    {
        public Guid Current_User_Id { get; set; }   
        public Guid ProductID { get; set; }
        public string Product_Name { get; set; } = string.Empty;
        public string[] Phisical_image_names { get; set; } = new string[] {};
        public string Product_Code { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public byte Quantity { get; set; }   
        public bool IsAviable { get; set; } 
        public Guid ColorID { get; set; }
        public Guid SizeID { get; set; }
        public Guid StoreID { get; set; }
        public Guid WarrantyID { get; set; }
    }
}
