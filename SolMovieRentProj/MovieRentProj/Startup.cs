using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieRentProj.Startup))]
namespace MovieRentProj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
