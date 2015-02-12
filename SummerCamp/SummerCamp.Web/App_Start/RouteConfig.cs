using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SummerCamp.Web
{
    public class RouteConfig
    {

        public static string ControllerOnly = "ControllerOnly";
        public static string ControllerAndId = "ControllerAndIntegerId";
        public static string ControllerAction = "ControllerAction";


        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "ControllerAction",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


            routes.MapRoute(
         name: ControllerOnly,
         url: "{controller}"
     );

            routes.MapRoute(
               name: ControllerAndId,
               url: "{controller}/{id}",
               defaults: null, //defaults: new { id = RouteParameter.Optional } //,
               constraints: new { id = @"^\d+$" } // id must be all digits
           );






        }
    }
}
