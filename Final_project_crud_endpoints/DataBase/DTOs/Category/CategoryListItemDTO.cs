namespace Final_project_crud_endpoints.DataBase.DTOs.Category
{
    public class CategoryListItemDTO
    {
        public Guid Id { get; set; }    
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Phisical_image_name { get; set; } = string.Empty;
        public string Category_Code { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
    }
}
      
