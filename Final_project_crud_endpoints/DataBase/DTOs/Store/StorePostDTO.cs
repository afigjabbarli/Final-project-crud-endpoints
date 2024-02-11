namespace Final_project_crud_endpoints.DataBase.DTOs.Store
{
    public class StorePostDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Phone_Number { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public IFormFile File { get; set; }
    }
}
