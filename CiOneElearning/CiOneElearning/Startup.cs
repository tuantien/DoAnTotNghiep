using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CiOneElearning.Startup))]
namespace CiOneElearning
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
