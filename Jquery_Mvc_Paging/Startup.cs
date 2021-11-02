using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Jquery_Mvc_Paging.Startup))]
namespace Jquery_Mvc_Paging
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
