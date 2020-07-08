using BAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers
{
    public class BlogsController : BaseController
    {
        public BlogsController(ICategoryService category, IHomeService homeService) : base(category, homeService)
        {
        }

        // GET: Blog
        public ActionResult Index()
        {
            return View();
        }
    }
}