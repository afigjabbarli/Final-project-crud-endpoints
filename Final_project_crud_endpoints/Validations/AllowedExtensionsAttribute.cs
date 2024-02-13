using System.ComponentModel.DataAnnotations;

namespace Final_project_crud_endpoints.Validations
{
    public class AllowedExtensionsAttribute : ValidationAttribute
    {
        private readonly string[] _extensions;

        public AllowedExtensionsAttribute(string[] extensions)
        {
            _extensions = extensions;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
                return ValidationResult.Success;

            var files = value as IFormFileCollection;
            foreach (var file in files)
            {
                var extension = System.IO.Path.GetExtension(file.FileName);
                if (!_extensions.Contains(extension.ToLower()))
                {
                    return new ValidationResult($"Unsupported file extension: {extension}");
                }
            }

            return ValidationResult.Success;
        }
    }

}
