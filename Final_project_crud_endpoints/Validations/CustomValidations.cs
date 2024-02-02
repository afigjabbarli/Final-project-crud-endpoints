using System.Text.RegularExpressions;

namespace Final_project_crud_endpoints.Validations
{
    public class CustomValidations
    {
        public static bool IsValidQueryString(string query)
        {
            if (!string.IsNullOrWhiteSpace(query))
            {
                return Regex.IsMatch(query, "^[a-zA-Z]+$");
            };
            return false;
        }
    }
}
