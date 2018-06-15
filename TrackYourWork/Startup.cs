using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrackYourWork.Startup))]
namespace TrackYourWork
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
