using System.ComponentModel.DataAnnotations;

namespace Final_project_crud_endpoints.Validations
{
    public class ValidateSinceAttribute : ValidationAttribute
    {
        private readonly DateTime _since;

        public ValidateSinceAttribute(string since)
        {
            _since = DateTime.Parse(since);
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is DateTime && (DateTime)value < _since)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("The creation date must be less than the current time...");
        }
    }
}
