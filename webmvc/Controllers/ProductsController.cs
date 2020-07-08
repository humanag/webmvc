using WebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BAL.Services;
using BAL.Domain;

namespace WebMVC.Controllers
{
    public class ProductsController : BaseController
    {
        private IProductService _service;

        public ProductsController(IProductService service, ICategoryService category, IHomeService homeService) : base(category, homeService)
        {
            _service = service;
        }
        protected override void GetCategories()
        {
            IEnumerable<CategoryWithProductContDto> categories = _category.GetAllWithProductCount();
            this.ViewBag.Categories = categories;
        }

        // GET: Product
        public ActionResult Index(long? cat)
        {
            var products = _service.GetAll();
            return View(products);
        }
    }
}