namespace Final_project_crud_endpoints.DataBase.Entities
{
    public class ProductWarranty
    {
        public Guid Product_Id { get; set; }    
        public Product Product { get; set; }
        public Guid Warranty_Id { get; set; }   
        public Warranty Warranty { get; set; }
    }
}
