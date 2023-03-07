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
                context.Response.Headers["Product"] = "Api for MySQL Database v1";

                // Call next middleware
                await next.Invoke();
            });

            // Custom Middleare
            app.Use(typeof(CustomMiddleware));

            // Configure Web API for self-host.
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                name: "Api-1",
                routeTemplate: "api/{controller}/{name}",
                defaults: new { id = RouteParameter.Optional }
               );
            config.Routes.MapHttpRoute(
                name: "Api-2",
                routeTemplate: "api/{controller}/{name}/{id}",
                defaults: new { id = RouteParameter.Optional }
             );

            // Web Api
            app.UseWebApi( config );
        }
    }
}
