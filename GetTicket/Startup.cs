using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GetTicket.Startup))]
namespace GetTicket
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
