using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopDirectory.Models;

namespace ShopDirectory.Content
{
    public class AllShopController : Controller
    {
        private ShopContext db = new ShopContext();

        //
        // GET: /AllShop/

        public ActionResult Index()
        {
            return View(db.Shops.ToList());
        }

        //
        // GET: /AllShop/Details/5

        public ActionResult Details(int id = 0)
        {
            Shop shop = db.Shops.Find(id);
            if (shop == null)
            {
                return HttpNotFound();
            }
            return View(shop);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}