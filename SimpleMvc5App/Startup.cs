using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleMvc5App.Startup))]
namespace SimpleMvc5App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
