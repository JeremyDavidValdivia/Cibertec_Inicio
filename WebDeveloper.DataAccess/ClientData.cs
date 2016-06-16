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
            return this.GetList().Where(c => c.ID == id).FirstOrDefault();
        }
    }
}
