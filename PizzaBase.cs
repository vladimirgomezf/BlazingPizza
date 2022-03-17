using System.ComponentModel.DataAnnotations;

namespace BlazingPizza
{
    public class PizzaBase : ValidationAttribute
    {
        public string GetErrorMessage() => $"Sorry, that's not a valid pizza base.";

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            return value != "Tomato" || value != "Pesto" ? new ValidationResult(GetErrorMessage()) : ValidationResult.Success;
        }
    }
}
