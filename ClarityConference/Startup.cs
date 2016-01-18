using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClarityConference.Startup))]
namespace ClarityConference
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
