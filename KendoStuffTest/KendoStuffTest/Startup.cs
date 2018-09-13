using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KendoStuffTest.Startup))]
namespace KendoStuffTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
