using System.Text;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.WebPages;

namespace WebMVC.Extensions
{
    public static class HtmlExtensions
    {
        public static string BuildBreadcrumbNavigation(this HtmlHelper helper)
        {
            string control = helper.ViewContext.RouteData.Values["controller"].ToString().ToLower();
            string action = helper.ViewContext.RouteData.Values["action"].ToString().ToLower();
            if (control == "home" && action == "index")
            {
                return string.Empty;
            }

            StringBuilder breadcrumb = new StringBuilder("<div class=\"breadcrumb-content\"><ul><li class=\"has-child\">").Append(helper.ActionLink("Trang chủ", "Index", "Home").ToHtmlString()).Append("</li>");

            if (control != "home")
            {
                if (action != "index")
                    breadcrumb.Append("<li class=\"has-child\">");
                else
                    breadcrumb.Append("<li>");
                breadcrumb.Append(helper.ActionLink(helper.ViewContext.RouteData.Values["controller"].ToString().Titleize(),
                                                   "Index",
                                                   helper.ViewContext.RouteData.Values["controller"].ToString()));
                breadcrumb.Append("</li>");
            }

            if (action != "index")
            {
                breadcrumb.Append("<li>");
                breadcrumb.Append(helper.ActionLink(helper.ViewContext.RouteData.Values["action"].ToString().Titleize(),
                                                    helper.ViewContext.RouteData.Values["action"].ToString(),
                                                    helper.ViewContext.RouteData.Values["controller"].ToString()));
                breadcrumb.Append("</li>");
            }

            return breadcrumb.Append("</ul></div>").ToString();
        }

        public static string FormatPhoneNumber(this HtmlHelper helper, string phoneNum)
        {
            string result = phoneNum;
            if (phoneNum.IsEmpty() || phoneNum.Length < 4)
                return result;

            result = phoneNum.Substring(0, 4);
            if (phoneNum.Length > 4)
                result += "." + phoneNum.Substring(4, 3);

            if (phoneNum.Length > 7)
                result += "." + phoneNum.Substring(7);

            return result;
        }
    }
}