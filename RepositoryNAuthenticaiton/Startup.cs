using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RepositoryNAuthenticaiton.Startup))]
namespace RepositoryNAuthenticaiton
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
