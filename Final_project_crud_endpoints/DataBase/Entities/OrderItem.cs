using Final_project_crud_endpoints.DataBase.Entities.Base;

namespace Final_project_crud_endpoints.DataBase.Entities
{
    public class OrderItem : BaseEntity<Guid>, IAuditable
    {
        public Guid Order_ID { get; set; }
        public Order Order { get; set; }
        public Guid Product_ID { get; set; }
        public Guid Product_Size_ID { get; set; }
        public Guid Product_Color_ID { get; set; }
        public Guid Product_Warranty_ID { get; set; }
        public Guid Product_Store_ID { get; set; }  
        public byte Quantity { get; set; }  
        public decimal Order_Item_Total_Price { get; set; }
        public decimal Order_Item_Single_Price { get; set; }
        public string Product_Code { get; set; } = string.Empty;
        public string Phisical_Image_Name { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
    }
}
