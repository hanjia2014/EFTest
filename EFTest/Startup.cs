using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EFTest.Startup))]
namespace EFTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
