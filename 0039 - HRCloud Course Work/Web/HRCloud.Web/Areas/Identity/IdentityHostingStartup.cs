using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(HRCloud.Web.Areas.Identity.IdentityHostingStartup))]
namespace HRCloud.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}
