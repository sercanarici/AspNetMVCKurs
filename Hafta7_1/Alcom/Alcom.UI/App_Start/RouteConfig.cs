using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Alcom.UI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Urun_detay_url_rewrite",
                url: "{urunadi}-{id}-urunu",
                defaults: new { controller = "Urun", action = "Details", id = UrlParameter.Optional },
                namespaces: new string[] { "Alcom.UI.Controllers" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "Alcom.UI.Controllers" }
            );
        }
    }
}
