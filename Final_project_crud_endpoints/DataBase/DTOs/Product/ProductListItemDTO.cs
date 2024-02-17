using Final_project_crud_endpoints.DataBase.Entities;
using entities_exist_path = Final_project_crud_endpoints.DataBase.Entities;

namespace Final_project_crud_endpoints.DataBase.DTOs.Product
{
    public class ProductListItemDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Product_Code { get; set; } = string.Empty;
        public decimal Quantity { get; set; }
        public bool IsAvailable { get; set; }
        public int Discount { get; set; }
        public bool IsOffer { get; set; }
        public DateTime ManufacturedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public List<string> Phisical_image_URLs { get; set; } = new List<string>();
        public Entities.Deepcategory Current_Deepcategory { get; set; }
        public Entities.Brand Current_Brand { get; set; }
        public Entities.QualityLevel Current_QualityLevel { get; set; } 
        public List<Color> Colors { get; set; } 
        public List<Size> Sizes { get; set; }   
        public List<entities_exist_path.Warranty> Warranties { get; set; }    
        public List<entities_exist_path.Store> Stores { get; set; } 
    }
}
