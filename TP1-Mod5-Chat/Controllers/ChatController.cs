﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP.Models;
using TP1_Mod5_Chat.Data;

namespace TP1_Mod5_Chat.Controllers
{
    public class ChatController : Controller
    {
       
        // GET: Chat
        public ActionResult Index()
        {   

            return View(FakeData.Instance.ListeChats);
        }

        // GET: Chat/Details/5
        public ActionResult Details(int id)
        {
           
            return View(FakeData.Instance.ListeChats.FirstOrDefault(x => x.Id == id));
        }
        
        // GET: Chat/Delete/5
        public ActionResult Delete(int id)
        {

            return View(FakeData.Instance.ListeChats.FirstOrDefault(x => x.Id == id));
        }

        // POST: Chat/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                FakeData.Instance.ListeChats.Remove(FakeData.Instance.ListeChats.FirstOrDefault(x => x.Id == id));
                   

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
