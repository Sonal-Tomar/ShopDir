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
    public class AllProductController : Controller
    {
        private ShopContext db = new ShopContext();

        //
        // GET: /AllProduct/

        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }

        //
        // GET: /AllProduct/Details/5

        public ActionResult Details(int id = 0)
        {
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

     

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}