using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JSurvey.Startup))]
namespace JSurvey
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
