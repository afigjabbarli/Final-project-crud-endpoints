using System.ComponentModel.DataAnnotations;

namespace Final_project_crud_endpoints.Validations
{
    public class MaxFileSizeAttribute : ValidationAttribute
    {
        private readonly int _maxFileSize;

        public MaxFileSizeAttribute(int maxFileSize)
        {
            _maxFileSize = maxFileSize;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
                return ValidationResult.Success;

            var files = value as IFormFileCollection;
            foreach (var file in files)
            {
                if (file.Length > _maxFileSize)
                {
                    return new ValidationResult($"File size cannot exceed {_maxFileSize / 1024 / 1024} MB.");
                }
            }

            return ValidationResult.Success;
        }
    }

}
