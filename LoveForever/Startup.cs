using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LoveForever.Startup))]
namespace LoveForever
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
