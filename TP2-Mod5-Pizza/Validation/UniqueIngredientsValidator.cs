using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TP2_Mod5_Pizza.Database;

namespace TP2_Mod5_Pizza.Validation
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class UniqueIngredientsValidator : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            bool result = true;

            List<int> selectedIngredients = (List<int>) value;

            if (FakeDB.Instance.ListePizzas.Any(x => x.Ingredients.Select(y => y.Id).OrderBy(z => z).SequenceEqual(selectedIngredients.Select(y => int.Parse(y.ToString())).OrderBy(z => z))))
            {
                result = false;
                return result;
            }
           

            return result;
        }

        public override string FormatErrorMessage(string name)
        {
            return "Une pizza à déjà ces ingrédients";
        }
    }
}