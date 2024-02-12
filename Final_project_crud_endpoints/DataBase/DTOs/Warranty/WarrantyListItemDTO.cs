namespace Final_project_crud_endpoints.DataBase.DTOs.Warranty
{
    public class WarrantyListItemDTO
    {
        public Guid Id { get; set; }    
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int ExpireYear { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
    }
}
