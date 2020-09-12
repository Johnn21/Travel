using System;
using System.ComponentModel.DataAnnotations;


namespace Travel.Models
{
    public class Min18Years : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var account = (RegisterViewModel)validationContext.ObjectInstance;

            if (account.birthdateUser == null)
                return new ValidationResult("Birthdate is required.");

            var age = DateTime.Today.Year - account.birthdateUser.Value.Year;

            return (age >= 18)
                ? ValidationResult.Success
                : new ValidationResult("User should be at least 18 years old to go on a membership.");
        }
    }
}