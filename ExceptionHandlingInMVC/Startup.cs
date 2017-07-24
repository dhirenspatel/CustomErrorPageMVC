using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExceptionHandlingInMVC.Startup))]
namespace ExceptionHandlingInMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
