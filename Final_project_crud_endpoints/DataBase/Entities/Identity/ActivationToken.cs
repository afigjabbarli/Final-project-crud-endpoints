using Final_project_crud_endpoints.DataBase.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final_project_crud_endpoints.DataBase.Entities.Identity
{
    public class ActivationToken : BaseEntity<Guid>, IAuditable
    {
        public string Unique_Activation_Token { get; set; } = string.Empty;
        public bool IsUsed { get; set; } = false;
        public DateTime ExpireDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        [ForeignKey("User")]
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
