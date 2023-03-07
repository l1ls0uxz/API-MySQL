using Microsoft.Owin.Hosting;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace ConsoleApiDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StartTopshelf();

            // Localhost
            using (WebApp.Start<Startup>("http://localhost:12345"))
            {
                Console.WriteLine(" /-------------------------------------------------/");
                Console.WriteLine(" /   Server is running at http://localhost:12345   /");
                Console.WriteLine(" /                                                 /");
                Console.WriteLine(" /   Press Ctrl + C to quit.                       /");
                Console.WriteLine(" /-------------------------------------------------/");
                Console.ReadLine();
            }        
        }

        // Topshelf
        //static void StartTopshelf()
        //{
        //    HostFactory.Run(x =>
        //    {
        //        x.Service<WebServer>(s =>
        //        {
        //            s.ConstructUsing(name => new WebServer());
        //            s.WhenStarted(tc => tc.Start());
        //            s.WhenStopped(tc => tc.Stop());
        //        });
        //        x.RunAsLocalSystem();

        //        x.SetDescription("This is a demo of a Windows Service using Topshelf.");
        //        x.SetDisplayName("Self Host Web API Demo");
        //        x.SetServiceName("AspNetSelfHostDemo");
        //    });
        //}
    }
}
