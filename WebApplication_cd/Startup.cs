using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication_cd.Startup))]
namespace WebApplication_cd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
