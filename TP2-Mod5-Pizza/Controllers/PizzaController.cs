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
            return View();
        }

        // GET: Pizza/Create
        public ActionResult Create()
        {
            PizzaIngredientPateVM vm = new PizzaIngredientPateVM();
            vm.Ingredients = FakeDB.Instance.ListeIngredients;
            vm.Pates = FakeDB.Instance.ListePates;
            return View(vm);
        }

        // POST: Pizza/Create
        [HttpPost]
        public ActionResult Create(PizzaIngredientPateVM vm)
        {
            try
            {
                vm.pizza.Pate = FakeDB.Instance.ListePates.FirstOrDefault(x => x.Id == vm.IdPate);
                

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pizza/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pizza/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

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
            return View();
        }

        // POST: Pizza/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
