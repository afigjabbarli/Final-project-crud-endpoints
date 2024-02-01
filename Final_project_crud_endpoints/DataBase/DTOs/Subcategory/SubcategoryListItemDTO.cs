namespace Final_project_crud_endpoints.DataBase.DTOs.Subcategory
{
    public class SubcategoryListItemDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Phisical_image_name { get; set; } = string.Empty;
        public string Subcategory_Code { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public Guid Current_Category_Id { get; set; }
    }
}
