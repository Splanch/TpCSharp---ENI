using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TP2_Mod5_Pizza.Validation
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class IngredientValidator : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            bool result = false;
            List<int> IngredientsSelect = (List<int>)value;
            if(IngredientsSelect.Count <= 5 && IngredientsSelect.Count >= 2 )
            {
                result = true;
                return result;
            }
            return result;
        }

        public override string FormatErrorMessage(string name)
        {
            return "Une pizza doit avoir entre 2 et 5 ingrédients ";
        }
    }
    
}