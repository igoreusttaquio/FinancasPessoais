using Core;
using EmbeddedForms;
using Microsoft.Extensions.DependencyInjection;
using UI.Modal;
using UI.Services;
namespace UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            services.AdicionarCore();
            ConfigureServices(services);
            var serviceProvider = services.BuildServiceProvider();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(serviceProvider.GetRequiredService<Main>());
        }

        static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<Main>();
            services.AddTransient<DashBoard>();
            services.AddTransient<Contas>();
            services.AddTransient<Transacoes>();
            services.AddTransient<Categorias>();
            services.AddTransient<Categoria>();
            services.AddSingleton<IDateTimeProvider, DateTimeProvider>(); // Example service
            services.AddSingleton<INavigationService, NavigationService>();
        }
    }
}