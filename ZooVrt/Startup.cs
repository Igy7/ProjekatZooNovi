using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZooVrt.Startup))]
namespace ZooVrt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
