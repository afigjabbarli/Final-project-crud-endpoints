namespace Final_project_crud_endpoints.DataBase.DTOs.Brand
{
    public class BrandPostDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public IFormFile File { get; set; }
        public DateTime Since { get; set; }
        public string Location { get; set; } = string.Empty;
    }
}
