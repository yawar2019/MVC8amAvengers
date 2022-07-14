using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Mvc8amAvengersTeam
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
               name: "xyz",
               url: "pista/house",
               defaults: new { controller = "new", action = "GetMeView", eid = UrlParameter.Optional }
           );

            routes.MapRoute(
    name: "Default",
    url: "{controller}/{action}/{id}",
    defaults: new { controller = "new", action = "Index", id = UrlParameter.Optional }
);




        }
    }
}
