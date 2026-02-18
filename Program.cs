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
#pragma warning disable WFO5001 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
            Application.SetColorMode(SystemColorMode.System);
#pragma warning restore WFO5001 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
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
                    services.AddSingleton<IMassSGDQueryService, MassSGDQueryService>();
                });
        }
    }
}