using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ReportImoveis.Repository;

namespace ReportImoveis
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;


            ApplicationConfiguration.Initialize();
            Application.Run(ServiceProvider.GetRequiredService<ReportImoveisFront>());
        }
        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddTransient<IDataControl, DataControl>();
                    services.AddTransient<Criacao>();
                    services.AddTransient<ReportImoveisFront>();
                    services.AddTransient<ApresentacaoForm>();
                });
        }
    }
}