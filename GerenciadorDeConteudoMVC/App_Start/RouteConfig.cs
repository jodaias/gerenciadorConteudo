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
                "paginas",
                "paginas",
                new { controller = "Paginas", action = "Index" }
            );
            
            routes.MapRoute(
                "paginas_criar",
                "paginas/criar",
                new { controller = "Paginas", action = "Criar" }
            );

            routes.MapRoute(
                "paginas_novo",
                "paginas/novo",
                new { controller = "Paginas", action = "Novo" }
            );

            routes.MapRoute(
                "paginas_editar",
                "paginas/{id}/editar",
                new { controller = "Paginas", action = "Editar", id = 0}
            );

            routes.MapRoute(
                "paginas_alterar",
                "paginas/{id}/alterar",
                new { controller = "Paginas", action = "Alterar", id = 0 }
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
