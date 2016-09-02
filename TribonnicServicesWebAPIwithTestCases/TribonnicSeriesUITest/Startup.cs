using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TribonnicSeriesUITest.Startup))]
namespace TribonnicSeriesUITest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
