using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopDirectory.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "WELCOME";
           
            List<SelectListItem> items = new List<SelectListItem>();

            items.Add(new SelectListItem { Text = "Shop", Value = "0", Selected = true });

            items.Add(new SelectListItem { Text = "Product", Value = "1" });

            //items.Add(new SelectListItem { Text = "Category", Value = "2" });

            ViewBag.criteria = items;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
