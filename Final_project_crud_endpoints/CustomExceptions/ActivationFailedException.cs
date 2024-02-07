namespace Final_project_crud_endpoints.CustomExceptions
{
    public class ActivationFailedException : Exception
    {
        public ActivationFailedException() : base("An attempt to activate the account failed! Please try again or contact an authorized person...") { }

        public ActivationFailedException(string message) : base(message) { }

        public ActivationFailedException(string message, Exception innerException) : base(message, innerException) { }
    }
}
