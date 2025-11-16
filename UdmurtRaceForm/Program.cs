using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using UdmurtRace.DAL;
using UdmurtRace.DAL.Repositories;

namespace UdmurtRaceForm
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);

            using var serviceProvider = services.BuildServiceProvider();
            ApplicationConfiguration.Initialize();
            Application.Run(serviceProvider.GetRequiredService<MainForm>());
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            var connectionString = "Server=localhost;Database=UdmurtRace;User=root;Password=;Port=3306;";

            services.AddDbContext<AppDbContext>(options =>
                options.UseMySQL(connectionString));

            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IRaceRepository, RaceRepository>();
            services.AddScoped<ISaleRepository, SaleRepository>();

            services.AddScoped<MainForm>();
        }
    }
}