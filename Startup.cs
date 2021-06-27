using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AcKyGadgets.Startup))]
namespace AcKyGadgets
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
