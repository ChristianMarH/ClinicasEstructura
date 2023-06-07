using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OT.Ternium.NVA.EstructuraClinicas.Startup))]
namespace OT.Ternium.NVA.EstructuraClinicas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
