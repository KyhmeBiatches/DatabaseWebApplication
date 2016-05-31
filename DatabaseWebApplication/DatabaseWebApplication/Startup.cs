using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DatabaseWebApplication.Startup))]
namespace DatabaseWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
