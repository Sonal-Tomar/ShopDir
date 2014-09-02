using DotNetOpenAuth.Messaging;
using ShopDirectory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopDirectory.Utility
{
    public class Searcher
    {
        private readonly ShopContext _context;

        public Searcher(ShopContext context)
        {
            this._context = context;
        }

        public IEnumerable<Shop> SearchByShopName(string shop)
        {
            return _context.Shops.Where(s => s.Name.Contains(shop));
        }

        //public IEnumerable<Shop> SearchProduct(string keyword)
        //{
        //    return from product in context.Products
        //           where shop.Products.All(product => keyword.Contains(product.Name))
        //           select shop;
        //}
        //}

        public IEnumerable<Shop> SearchByProductName(string keyword)
        {
            //http://smehrozalam.wordpress.com/2010/06/29/entity-framework-queries-involving-many-to-many-relationship-tables/
           var shops = from s in _context.Shops
                       from p in _context.Products
                          where s.Products.Contains(p)
                        select s;
            
            return shops;

        }

        //public IEnumerable<Shop> SearchCategory(string keyword)
        //{
        //    return null;
        //}
    }


}