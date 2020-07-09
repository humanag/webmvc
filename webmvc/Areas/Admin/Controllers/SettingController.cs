using BAL.Domain;
using BAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Areas.Admin.Controllers
{
    public class SettingController : BaseController
    {
        IParamService _service;
        public SettingController(IParamService service)
        {
            _service = service;
        }

        // GET: Admin/Setting
        public ActionResult Index()
        {
            var model = _service.Get();
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(SiteInfoDto model)
        {
            _service.Update(model);
            return View("Index", model);
        }
    }
}