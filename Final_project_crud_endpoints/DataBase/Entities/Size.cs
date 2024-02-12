using Final_project_crud_endpoints.DataBase.Entities.Base;

namespace Final_project_crud_endpoints.DataBase.Entities
{
    public class Size : BaseEntity<Guid>
    {
        public string Name { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public List<ProductSize> ProductSizes { get; set; } 
    }
}
