using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP2_Mod5_Pizza.Database;
using TP2_Mod5_Pizza.Models;

namespace TP2_Mod5_Pizza.Controllers
{
    public class PizzaController : Controller
    {
        // GET: Pizza
        public ActionResult Index()
        {
            return View(FakeDB.Instance.ListePizzas);
        }

        // GET: Pizza/Details/5
        public ActionResult Details(int id)
        {
            PizzaIngredientPateVM vm = new PizzaIngredientPateVM();
            vm.pizza = FakeDB.Instance.ListePizzas.FirstOrDefault(x => x.Id == id);
            return View(vm);
        }

        // GET: Pizza/Create
        public ActionResult Create()
        {
            PizzaIngredientPateVM vm = new PizzaIngredientPateVM();
            vm.Ingredients = FakeDB.Instance.ListeIngredients.Select(x=>new SelectListItem { Text = x.Nom,Value=x.Id.ToString()}).ToList();
            vm.Pates = FakeDB.Instance.ListePates.Select(x=>new SelectListItem {Text=x.Nom,Value = x.Id.ToString() }).ToList();
            return View(vm);
        }

        // POST: Pizza/Create
        [HttpPost]
        public ActionResult Create(PizzaIngredientPateVM vm)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    vm.pizza.Pate = FakeDB.Instance.ListePates.FirstOrDefault(x => x.Id == vm.IdPate);
                    vm.pizza.Ingredients = FakeDB.Instance.ListeIngredients.Where(x => vm.IdIngredient.Contains(x.Id))
                        .ToList();

                    vm.pizza.Id = FakeDB.Instance.ListePizzas.Count == 0 ? 1 : FakeDB.Instance.ListePizzas.Max(x => x.Id) + 1;

                    FakeDB.Instance.ListePizzas.Add(vm.pizza);

                    return RedirectToAction("Index");
                }
                else
                {
                    vm.Ingredients = FakeDB.Instance.ListeIngredients.Select(x => new SelectListItem { Text = x.Nom, Value = x.Id.ToString() }).ToList();
                    vm.Pates = FakeDB.Instance.ListePates.Select(x => new SelectListItem { Text = x.Nom, Value = x.Id.ToString() }).ToList();
                    return View(vm);
                }
                
            }
            catch
            {
                return View();
            }
        }

        // GET: Pizza/Edit/5
        public ActionResult Edit(int id)
        {
            PizzaIngredientPateVM vm = new PizzaIngredientPateVM();

            vm.Pates = FakeDB.Instance.ListePates.Select(
                x => new SelectListItem { Text = x.Nom, Value = x.Id.ToString() })
                .ToList();

            vm.Ingredients = FakeDB.Instance.ListeIngredients.Select(
                x => new SelectListItem { Text = x.Nom, Value = x.Id.ToString() })
                .ToList();

            vm.pizza = FakeDB.Instance.ListePizzas.FirstOrDefault(x => x.Id == id);

            if (vm.pizza.Pate != null)
            {
                vm.IdPate = vm.pizza.Pate.Id;
            }

            if (vm.pizza.Ingredients.Any())
            {
                vm.IdIngredient = vm.pizza.Ingredients.Select(x => x.Id).ToList();
            }

            return View(vm);
            
        }

        // POST: Pizza/Edit/5
        [HttpPost]
        public ActionResult Edit(PizzaIngredientPateVM vm)
        {
            try
            {
                Pizza pizza = FakeDB.Instance.ListePizzas.FirstOrDefault(x => x.Id == vm.pizza.Id);
                pizza.Nom = vm.pizza.Nom;
                pizza.Pate = FakeDB.Instance.ListePates.FirstOrDefault(x => x.Id == vm.IdPate);
                pizza.Ingredients = FakeDB.Instance.ListeIngredients.Where(x => vm.IdIngredient.Contains(x.Id)).ToList();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pizza/Delete/5
        public ActionResult Delete(int id)
        {
            PizzaIngredientPateVM vm = new PizzaIngredientPateVM();
            vm.pizza = FakeDB.Instance.ListePizzas.FirstOrDefault(x => x.Id == id);

            return View(vm);
        }

        // POST: Pizza/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Pizza pizza = FakeDB.Instance.ListePizzas.FirstOrDefault(x => x.Id == id);
                FakeDB.Instance.ListePizzas.Remove(pizza);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
