using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class WebDeveloperInitializer : DropCreateDatabaseAlways<WebContextDb>
    {
        protected override void Seed(WebContextDb context)
        {
            var clients = new List<Client>
            {
                new Client { Name = "Jeremy", LastName = "David" },
                new Client { Name = "Catherine", LastName = "Sanchez" },
                new Client { Name = "Jorge", LastName = "Blanch" },
                new Client { Name = "Emmanuelle", LastName = "Moran" },
                new Client { Name = "Gina", LastName = "David" }
            };
            clients.ForEach(c => context.Clients.Add(c));

            var products = new List<Product>
            {
                new Product { Code = "0001", Desc = "Arroz Costeño", dDate = DateTime.Parse("2016-06-18 12:51:00"), Price = 10.50, Stock = 5.00 },
                new Product { Code = "0002", Desc = "Azucar el Rubio", dDate = DateTime.Parse("2016-06-18 12:51:00"), Price = 9.50, Stock = 6.00 },
                new Product { Code = "0003", Desc = "Papa Amarilla", dDate = DateTime.Parse("2016-06-18 12:51:00"), Price = 8.50, Stock = 7.00 },
                new Product { Code = "0004", Desc = "Lentejas Verdes", dDate = DateTime.Parse("2016-06-18 12:51:00"), Price = 7.50, Stock = 8.00 },
                new Product { Code = "0005", Desc = "Mantenquilla Laive", dDate = DateTime.Parse("2016-06-18 12:51:00"), Price = 6.50, Stock = 9.00 }
            };
            products.ForEach(c => context.Products.Add(c));

            context.SaveChanges();
        }
    }
}
