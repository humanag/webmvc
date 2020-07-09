using BAL.Common;
using BAL.Models;
using BAL.Services;
using BAL.Services.Implement;
using System.Web.Mvc;


namespace WebMVC.Controllers
{
    public class AccountController : Controller
    {
        private IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            this._accountService = accountService;
        }

        // GET: Account
        public ActionResult Index()
        {
            return RedirectToAction("Login");
        }

        [HttpPost]
        public ActionResult Logout()
        {
            Session[Constants.USER_SESSION] = null;
            return Redirect("/");
        }

        public ActionResult Login()
        {
            var model = new LoginViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Dữ liệu không hợp lệ.");
                return View(model);
            }

            var user = _accountService.Login(model);
            
            if (user.Status == 1)
            {
                Session.Add(Constants.USER_SESSION, user);
                return Redirect("/Admin");
            } 
            else
            {
                ModelState.AddModelError("", "Tài khoản không hợp lệ.");
            }
            return View(model);
        }
    }
}