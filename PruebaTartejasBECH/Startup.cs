using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PruebaTartejasBECH.Startup))]
namespace PruebaTartejasBECH
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
