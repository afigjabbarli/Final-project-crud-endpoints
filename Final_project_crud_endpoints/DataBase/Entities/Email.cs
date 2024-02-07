using Final_project_crud_endpoints.DataBase.Entities.Base;
using Final_project_crud_endpoints.DataBase.Entities.Identity;

namespace Final_project_crud_endpoints.DataBase.Entities
{
    public class Email : BaseEntity<Guid>, IAuditable
    {
        public List<string> Recipients { get; set; } = new List<string>();
        public string Subject { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; } 
        public Guid UserId { get; set; }    
        public User User { get; set; }  
    }
}
