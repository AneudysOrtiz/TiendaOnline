using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(shoppingStore.Startup))]
namespace shoppingStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
