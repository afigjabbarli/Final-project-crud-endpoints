using Final_project_crud_endpoints.DataBase.Entities.Base;

namespace Final_project_crud_endpoints.DataBase.Entities
{
    public class RandomPassword : BaseEntity<Guid>
    {
        public string Password { get; set; } = string.Empty;
        
    }
}
