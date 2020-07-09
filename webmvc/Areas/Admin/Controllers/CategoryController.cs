using BAL.Domain;
using BAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Areas.Admin.Controllers
{
    public class CategoryController : BaseController
    {
        private ICategoryService _category;
        public CategoryController(ICategoryService category)
        {
            _category = category;
        }

        // GET: Admin/Category
        public ActionResult Index()
        {
            var model = _category.GetAll();
            return View(model);
        }

        public ActionResult Details(long? id)
        {
            var model = _category.Get(id);
            return View(model);
        }

        public ActionResult Delete(long? id)
        {
            var model = _category.Delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            var model = new CategoryDto();
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(CategoryDto model)
        {
            try {
                _category.Insert(model);
                return RedirectToAction("Index");
            } catch
            {

            }
            return View(model);
        }

        public ActionResult Edit(long? id)
        {
            var model = _category.Get(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(CategoryDto model)
        {
            try
            {
                _category.Update(model);
                return RedirectToAction("Index");
            }
            catch
            {

            }
            return View(model);
        }
    }
}