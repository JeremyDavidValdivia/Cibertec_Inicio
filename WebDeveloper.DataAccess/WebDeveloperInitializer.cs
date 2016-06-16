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
            context.SaveChanges();
        }
    }
}
