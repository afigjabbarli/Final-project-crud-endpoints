namespace Final_project_crud_endpoints.CustomExceptions
{
    public class BasketResourceNotFoundException : Exception
    {
        public BasketResourceNotFoundException()
        {
        }

        public BasketResourceNotFoundException(string message)
            : base(message)
        {
        }

        public BasketResourceNotFoundException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
