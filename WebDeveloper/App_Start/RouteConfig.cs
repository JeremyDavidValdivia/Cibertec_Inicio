using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebDeveloper
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Razor/2016/12/12
            //Razor/25/12/2016
            //routes.MapRoute(
            //    name: "RazorId",
            //    url: "Razor/{id}",
            //    defaults: new
            //    {
            //        controller = "Razor",
            //        action = "EntryId",
            //    }
            //);

            //routes.MapRoute(
            //    name: "RazorDate",
            //    url: "Razor/{date}",
            //    defaults: new
            //    {
            //        controller = "Razor",
            //        action = "EntryDate",
            //    }
            //);

            routes.MapMvcAttributeRoutes();
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Account",
                                action = "Login",
                                id = UrlParameter.Optional }
            );
        }
    }
}
