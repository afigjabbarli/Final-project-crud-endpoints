using Final_project_crud_endpoints.DataBase.Entities.Base;

namespace Final_project_crud_endpoints.DataBase.Entities
{
    public class QualityLevel : BaseEntity<Guid>
    {
        public string Level { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public List<Product> Products { get; set; } 
    }
}
