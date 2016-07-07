using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;
using System.Linq;
using WebDeveloper.Resources;

namespace WebDeveloper.Controllers
{
    [Authorize]
    public class ClientController : Controller
    {
        //private ClientData _client = new ClientData();

        //private IDataAccess<Client> _client;

        private ClientData _client;

        public ClientController(ClientData client)
        {
            _client = client;
        }

        // GET: Client
        public ActionResult Index()
        {
            ViewBag.Title = Resources.Resource.Client_Title;
            //var client = new ClientData();
            return View(_client.GetList());
        }

        public ActionResult Create()
        {
            return View(new Client());
        }

        [HttpPost]
        public ActionResult Create(Client client)
        {
            /* Validación del lado del servidor - las llamadas a Requered */
            if (ModelState.IsValid)
            {
                _client.Add(client);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int Id)
        {
            return View(_client.GetClientById(Id));
        }

        [HttpPost]
        public ActionResult Edit(Client client)
        {
            /* Validación del lado del servidor - las llamadas a Requered */
            if (ModelState.IsValid)
            {
                _client.Update(client);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int Id)
        {
            var client = _client.GetClientById(Id);
            if (client == null)
                return RedirectToAction("Index");
            else 
                return View(client);
        }

        [HttpPost]
        public ActionResult Delete(Client client)
        {
            if(_client.Delete(client) > 0)
                return RedirectToAction("Index");
            return View(client);
        }

    }
}