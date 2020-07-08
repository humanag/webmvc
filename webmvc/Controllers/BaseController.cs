using WebMVC.Models;
using System.Collections.Generic;
using System.Web.Mvc;
using BAL.Services;
using BAL.Domain;
using System;
using System.Linq;

namespace WebMVC.Controllers
{
    public class BaseController : Controller
    {
        protected readonly ICategoryService _category;
        protected readonly IHomeService _homeService;

        public BaseController(ICategoryService category, IHomeService homeService)
        {
            this._category = category ?? throw new ArgumentNullException(nameof(category));
            this._homeService = homeService ?? throw new ArgumentNullException(nameof(homeService));
        }

        protected virtual void GetCategories()
        {
            IEnumerable<CategoryDto> categories = _category.GetAll().OrderBy(x => x.Sort);
            this.ViewBag.Categories = categories;
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            GetCategories();
            SiteInfoDto siteInfo = _homeService.GetSiteInfo();
            this.ViewBag.SiteInfo = siteInfo;
            
            base.OnActionExecuting(filterContext);
        }
    }
}