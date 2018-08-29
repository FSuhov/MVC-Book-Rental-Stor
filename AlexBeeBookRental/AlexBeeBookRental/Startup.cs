using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AlexBeeBookRental.Startup))]
namespace AlexBeeBookRental
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
