namespace Final_project_crud_endpoints.DataBase.Entities.Base
{
    public interface IAuditable
    {
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
    }
}
