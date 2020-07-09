using BAL.Models;
using BAL.Common;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebMVC.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var session = (LoginUser)Session[Constants.USER_SESSION];
            if (session == null)
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Account", action = "Login", area = "" }));
            }

            base.OnActionExecuting(filterContext);
        }
    }
}