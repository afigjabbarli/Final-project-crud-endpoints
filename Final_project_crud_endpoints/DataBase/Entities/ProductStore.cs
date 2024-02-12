namespace Final_project_crud_endpoints.DataBase.Entities
{
    public class ProductStore
    {
        public Guid Product_Id { get; set; }        
        public Product Product { get; set; }    
        public Guid Store_Id { get; set; }  
        public Store Store { get; set; }    
    }
}
