using Final_project_crud_endpoints.DataBase.Entities.Base;
using Final_project_crud_endpoints.DataBase.Entities.Identity;

namespace Final_project_crud_endpoints.DataBase.Entities
{
    public class BasketItem : BaseEntity<Guid>, IAuditable
    {
        public Guid Product_ID { get; set; }
        public Guid ColorID { get; set; }
        public Guid SizeID { get; set; }
        public Guid StoreID { get; set; }
        public Guid WarrantyID { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public byte Quantity { get; set; }  
        public bool IsAviable { get; set; }
        public string Product_Name { get; set; } = string.Empty;
        public string Product_Code { get; set; } = string.Empty;
        public string[] Phisical_image_names { get; set; } = new string[] { };
        public decimal Price { get; set; }
        public User User { get; set; }
        public Guid Current_User_ID { get; set; }   
    }
}
