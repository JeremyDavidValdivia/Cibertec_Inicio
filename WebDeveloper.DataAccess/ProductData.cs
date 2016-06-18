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
    }
}
