using Final_project_crud_endpoints.Contracts;
using Final_project_crud_endpoints.DataBase.Entities.Identity;

namespace Final_project_crud_endpoints.DataBase.DTOs.User
{
    public class UserDetailsDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool IsConfirmed { get; set; } = false;
        public string PhoneNumber { get; set; } = string.Empty;
        public string PhisicalImageURL { get; set; } = string.Empty;
        public DateTime ConfirmedDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public string ApplicationPassword { get; set; } = string.Empty;
    }
}
