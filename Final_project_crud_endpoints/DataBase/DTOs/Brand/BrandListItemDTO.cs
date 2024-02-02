namespace Final_project_crud_endpoints.DataBase.DTOs.Brand
{
    public class BrandListItemDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Phisical_Logo_URL { get; set; } = string.Empty;
        public string Brand_Code { get; set; } = string.Empty;
        public DateTime Since { get; set; }
        public string Location { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
    }
}
