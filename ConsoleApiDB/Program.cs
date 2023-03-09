using Microsoft.Owin.Hosting;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace ConsoleApiDB
{
    public class Program : Form
    {
        public Program() 
        {
            
        }

        [STAThread]
        static void Main(string[] args)
        {
            //StartTopshelf();

            // Localhost
            using (WebApp.Start<Startup>("http://localhost:12345"))
            {
                Console.WriteLine(" ||-------------------------------------------------||");
                Console.WriteLine(" ||   Server is running at http://localhost:12345   ||");
                Console.WriteLine(" ||                                                 ||");
                Console.WriteLine(" ||   Press Ctrl + C to quit.                       ||");
                Console.WriteLine(" ||-------------------------------------------------||");
                Console.ReadLine();
            }

            //
            Application.EnableVisualStyles();
            Application.Run(new Program());
            Application.SetCompatibleTextRenderingDefault(false);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Program
            // 
            this.ClientSize = new System.Drawing.Size(614, 440);
            this.Name = "Program";
            this.Load += new System.EventHandler(this.Program_Load);
            this.ResumeLayout(false);

        }

        private void Program_Load(object sender, EventArgs e)
        {

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
