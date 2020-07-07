using webmvc.Models;
using MvcSiteMapProvider.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webmvc.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // @TODO get data.
            List<CategoryViewModel> categories = new List<CategoryViewModel>();
            categories.Add(new CategoryViewModel() { Id = 1, Name = "Cửa lưới chống muỗi" });
            categories.Add(new CategoryViewModel() { Id = 2, Name = "Cửa nhựa lõi thép" });
            categories.Add(new CategoryViewModel() { Id = 3, Name = "Cửa nhôm Xingfa nhập Quảng Đông" });
            categories.Add(new CategoryViewModel() { Id = 4, Name = "Cầu thang kính" });
            categories.Add(new CategoryViewModel() { Id = 5, Name = "Cửa nhôm PMA" });
            categories.Add(new CategoryViewModel() { Id = 6, Name = "Vách kính" });
            categories.Add(new CategoryViewModel() { Id = 7, Name = "Vách kính tắm" });
            categories.Add(new CategoryViewModel() { Id = 8, Name = "Lan can kính" });

            SiteInfoModel siteInfo = new SiteInfoModel();
            siteInfo.Name = "Minh Hoàng Đà Lạt";
            siteInfo.Address = "Lô G26, Trần Anh Tông, KQH Nguyên tử Lực, Phường 8, TP.Đà Lạt";
            siteInfo.Province = "Lâm Đồng";
            siteInfo.Phone = "0931222775";
            siteInfo.Phone2 = "0986909997";

            this.ViewBag.SiteInfo = siteInfo;
            this.ViewBag.Categories = categories;

            base.OnActionExecuting(filterContext);
        }
    }
}