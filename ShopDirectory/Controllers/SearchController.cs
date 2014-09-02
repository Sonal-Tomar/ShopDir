using ShopDirectory.Models;
using ShopDirectory.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopDirectory.Controllers
{
    public class SearchController : Controller
    {
        private ShopContext db = null;

        public SearchController()
        {
            db = new ShopContext();
        }

        //
        // GET: /Search/

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Index(string Criteria, string searchString)
        {
           
            if (String.IsNullOrEmpty(searchString) || String.IsNullOrEmpty(Criteria))
            {
                throw new ArgumentNullException();
            }

            Searcher searcher = new Searcher(db);
            
            IEnumerable<Shop> results = null;

            switch (Criteria)
            {
                case "0":
                    //shop
                    results = searcher.SearchByShopName(searchString);
                    break;

                case "1":
                    // product
                    results = searcher.SearchByProductName(searchString);
                    break;

                //case "2":
                //    // category
                //    results = searcher.SearchCategory(searchString);
                //    break;

                default:
                    break;
            }

            return View(results);
        }

    }
}
