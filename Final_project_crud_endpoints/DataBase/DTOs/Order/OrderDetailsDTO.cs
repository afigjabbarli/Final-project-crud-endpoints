namespace Final_project_crud_endpoints.DataBase.DTOs.Order
{
    public class OrderDetailsDTO
    {
        public Guid Order_ID { get; set; } 
        public DateTime Order_Created_At { get; set; }  
        public string Order_Tracking_Code { get; set; } = string.Empty; 
        public string Current_Order_Status { get; set; } = string.Empty;
        public string Current_User_Surname { get; set; } = string.Empty;
        public string Current_User_Name { get; set; } = string.Empty;
        public string Current_User_Email { get; set; } = string.Empty;
        public string Current_User_Phone_Number { get; set; } = string.Empty;
        public decimal Summary_Total { get; set; }  
        public List<OrderItemDetailsDTO> Order_Item_Details_DTOs { get; set; } = new List<OrderItemDetailsDTO>(); 
    }
}
