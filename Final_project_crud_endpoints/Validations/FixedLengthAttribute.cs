using System;
using System.ComponentModel.DataAnnotations;

public class FixedLengthAttribute : ValidationAttribute
{
    private readonly int _fixedLength;

    public FixedLengthAttribute(int fixedLength)
    {
        _fixedLength = fixedLength;
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value is Guid str && value.ToString().Length == _fixedLength)
        {
            return ValidationResult.Success;
        }

        return new ValidationResult($"The field must be exactly {_fixedLength} characters long.");
    }
}
