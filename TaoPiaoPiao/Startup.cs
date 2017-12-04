using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TaoPiaoPiao.Startup))]
namespace TaoPiaoPiao
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
