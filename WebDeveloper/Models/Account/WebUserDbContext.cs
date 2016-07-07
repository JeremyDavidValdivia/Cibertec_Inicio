using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDeveloper.Models.Account
{
    public class WebUserDbContext: IdentityDbContext<WebDeveloperUser>
    {
        public WebUserDbContext() : base("IdentityConnectionString")
        {

        }
    }

    public class WebDeveloperUser : IdentityUser
    {

    }
}
