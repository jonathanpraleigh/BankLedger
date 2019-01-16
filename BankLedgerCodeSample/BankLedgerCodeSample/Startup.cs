using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BankLedgerCodeSample.Startup))]
namespace BankLedgerCodeSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
