using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TP2_Mod5_Pizza.Database;


namespace TP2_Mod5_Pizza.Validation
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class NomUniqueValidator : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            bool result = true;
            Pizza pizza = (Pizza)value;

            if (FakeDB.Instance.ListePizzas.FirstOrDefault(x => x.Nom == pizza.Nom) != null)
            {
                result = false;
            }

            return result;
        }

        public override string FormatErrorMessage(string name)
        {
            return "Ce nom est déjà pris";
        }
    }
}