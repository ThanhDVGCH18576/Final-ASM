using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Final_ASM.Startup))]
namespace Final_ASM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
