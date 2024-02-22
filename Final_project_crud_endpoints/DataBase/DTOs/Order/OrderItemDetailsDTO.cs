namespace Final_project_crud_endpoints.DataBase.DTOs.Order
{
    public class OrderItemDetailsDTO
    {
        public string Product_Code { get; set; } = string.Empty;
        public string Product_Name { get; set;} = string.Empty; 
        public string Brand_Name { get; set; } = string.Empty;
        public string Category_Name { get; set; } = string.Empty;
        public decimal Order_Item_Total_Price { get; set; }
        public decimal Order_Item_Single_Price { get; set; }
        public byte Quantity { get; set; }
        public string Phisical_Image_URL { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }
}
