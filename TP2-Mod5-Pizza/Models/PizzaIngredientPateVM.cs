﻿using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using TP2_Mod5_Pizza.Validation;

namespace TP2_Mod5_Pizza.Models
{
    public class PizzaIngredientPateVM
    {
        public Pizza pizza { get; set; }

        [IngredientValidator]
        public List<SelectListItem> Ingredients { get; set; } = new List<SelectListItem>();
        public List<int> IdIngredient { get; set; }

        public List<SelectListItem> Pates { get; set; } = new List<SelectListItem>();


        [Required]
        public int? IdPate { get; set; }

    }
}