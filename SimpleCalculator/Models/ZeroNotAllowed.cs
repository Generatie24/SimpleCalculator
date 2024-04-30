using System.ComponentModel.DataAnnotations;

namespace SimpleCalculator.Models
{
    public class ZeroNotAllowed : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if ((decimal)value == 0)
            {
                ErrorMessage = "The Value should be different from zero";
                return new ValidationResult(ErrorMessage);
            }

          
            return ValidationResult.Success;
        }
    }

}
