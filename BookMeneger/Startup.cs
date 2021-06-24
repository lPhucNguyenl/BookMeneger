using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookMeneger.Startup))]
namespace BookMeneger
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
