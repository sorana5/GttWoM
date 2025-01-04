using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GatewayToTheWorldOfMusic.Data;
using Microsoft.Extensions.Configuration;
using System;
using System.Windows.Forms;
using GatewayToTheWorldOfMusic;

namespace GatewayToTheWorldOfMusic
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        
        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            //var builder = WebApplication.CreateBuilder(args);

            //// Register the DbContext with the DI container
            //builder.Services.AddDbContext<AppDbContext>(options =>
            //    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))
            //);

            var services = new ServiceCollection();

            //var configuration = new ConfigurationBuilder()
            //    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)  // Ensure the path is correct
            //    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            //    .Build();

            services.AddDbContext<AppDbContext>(/*options =>
                options.UseNpgsql("Host=localhost;Port=5432;Database=gateway;Username=postgres;Password=password")*/);
            //options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

            ServiceProvider = services.BuildServiceProvider();
            var dbcontext = ServiceProvider.GetRequiredService<AppDbContext>();

            //CreateHostBuilder(args).Build().Run();

            ApplicationConfiguration.Initialize();
            Application.Run(new Start());
        }

        //public static IHostBuilder CreateHostBuilder(string[] args)
        //=> Host.CreateDefaultBuilder(args)
        //    .ConfigureWebHostDefaults(
        //        webBuilder => webBuilder.UseStartup<Startup>());
    }
}