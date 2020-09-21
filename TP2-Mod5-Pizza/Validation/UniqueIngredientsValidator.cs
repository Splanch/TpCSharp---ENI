using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TP2_Mod5_Pizza.Validation
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class UniqueIngredientsValidator : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            bool result = true;

            List<int> selectedIngredients = List<int> value;
            

            return result;
        }
    }
}