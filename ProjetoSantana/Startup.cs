using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetoSantana.Startup))]
namespace ProjetoSantana
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
