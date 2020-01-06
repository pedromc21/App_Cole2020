using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(App_Cole2020.Web.Startup))]
namespace App_Cole2020.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
