using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.ActionFilters;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    [LogActionFilter]
    [RoutePrefix("Razor")]
    public class RazorController : Controller
    {
        // GET: Razor
        [Route]
        public ActionResult Index()
        {
            var clients = new List<Client>
            {
                new Client { ID = 1, Name = "Jeremy", LastName = "David" },
                new Client { ID = 2, Name = "Catherine", LastName = "Sanchez" },
                new Client { ID = 3, Name = "Jorge", LastName = "Blanch" },
                new Client { ID = 4, Name = "Emmanuelle", LastName = "Moran" },
                new Client { ID = 5, Name = "Gina", LastName = "David" }
            };
            var client = new Client()
            {
                ID = 1, LastName = "Cueva", Name = "Aladino"
            };
            return View(clients);
        }

        public ActionResult Product()
        {
            var productData = new ProductData();
            return View(productData.GetFakeProducts());
        }

        [Route("Entry/{date:DateTime}")]
        public ActionResult EntryDate(DateTime date)
        {
            ViewBag.Date = date.ToShortDateString();
            return View();
        }

        [Route("Entry/{id:int}")]
        public string EntryId(int id)
        {
            return id.ToString();
        }
    }
}