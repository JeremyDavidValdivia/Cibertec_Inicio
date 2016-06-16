using System;
using System.Linq;
using System.Collections.Generic;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class ClientData : BaseDataAccesscs<Client>
    {
        public Client GetClientById(int id)
        {
            using (var dbcontext = new WebContextDb())
            {
                return dbcontext.Clients.FirstOrDefault(c => c.ID == id);
            }
        }
    }
}
