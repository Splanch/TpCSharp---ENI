using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP2_Mod5_Pizza.Database
{
    public class FakeDB
    {
        private static readonly Lazy<FakeDB> lazy =
            new Lazy<FakeDB>(() => new FakeDB());

        /// <summary>
        /// FakeDb singleton access.
        /// </summary>
        public static FakeDB Instance { get { return lazy.Value; } }


        private FakeDB()
        {
            this.ListeIngredients = IngredientsDisponibles;
            this.ListePates = PatesDisponibles;
            this.ListePizzas = new List<Pizza>();

        }

        public List<Ingredient> ListeIngredients { get; private set; }
        public List<Pate> ListePates { get; private set; }
        public List<Pizza> ListePizzas { get; private set; }

        private List<Ingredient> IngredientsDisponibles => new List<Ingredient>
        {
            new Ingredient{Id=1,Nom="Mozzarella"},
            new Ingredient{Id=2,Nom="Jambon"},
            new Ingredient{Id=3,Nom="Tomate"},
            new Ingredient{Id=4,Nom="Oignon"},
            new Ingredient{Id=5,Nom="Cheddar"},
            new Ingredient{Id=6,Nom="Saumon"},
            new Ingredient{Id=7,Nom="Champignon"},
            new Ingredient{Id=8,Nom="Poulet"}
        };
        private List<Pate> PatesDisponibles => new List<Pate>
        {
            new Pate{ Id=1,Nom="Pate fine, base crême"},
            new Pate{ Id=2,Nom="Pate fine, base tomate"},
            new Pate{ Id=3,Nom="Pate épaisse, base crême"},
            new Pate{ Id=4,Nom="Pate épaisse, base tomate"}
        };
    }
}