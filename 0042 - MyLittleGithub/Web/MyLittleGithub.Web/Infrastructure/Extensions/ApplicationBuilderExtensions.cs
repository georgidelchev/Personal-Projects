using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyLittleGithub.Data;
using MyLittleGithub.Data.Seeding;

namespace MyLittleGithub.Web.Infrastructure.Extensions;

public static class ApplicationBuilderExtensions
{
    public static IApplicationBuilder UseEndpoints(this IApplicationBuilder app)
        => app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute("areaRoute", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
            endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            endpoints.MapRazorPages();
        });

    public static IApplicationBuilder PrepareDatabase(this IApplicationBuilder app)
    {
        using var serviceScope = app.ApplicationServices.CreateScope();

        var dbContext = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

        MigrateDatabase(dbContext);
        SetupSeeding(dbContext, serviceScope);

        return app;
    }

    private static void MigrateDatabase(ApplicationDbContext dbContext)
        => dbContext.Database.Migrate();

    private static void SetupSeeding(ApplicationDbContext dbContext, IServiceScope serviceScope)
        => new ApplicationDbContextSeeder()
            .SeedAsync(dbContext, serviceScope.ServiceProvider)
            .GetAwaiter()
            .GetResult();
}
