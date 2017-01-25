using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Carrito.Startup))]
namespace Carrito
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
