using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webmvc.Controllers
{
    public class BlogsController : BaseController
    {
        // GET: Blog
        public ActionResult Index()
        {
            return View();
        }
    }
}