using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class ProductData : BaseDataAccesscs<Product>
    {
        public Product GetProductById(int id)
        {
            using (var dbcontext = new WebContextDb())
            {
                return dbcontext.Products.FirstOrDefault(c => c.ID == id);
            }
        }

        public List<Product> GetFakeProducts()
        {
            return new List<Product>
            {
                new Product { ID = 1, Desc = "Cristal", Price = 3.5, CreateDate=null },
                new Product { ID = 2, Desc = "Pilse", Price = 0.0, CreateDate=DateTime.Parse("2016-06-22 12:51:00") }
            };
        }
    }
}
