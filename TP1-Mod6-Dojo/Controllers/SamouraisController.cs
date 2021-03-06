﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BODojo;
using TP1_Mod6_Dojo.Data;

namespace TP1_Mod6_Dojo.Models
{
    public class SamouraisController : Controller
    {
        private TP1_Mod6_DojoContext db = new TP1_Mod6_DojoContext();

        // GET: Samourais
        public ActionResult Index()
        {
            return View(db.Samourais.ToList());
        }

        // GET: Samourais/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Samourai samourai = db.Samourais.Find(id);
           
            if (samourai == null)
            {
                return HttpNotFound();
            }
            
            return View(samourai);
        }

        // GET: Samourais/Create
        public ActionResult Create()
        {
            SamouraiVM vm = new SamouraiVM();
            List<int> armeOccupe = db.Samourais.Where(y=>y.Arme != null).Select(x => x.Arme.Id).ToList();
            vm.Armes = db.Armes.Where(x => !armeOccupe.Contains(x.Id)).ToList();
            vm.ArtMartialsVM = db.ArtMartials.ToList();
           
            return View(vm);
        }

        // POST: Samourais/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SamouraiVM vm)
        {
            if (ModelState.IsValid)
            {

                vm.Samourai.Arme = db.Armes.Find(vm.ArmeId);
                foreach (var item in vm.ArtMartialsIds)
                {
                    vm.Samourai.ArtMartials.Add(db.ArtMartials.Find(item));
                }
                db.Samourais.Add(vm.Samourai);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            vm.Armes = db.Armes.ToList();
            vm.ArtMartialsVM = db.ArtMartials.ToList();
            return View(vm);
        }

        // GET: Samourais/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Samourai samourai = db.Samourais.Find(id);
            if (samourai == null)
            {
                return HttpNotFound();
            }
            SamouraiVM vm = new SamouraiVM();
            vm.Samourai = samourai;
            vm.Armes = db.Armes.ToList();
            vm.ArtMartialsVM = db.ArtMartials.ToList();    
            Arme arme = new Arme();
            if(samourai.Arme != null)
            {
                vm.ArmeId = samourai.Arme.Id;
            }

            if (samourai.ArtMartials.Count>0)
            {
                foreach (var item in samourai.ArtMartials)
                {
                    vm.ArtMartialsIds.Add(item.Id);
                }
            }


          

            return View(vm);
        }

        // POST: Samourais/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SamouraiVM vm)
        {
            if (ModelState.IsValid)
            {
                Samourai sm = db.Samourais.Find(vm.Samourai.Id);
                if (sm == null)
                {
                    return HttpNotFound();
                }
                Arme arme = db.Armes.Find(vm.ArmeId);
                if (arme != sm.Arme)
                {
                    sm.Arme = arme ;
                }
                sm.Nom = vm.Samourai.Nom;
                sm.Force = vm.Samourai.Force;
                sm.ArtMartials.Clear();
                foreach (var item in vm.ArtMartialsIds)
                {
                    ArtMartial am = db.ArtMartials.Find(item);
                    sm.ArtMartials.Add(am);  
                }


                db.Entry(sm).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vm);
        }

        // GET: Samourais/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Samourai samourai = db.Samourais.Find(id);

            if (samourai == null)
            {
                return HttpNotFound();
            }

            SamouraiVM vm = new SamouraiVM();
            vm.Samourai = samourai;


            return View(vm);
        }

        // POST: Samourais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(SamouraiVM vm)
        {
            Samourai samourai = db.Samourais.Find(vm.Samourai.Id);
            db.Samourais.Remove(samourai);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
