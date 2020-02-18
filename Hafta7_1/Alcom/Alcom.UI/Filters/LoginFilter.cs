using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Alcom.UI.Filters
{
    public class LoginFilter : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
           
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {

          var session =   filterContext.HttpContext.Session["lgnUser"];
            if (session == null)
            {
                filterContext.Result = new RedirectResult("/Kullanici/GirisYap");
            }
        }
    }
}