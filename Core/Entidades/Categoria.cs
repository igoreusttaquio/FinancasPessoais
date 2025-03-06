namespace Core.Entidades;

public class Categoria
{
    public Guid CategoriaId { get; set; }
    public int UsuarioId { get; set; }
    public string NomeCategoria { get; set; }
    public string TipoCategoria { get; set; } // "receita" ou "despesa"
    public DateTime CriadoEm { get; set; }

    // Relacionamento com o usuário
    //public Usuario Usuario { get; set; }

    // Relacionamento com as transações
    public ICollection<Transacao> Transacoes { get; set; }
}
