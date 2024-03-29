﻿using Final_project_crud_endpoints.DataBase.Entities.Base;

namespace Final_project_crud_endpoints.DataBase.Entities
{
    public class Warranty : BaseEntity<Guid>, IAuditable
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int ExpireYear { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public List<ProductWarranty> ProductWarranties { get; set; }
    }
}
