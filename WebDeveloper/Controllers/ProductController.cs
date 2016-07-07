using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        //private ProductData _product = new ProductData();

        private ProductData _product;

        public ProductController(ProductData product)
        {
            _product = product;
        }

        // GET: Client
        public ActionResult Index()
        {
            //var product = new ProductData();
            ViewBag.Title = Resources.Resource.Product_Title;
            ViewBag.Edit = Resources.Resource.Edit;
            ViewBag.Create_New = Resources.Resource.Create_New;
            ViewBag.Delete = Resources.Resource.Delete;
            return View(_product.GetList());
        }

        public ActionResult Create()
        {
            return View(new Product());
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            /* Validación del lado del servidor - las llamadas a Requered */
            if (ModelState.IsValid)
            {
                _product.Add(product);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int Id)
        {
            return View(_product.GetProductById(Id));
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            /* Validación del lado del servidor - las llamadas a Requered */
            if (ModelState.IsValid)
            {
                _product.Update(product);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int Id)
        {
            var product = _product.GetProductById(Id);
            if (product == null)
                return RedirectToAction("Index");
            else
                return View(product);
        }

        [HttpPost]
        public ActionResult Delete(Product product)
        {
            if (_product.Delete(product) > 0)
                return RedirectToAction("Index");
            return View(product);
        }
    }
}