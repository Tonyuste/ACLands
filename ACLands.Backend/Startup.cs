using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ACLands.Backend.Startup))]
namespace ACLands.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
