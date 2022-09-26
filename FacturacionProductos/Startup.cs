using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FacturacionProductos.Startup))]
namespace FacturacionProductos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
