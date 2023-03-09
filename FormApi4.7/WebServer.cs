using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApi4._7
{
    internal class WebServer
    {
        private IDisposable _disposed;
        public void Start()
        {
            _disposed = WebApp.Start<Startup>("http://localhost:12345");
        }
        public void Stop()
        {
            _disposed.Dispose();
        }
    }
}
