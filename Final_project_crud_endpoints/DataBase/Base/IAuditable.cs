namespace Final_project_crud_endpoints.DataBase.Base
{
    public interface IAuditable
    {
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
    }
}
