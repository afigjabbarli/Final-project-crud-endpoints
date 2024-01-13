using Final_project_crud_endpoints.DataBase.Base;
using System.ComponentModel.DataAnnotations;

namespace Final_project_crud_endpoints.DataBase.Entities
{
    public class Product: BaseEntity<Guid>, IAuditable
    {
        
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }    
        public string ManufacturedIn { get; set; } = string.Empty;  
        public string TrackingCode { get; set; } = string.Empty;
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

        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
    }
}
