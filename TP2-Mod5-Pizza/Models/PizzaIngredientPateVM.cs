using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP2_Mod5_Pizza.Models
{
    public class PizzaIngredientPateVM
    {
       public Pizza pizza { get; set; }
        
        public List<Ingredient> Ingredients { get; set; }
        public List<int> IdIngredient { get; set; }

        public List<Pate> Pates { get; set; }

        public int IdPate { get; set; }

    }
}