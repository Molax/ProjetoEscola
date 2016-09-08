using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tcc.ThalesSilveira.Startup))]
namespace Tcc.ThalesSilveira
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
