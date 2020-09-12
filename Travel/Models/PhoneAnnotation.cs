using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travel.Models
{
    public class PhoneAnnotation : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var account = (RegisterViewModel)validationContext.ObjectInstance;

            var copy = account.phoneUser;

            int k = 0;

            while (copy > 0)
            {
                copy = copy / 10;
                k++;
            }

            return (k==5)
                ? ValidationResult.Success
                : new ValidationResult("Phone number must have 5 digits.");
        }


    }
}