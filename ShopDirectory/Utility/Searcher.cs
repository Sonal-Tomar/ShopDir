using ShopDirectory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopDirectory.Utility
{
    public class Searcher
    {
        private readonly ShopContext context;

        public Searcher(ShopContext context)
        {
            this.context = context;
        }

        public IEnumerable<Shop> SearchShop(string keyword)
        {
            return context.Shops.Where(s => s.Name.Contains(keyword));
        }

        //public IEnumerable<Shop> SearchProduct(string keyword)
        //{
        //    return from product in context.Products
        //           where shop.Products.All(product => keyword.Contains(product.Name))
        //           select shop;
        //}
        //}
       
          public IEnumerable<Shop> SearchProduct(string keyword)
      

          {
                       var query = from c in context.Products
                                   join a in context.ShopProduct
                                   on c.Id equals a.ShopProduct
                                   where c.ContactId != _contactId1
                                   select new { Contact = c, Account = a };

          }

         //public IEnumerable<Shop> SearchCategory(string keyword)
        //{
        //    return null;
        //}
    }


}