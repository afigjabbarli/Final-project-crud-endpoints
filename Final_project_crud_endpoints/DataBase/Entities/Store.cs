using Final_project_crud_endpoints.DataBase.Entities.Base;

namespace Final_project_crud_endpoints.DataBase.Entities
{
    public class Store : BaseEntity<Guid>, IAuditable
    {
        public string Name { get; set; } = string.Empty;    
        public string Address { get; set; } = string.Empty;
        public string Phone_Number { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Phisical_image_name { get; set; } = string.Empty;
        public string Store_Code { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
    }
}
