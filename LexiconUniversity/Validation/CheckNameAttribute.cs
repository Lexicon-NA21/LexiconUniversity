using LexiconUniversity.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconUniversity.Validation
{
    public class CheckNameAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            const string errorMessage = "Fail";

            if(value is string input)
            {
                var model = (StudentAddViewModel)validationContext.ObjectInstance;
                if (model.FirstName == "Kalle" && input == "Anka")
                    return ValidationResult.Success;
                else
                    return new ValidationResult(errorMessage);
            }
            return new ValidationResult(errorMessage);
        }
    }
}
