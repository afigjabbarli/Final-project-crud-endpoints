using Final_project_crud_endpoints.DataBase.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final_project_crud_endpoints.DataBase.Entities
{
    public class Product : BaseEntity<Guid>, IAuditable
    {

        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        [NotMapped]
        public List<string> Phisical_image_names { get; set; } = new List<string>();
        public string Product_Code { get; set; } = string.Empty;
        private decimal _quantity;
        private bool _isAvailable = true;

        public decimal Quantity
        {
            get { return _quantity; }
            set
            {
                _quantity = value;

                _isAvailable = (_quantity > 0);
            }
        }

        public bool IsAvailable
        {
            get { return _isAvailable; }
            private set { }
        }

        private int _discount;
        private bool _offer = false;

        public int Discount
        {
            get { return _discount; }
            set { _discount = value; _offer = (_discount > 0); }
        }

        public bool IsOffer
        {
            get { return _offer; }
            private set { }
        }
        public DateTime ManufacturedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public QualityLevel QualityLevel { get; set; }
        public Guid Current_Quality_Level_Id { get; set; }
        public Deepcategory Deepcategory { get; set; }
        public Guid Current_Deepcategory_Id { get; set; }

        public Brand Brand { get; set; }
        public Guid Current_Brand_Id { get; set; }
        public List<ProductStore> ProductStores { get; set; }
        public List<ProductSize> ProductSizes { get; set; }
        public List<ProductColor> ProductColors { get; set; }
        public List<ProductWarranty> ProductWarranties { get; set; }
    }
}
