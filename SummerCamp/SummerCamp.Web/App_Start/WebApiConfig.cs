using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;

namespace SummerCamp.Web
{
    public static class WebApiConfig
    {

        public static string ControllerOnly = "ApiControllerOnly";
        public static string ControllerAndId = "ApiControllerAndIntegerId";
        public static string ControllerAction = "ApiControllerAction";


        public static void Register(HttpConfiguration config)
        {

            var routes = config.Routes;

            // Web API routes
            config.MapHttpAttributeRoutes();


            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            routes.MapHttpRoute(
               name: ControllerOnly,
               routeTemplate: "api/{controller}"
           );

            routes.MapHttpRoute(
               name: ControllerAndId,
               routeTemplate: "api/{controller}/{id}",
               defaults: null, //defaults: new { id = RouteParameter.Optional } //,
               constraints: new { id = @"^\d+$" } // id must be all digits
           );

            

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);


            routes.MapHttpRoute(
              name: ControllerAction,
              routeTemplate: "api/{controller}/{action}"
          );


        }
    }
}
