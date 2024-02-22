namespace Final_project_crud_endpoints.CustomExceptions
{
    public class BasketNotImplementedException : Exception
    {
        public BasketNotImplementedException()
            : base("Your basket is currently empty! Please add items to your basket before proceeding to checkout...")
        {
        }

        public BasketNotImplementedException(string message)
            : base(message)
        {
        }

        public BasketNotImplementedException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
