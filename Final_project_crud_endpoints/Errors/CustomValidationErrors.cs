namespace Final_project_crud_endpoints.Errors
{
    public static class CustomValidationErrors
    {
        public enum Key
        {
            Email = 0,
            Username = 1,
            PhoneNumber = 2,
            BasketItemPost = 3
        }

        public static class  Value
        {
            public const string EMAIL_EXIST_ERROR = "Dear user, the email address you have included is already exist in our database!";
            public const string USERNAME_EXIST_ERROR = "Dear user, the username you have included is already exist in our database!";
            public const string PHONENUMBER_EXIST_ERROR = "Dear user, the phone number you have included is already exist in our database!";
            public const string BASKET_ITEM_NULL_POSTED = "Oops! An error occurred while adding the item to your cart. Please try again later or contact customer support for assistance.";
        }
    }
}
