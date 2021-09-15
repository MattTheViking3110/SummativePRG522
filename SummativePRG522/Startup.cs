using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SummativePRG522.Startup))]
namespace SummativePRG522
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
