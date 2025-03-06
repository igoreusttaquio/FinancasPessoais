using Core;
using Core.Dados;
using EmbeddedForms;
using Microsoft.Extensions.DependencyInjection;
using UI.Modais;
using UI.Services;
namespace UI;

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
        ConfigureFormularios(services);
        var serviceProvider = services.BuildServiceProvider();

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        MigradorBancoDados.Migrar(serviceProvider);
        Application.Run(serviceProvider.GetRequiredService<Main>());
    }

    static void ConfigureFormularios(IServiceCollection servicos)
    {
        servicos.AddTransient<Main>();
        servicos.AddTransient<DashBoard>();
        servicos.AddTransient<Contas>();
        servicos.AddTransient<Transacoes>();
        servicos.AddTransient<Categorias>();
        servicos.AddSingleton<IDateTimeProvider, DateTimeProvider>(); // Example service
        servicos.AddSingleton<INavigationService, NavigationService>();
        IncluirModais(servicos);
    }

    static void IncluirModais(IServiceCollection servicos)
    {
        servicos.AddTransient<CategoriaModal>();
        servicos.AddTransient<TransacaoModal>();
        servicos.AddTransient<ContaModal>();
    }
}