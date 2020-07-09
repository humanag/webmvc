using BAL.Domain;
using BAL.Services;
using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers
{
    public class BlogsController : BaseController
    {
        private IBlogCategoryService _blogCategory;
        private IBlogService _blog;
        public BlogsController(IBlogCategoryService blogCategory, IBlogService blog, ICategoryService category, IHomeService homeService) : base(category, homeService)
        {
            this._blogCategory = blogCategory;
            this._blog = blog;
        }

        // GET: Blog
        public ActionResult Index(int? cat)
        {
            var blogCat = _blogCategory.GetAll();
            ViewBag.BlogCategory = blogCat;
            IEnumerable<BlogDto> model;
            if (cat > 0)
                model = _blog.GetAll(x => x.CategoryId == cat);
            else 
                model = _blog.GetAll();

            return View(model);
        }
    }
}