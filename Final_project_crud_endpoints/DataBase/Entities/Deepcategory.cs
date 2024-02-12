using Final_project_crud_endpoints.DataBase.Entities.Base;

namespace Final_project_crud_endpoints.DataBase.Entities
{
    public class Deepcategory : BaseEntity<Guid>, IAuditable
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Deepcategory_Code { get; set; } = string.Empty;
        public string Phisical_image_name { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public Guid Current_Subcategory_Id { get; set; }
        public Subcategory Subcategory { get; set; }    
        public List<Product> Products { get; set; } 
    }
}
