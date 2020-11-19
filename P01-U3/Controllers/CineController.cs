using P01_U3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace P01_U3.Controllers
{
    public class CineController : Controller
    {
        readonly CineDbConnections db = new CineDbConnections();
        // GET: Cine
        public ActionResult Index()
        {
            var cine = db.Cines.ToList();
            return View(cine);
        }
       
        // GET: Cine/Details/5
        public ActionResult Details(int id)
        {
            var cine = db.Cines.Find(id);

            return View(cine);
        }

        // GET: Cine/Create
        public ActionResult Create(int id)
        {
            var cine = db.Cines.Find(id);
            return View(cine);
        }

        // POST: Cine/Create
        [HttpPost]
        public ActionResult Create(int id FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                var cine = db.Cines.Find(id);
                db.Cines.Create(cine);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cine/Edit/5
        public ActionResult Edit(int id)
        {
            var cine = db.Cines.Find(id);
            return View(cine);
        }

        // POST: Cine/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Cine c)
        {
            try
            {
                // TODO: Add update logic here
                var cine = db.Cines.Find(id);
                cine.Película = c.Película;
                cine.Horario = c.Horario;
                cine.Duración = c.Duración;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cine/Delete/5
        public ActionResult Delete(int id)
        {

            var cine = db.Cines.Find(id);

            return View(cine);
        }

        // POST: Cine/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var cine = db.Cines.Find(id);
                db.Cines.Remove(cine);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
