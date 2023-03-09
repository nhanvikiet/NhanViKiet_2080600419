using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NhanViKiet_2080600419_LAB03.Startup))]
namespace NhanViKiet_2080600419_LAB03
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
