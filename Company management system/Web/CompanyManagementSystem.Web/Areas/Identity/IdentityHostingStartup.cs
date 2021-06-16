using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(CompanyManagementSystem.Web.Areas.Identity.IdentityHostingStartup))]

namespace CompanyManagementSystem.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => { });
        }
    }
}
