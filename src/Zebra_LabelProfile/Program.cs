using Microsoft.Extensions.Hosting;
using Zebra_LabelProfile.Services;
using Application = System.Windows.Forms.Application;

namespace Zebra_LabelProfile
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.SetColorMode(SystemColorMode.System);
            ApplicationConfiguration.Initialize();
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;
            Application.Run(ServiceProvider.GetRequiredService<MainView>());
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddTransient<MainView>();
                    services.AddSingleton<ISGDCommandListService, SGDCommandListService>();
                });
        }
    }
}
