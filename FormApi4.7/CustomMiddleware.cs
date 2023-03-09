using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApi4._7
{
    public class CustomMiddleware : OwinMiddleware
    {
        public CustomMiddleware(OwinMiddleware next ) : base(next) 
        {
        }
        public async override Task Invoke(IOwinContext context)
        {
            context.Response.Headers["PC-Name"] = Environment.MachineName;
            await Next.Invoke(context);
        }
    }
}
