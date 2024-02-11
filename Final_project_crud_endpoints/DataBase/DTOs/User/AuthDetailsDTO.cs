using Final_project_crud_endpoints.Contracts;

namespace Final_project_crud_endpoints.DataBase.DTOs.User
{
    public class AuthDetailsDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public bool IsBanned { get; set; }
        public bool IsAuthenticated { get; set; }
        public string Role { get; set; } = string.Empty;
        public string ApplicationPassword { get; set; } = string.Empty;
        public string Phisical_image_URL { get; set; } = string.Empty;
    }
}
