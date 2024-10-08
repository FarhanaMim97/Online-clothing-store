using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(onlineClothingStore.Startup))]
namespace onlineClothingStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
