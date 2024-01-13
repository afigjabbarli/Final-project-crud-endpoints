using Final_project_crud_endpoints.DataBase.Base;

namespace Final_project_crud_endpoints.DataBase.Entities
{
    public class Category : BaseEntity<Guid>, IAuditable
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public List<Subcategory> Subcategories { get; set; }
    }
}
