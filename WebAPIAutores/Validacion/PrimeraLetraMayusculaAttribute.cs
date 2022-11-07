using System.ComponentModel.DataAnnotations;

namespace WebAPIAutores.Validacion
{
    public class PrimeraLetraMayusculaAttribute: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return ValidationResult.Success;
            }

            var primerletra = value.ToString()[0].ToString();
            if(primerletra != primerletra.ToUpper())
            {
                return new ValidationResult("la primera letra debe ser mayuscular");
            }

            return ValidationResult.Success;
        }
    }
}
