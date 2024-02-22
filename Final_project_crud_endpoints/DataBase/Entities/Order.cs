using Final_project_crud_endpoints.DataBase.Entities.Base;
using Final_project_crud_endpoints.DataBase.Entities.Identity;

namespace Final_project_crud_endpoints.DataBase.Entities
{
    public class Order : BaseEntity<Guid>, IAuditable
    { 
        public User User { get; set; }  
        public Guid User_ID { get; set; }
        public string Current_Order_Status { get; set; } = string.Empty;
        public string Tracking_ID { get; set; } = string.Empty;
        public decimal Order_Total_Price { get; set; }  
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public List<OrderItem> OrderItems { get; set; } 
    }
}
