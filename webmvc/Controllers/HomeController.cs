using BAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers
{
    public class HomeController : BaseController
    {
        private IProductService _product;
        private IBlogService _blog;
        public HomeController(IBlogService blog, IProductService product, 
            ICategoryService category, IHomeService homeService) : base(category, homeService)
        {
            _product = product;
            _blog = blog;
        }

        public ActionResult Index()
        {
            var prodNews = _product.GetNew();
            ViewBag.ProductNew = prodNews;

            var blogs = _blog.GetAll(1, 5);
            ViewBag.Blogs = blogs;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}