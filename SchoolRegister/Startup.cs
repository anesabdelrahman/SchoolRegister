using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SchoolRegister.Startup))]
namespace SchoolRegister
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
