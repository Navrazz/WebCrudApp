using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PizzaStore.Startup))]
namespace PizzaStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
