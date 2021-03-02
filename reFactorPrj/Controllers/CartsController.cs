using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using reFactorPrj.Models;

namespace reFactorPrj.Controllers
{
    public class CartsController : Controller
    {
        private reModel db = new reModel();

        // GET: Carts
        public ActionResult Index()
        {
            return View(db.tRecipe.ToList());
        }

        // GET: Carts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tRecipe tRecipe = db.tRecipe.Find(id);
            if (tRecipe == null)
            {
                return HttpNotFound();
            }
            return View(tRecipe);
        }

        // GET: Carts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Carts/Create
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "fR_Id,fR_Type,fRD_Serving,fR_Menu,fR_Do,fR_Pic")] tRecipe tRecipe)
        {
            if (ModelState.IsValid)
            {
                db.tRecipe.Add(tRecipe);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tRecipe);
        }

        // GET: Carts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tRecipe tRecipe = db.tRecipe.Find(id);
            if (tRecipe == null)
            {
                return HttpNotFound();
            }
            return View(tRecipe);
        }

        // POST: Carts/Edit/5
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "fR_Id,fR_Type,fRD_Serving,fR_Menu,fR_Do,fR_Pic")] tRecipe tRecipe)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tRecipe).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tRecipe);
        }

        // GET: Carts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tRecipe tRecipe = db.tRecipe.Find(id);
            if (tRecipe == null)
            {
                return HttpNotFound();
            }
            return View(tRecipe);
        }

        // POST: Carts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tRecipe tRecipe = db.tRecipe.Find(id);
            db.tRecipe.Remove(tRecipe);
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
