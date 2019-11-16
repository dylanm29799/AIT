using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Liverpool.Models;

namespace Liverpool.Controllers
{
    public class ExtrasController : Controller
    {
        private LiverpoolContext db = new LiverpoolContext();

        // GET: Extras
        public ActionResult Index()
        {
            return View(db.Extrass.ToList());
        }

        // GET: Extras/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Extras extras = db.Extrass.Find(id);
            if (extras == null)
            {
                return HttpNotFound();
            }
            return View(extras);
        }

        // GET: Extras/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Extras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ExtraID,ExtraName,ExtraPrice")] Extras extras)
        {
            if (ModelState.IsValid)
            {
                db.Extrass.Add(extras);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(extras);
        }

        // GET: Extras/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Extras extras = db.Extrass.Find(id);
            if (extras == null)
            {
                return HttpNotFound();
            }
            return View(extras);
        }

        // POST: Extras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ExtraID,ExtraName,ExtraPrice")] Extras extras)
        {
            if (ModelState.IsValid)
            {
                db.Entry(extras).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(extras);
        }

        // GET: Extras/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Extras extras = db.Extrass.Find(id);
            if (extras == null)
            {
                return HttpNotFound();
            }
            return View(extras);
        }

        // POST: Extras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Extras extras = db.Extrass.Find(id);
            db.Extrass.Remove(extras);
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
