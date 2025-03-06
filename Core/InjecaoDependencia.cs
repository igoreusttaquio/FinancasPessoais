using Core.Dados;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Core;

public static class InjecaoDependencia
{
    public static IServiceCollection AdicionarCore(this IServiceCollection servicos)
    {
        // Carregar a configuração
        servicos.AddDbContext<BancoDadosContexto>();

        return servicos;
    }
}
