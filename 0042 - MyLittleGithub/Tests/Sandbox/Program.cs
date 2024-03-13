using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

using CommandLine;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MyLittleGithub.Data;
using MyLittleGithub.Data.Common;
using MyLittleGithub.Data.Common.Repositories;
using MyLittleGithub.Data.Models;
using MyLittleGithub.Data.Repositories;
using MyLittleGithub.Data.Seeding;
using MyLittleGithub.Services.Messaging;

namespace Sandbox;

public static class Program
{
    public static int Main(string[] args)
    {
        Console.WriteLine($"{typeof(Program).Namespace} ({string.Join(" ", args)}) starts working...");
        var serviceCollection = new ServiceCollection();
        ConfigureServices(serviceCollection);
        IServiceProvider serviceProvider = serviceCollection.BuildServiceProvider(true);

        // Seed data on application startup
        using (var serviceScope = serviceProvider.CreateScope())
        {
            var dbContext = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            dbContext.Database.Migrate();
            new ApplicationDbContextSeeder().SeedAsync(dbContext, serviceScope.ServiceProvider).GetAwaiter().GetResult();
        }

        using (var serviceScope = serviceProvider.CreateScope())
        {
            serviceProvider = serviceScope.ServiceProvider;

            return Parser.Default.ParseArguments<SandboxOptions>(args).MapResult(
                opts => SandboxCode(opts, serviceProvider).GetAwaiter().GetResult(),
                _ => 255);
        }
    }

    private static void ConfigureServices(ServiceCollection services)
    {
        var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", false, true)
            .AddEnvironmentVariables()
            .Build();

        services.AddSingleton<IConfiguration>(configuration);

        services.AddDbContext<ApplicationDbContext>(
            options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
                .UseLoggerFactory(new LoggerFactory()));

        services.AddDefaultIdentity<ApplicationUser>(IdentityOptionsProvider.GetIdentityOptions)
            .AddRoles<ApplicationRole>().AddEntityFrameworkStores<ApplicationDbContext>();

        services.AddScoped(typeof(IDeletableEntityRepository<>), typeof(EfDeletableEntityRepository<>));
        services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));
        services.AddScoped<IDbQueryRunner, DbQueryRunner>();

        // Application services
        services.AddTransient<IEmailSender, NullMessageSender>();
    }
}