namespace SampleMVCApplication.Custom
{
    using System.ComponentModel.DataAnnotations;
    public class CodeValidatorcs : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            string code = value as string;
            if (code != null && !code.StartsWith("P", StringComparison.OrdinalIgnoreCase))
            {
                return new ValidationResult(ErrorMessage);
            }
            return ValidationResult.Success;
        }

    }
}
