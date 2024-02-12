using Final_project_crud_endpoints.DataBase.Entities.Base;

namespace Final_project_crud_endpoints.DataBase.Entities
{
    public class Brand : BaseEntity<Guid>, IAuditable
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Phisical_Logo_Name { get; set; } = string.Empty;
        public string Brand_Code { get; set; } = string.Empty;  
        public DateTime Since { get; set; }
        public string Location { get; set; } = string.Empty;    
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public List<Product> Products { get; set; } 
    }
}
