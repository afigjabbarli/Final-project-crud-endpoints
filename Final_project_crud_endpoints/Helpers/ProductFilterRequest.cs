namespace Final_project_crud_endpoints.Helpers
{
    public class ProductFilterRequest
    {
        public Guid Current_Category_ID { get; set; }
        public Guid Current_Brand_ID { get; set; }  
        public decimal Minimum_Price { get; set; }
        public decimal Maximum_Price { get; set; }
        public Guid Current_Color_ID { get; set; }  
        public Guid Current_Size_ID { get; set; }   
        public Guid Current_Warranty_ID { get; set; }   
        public Guid Current_Store_ID { get; set; }  
        public Guid Current_Quality_Level_ID { get; set; }
        public bool Is_Available { get; set; }  
        public bool Is_Offer { get; set; }  
    }
}
