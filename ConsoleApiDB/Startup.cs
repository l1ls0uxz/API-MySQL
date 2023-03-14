using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Owin;

namespace ConsoleApiDB
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Adding to the pipeline with our own middleware
            app.Use(async (context, next) =>
            {
                // Add Header
                context.Response.Headers["Product"] = "Api for MySQL Database v1.5";

                // Call next middleware
                await next.Invoke();
            });

            // Custom Middleare
            app.Use(typeof(CustomMiddleware));

            // Configure Web API for self-host.
            var config = new HttpConfiguration();
                 // 1
            config.Routes.MapHttpRoute(
                name: "Api-1",
                routeTemplate: "api/{controller}/{name}/{date}",
                defaults: new { id = RouteParameter.Optional }
                );
                // 2
            config.Routes.MapHttpRoute(
                name: "Api-2",
                routeTemplate: "api/{controller}/{name}/{id}",
                defaults: new { id = RouteParameter.Optional }
                );
                // 3
            config.Routes.MapHttpRoute(
                name: "Api-3",
                routeTemplate: "api/{controller}/{name}/{Datefrom}/{Dateto}",
                defaults: new { id = RouteParameter.Optional }
                );
                // 4
            config.Routes.MapHttpRoute(
                name: "Api-4",
                routeTemplate: "api/{controller}/{name}/{Datereport}/{Time}/{check}",
                defaults: new { id = RouteParameter.Optional }
                );

            // Web Api
            app.UseWebApi( config );
        }
    }
}
