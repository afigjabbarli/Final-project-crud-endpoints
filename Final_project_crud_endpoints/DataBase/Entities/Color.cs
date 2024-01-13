using Final_project_crud_endpoints.DataBase.Base;

namespace Final_project_crud_endpoints.DataBase.Entities
{
    public class Color : BaseEntity<Guid>, IAuditable
    {

        public string Name { get; set; } = string.Empty;
        public string Color_Code { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }

    }
}
