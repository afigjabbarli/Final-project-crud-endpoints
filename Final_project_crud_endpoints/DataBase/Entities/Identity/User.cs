using Final_project_crud_endpoints.Contracts;
using Final_project_crud_endpoints.DataBase.Entities.Base;

namespace Final_project_crud_endpoints.DataBase.Entities.Identity
{
    public class User : BaseEntity<Guid>, IAuditable
    {
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool IsConfirmed { get; set; } = false;
        public bool IsBanned { get; set; } = false; 
        public Role.Values Role { get; set; } = Contracts.Role.Values.User;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Phisical_image_name { get; set; } = string.Empty;
        public DateTime ConfirmedDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public string User_Code { get; set; } = string.Empty;
        public string ApplicationPassword { get; set; } = string.Empty; 
        public ActivationToken ActivationToken { get; set; }
        public List<Email> Emails { get; set; }
        public List<BasketItem> BasketItems { get; set; }   
        public List<Order> Orders { get; set; } 
    }
}
