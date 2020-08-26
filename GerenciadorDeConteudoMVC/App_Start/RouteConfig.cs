using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace GerenciadorDeConteudoMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "sobre_jodaias_parametro",
                "sobre/{id}/jodaias",
                new { controller = "Home", action = "about", id=0 }
            );

            routes.MapRoute(
                "sobre",
                "sobre",
                new { controller = "Home", action = "about" }
            );

            routes.MapRoute(
                "contato",
                "contato",
                new { controller = "Home", action = "contact" }
                );

            //essa rota padrão no final
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
