using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MinMaxStock : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie)validationContext.ObjectInstance;
            var stock = movie.NumberOfStock;

            return (stock > 0 && stock <= 20) ? ValidationResult.Success : new ValidationResult("The field Number in Stock must be between 1 and 20");
        }
    }
}