using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SymptomCracker.Startup))]
namespace SymptomCracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
