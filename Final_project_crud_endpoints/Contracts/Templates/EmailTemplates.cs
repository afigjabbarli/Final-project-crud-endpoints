namespace Final_project_crud_endpoints.Contracts.Templates
{
    public static class EmailTemplates
    {
        public static class Body
        {
            public const string Success_Activation_Email = "Dear user {Name} {Surname}, your account has been successfully activated. Your app password: [{app_password}]. You can enter the application and take advantage of discounts and benefits :)";
            public const string Already_Exist_Account = "Dear user, your account has already been confirmed and exists in our database";
            public const string Expired_Token = "Your activation token has expired";
        }

        public static class Subject
        {
            public const string Activation_Email = "Activation Email";
            public const string Expired_Token = "Expired Token";
            public const string Success_Activation = "Successful activation";
            public const string Order_Invoice = "Walmart E - Commerce Order Invoice";
        }
    }
}
