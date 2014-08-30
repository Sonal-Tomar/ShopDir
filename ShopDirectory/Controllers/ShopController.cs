using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopDirectory.Models;

namespace ShopDirectory.Controllers
{
    public class ShopController : Controller
    {
       private ShopContext db = new ShopContext();

        //
        // GET: /Shop/

        public ActionResult Index()
        {
            return View(db.Shops.ToList());
        }

        //
        // GET: /Shop/Details/5

        public ActionResult Details(int id = 0)
        {
            Shop shop = db.Shops.Find(id);
            if (shop == null)
            {
                return HttpNotFound();
            }
            return View(shop);
        }

        //
        // GET: /Shop/location

        public ActionResult Location(int id = 0)
        {
            Shop shop = db.Shops.Find(id);
            if (shop == null)
            {
                return HttpNotFound();
            }
            return View();
        }

        //
        // GET: /Shop/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Shop/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Shop shop)
        {
            if (ModelState.IsValid)
            {
                db.Shops.Add(shop);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(shop);
        }

        //
        // GET: /Shop/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Shop shop = db.Shops.Find(id);
            if (shop == null)
            {
                return HttpNotFound();
            }
            return View(shop);
        }
      

        //
        // POST: /Shop/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Shop shop)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shop).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shop);
        }

        //
        // GET: /Shop/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Shop shop = db.Shops.Find(id);
            if (shop == null)
            {
                return HttpNotFound();
            }
            return View(shop);
        }

        //
        // POST: /Shop/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Shop shop = db.Shops.Find(id);
            db.Shops.Remove(shop);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}