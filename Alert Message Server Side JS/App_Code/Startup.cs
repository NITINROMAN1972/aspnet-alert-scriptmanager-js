using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Alert_Message_Server_Side_JS.Startup))]
namespace Alert_Message_Server_Side_JS
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
