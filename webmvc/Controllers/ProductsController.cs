using webmvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webmvc.Controllers
{
    public class ProductsController : BaseController
    {
        // GET: Product
        public ActionResult Index()
        {
            List<ProductModels>  products = new List<ProductModels>();
            return View(products);
        }
    }
}