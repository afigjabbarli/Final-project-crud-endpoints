using System.ComponentModel.DataAnnotations;

public class FileSizeAttribute : ValidationAttribute
{
    private readonly int _maxFileSizeInMegabytes;

    public FileSizeAttribute(int maxFileSizeInMegabytes)
    {
        _maxFileSizeInMegabytes = maxFileSizeInMegabytes;
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value is IFormFile file)
        {
            if (file.Length > _maxFileSizeInMegabytes * 1024 * 1024)
            {
                return new ValidationResult($"The file size must be less than {_maxFileSizeInMegabytes} MB.");
            }

            return ValidationResult.Success;
        }

        return new ValidationResult("Please enter a valid file type!");
    }
}

