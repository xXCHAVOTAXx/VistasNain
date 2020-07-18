using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VistasNain.Startup))]
namespace VistasNain
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
