namespace Final_project_crud_endpoints.DataBase.DTOs.Store
{
    public class StoreListItemDTO
    {
        public Guid Id { get; set; }    
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Phone_Number { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Phisical_image_URL { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
    }
}
