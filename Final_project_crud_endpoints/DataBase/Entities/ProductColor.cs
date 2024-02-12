namespace Final_project_crud_endpoints.DataBase.Entities
{
    public class ProductColor
    {
        public Guid Product_Id { get; set; }        
        public Product Product { get; set; }   
        public Guid Color_Id { get; set; }  
        public Color Color { get; set; }
    }
}
