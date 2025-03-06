using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Dados;

public static class MigradorBancoDados
{
    public static void Migrar(IServiceProvider serviceProvider)
    {
        using var scope = serviceProvider.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<BancoDadosContexto>();
        try
        {
            Console.WriteLine("Aplicando migrações...");
            dbContext.Database.Migrate();
            Console.WriteLine("Migrações aplicadas com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao aplicar migrações: {ex.Message}");
        }
    }
}