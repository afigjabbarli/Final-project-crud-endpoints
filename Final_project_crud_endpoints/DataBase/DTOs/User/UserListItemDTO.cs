namespace Final_project_crud_endpoints.DataBase.DTOs.User
{
    public class UserListItemDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string PhisicalImageURL { get; set; } = string.Empty;
        public bool IsBanned { get; set; } = false;
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
    }
}
