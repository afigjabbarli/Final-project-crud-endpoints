namespace Final_project_crud_endpoints.DataBase.Entities
{
    public class ProductSize
    {
        public Guid Product_Id { get; set; }    
        public Product Product { get; set; }
        public Guid Size_Id { get; set; }   
        public Size Size { get; set; }  
    }
}
