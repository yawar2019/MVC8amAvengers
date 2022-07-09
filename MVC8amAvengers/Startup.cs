using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC8amAvengers.Startup))]
namespace MVC8amAvengers
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
