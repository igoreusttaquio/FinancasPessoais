using Core.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Core.Dados;

public class BancoDadosContexto : DbContext
{
    public string DbPath { get; }
    public BancoDadosContexto()
    {
        var pasta = Environment.SpecialFolder.LocalApplicationData;
        var caminho = Environment.GetFolderPath(pasta);

        DbPath = Path.Join(caminho, "financas_pessoais.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={DbPath}");
    }

    public DbSet<Conta> Contas { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Transacao> Transacoes { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
}
