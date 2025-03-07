namespace Core.Entidades;

public class Transacao
{
    public Guid Id { get; set; }
    public Guid ContaId { get; set; }
    public Guid CategoriaId { get; set; }
    public decimal Valor { get; set; }
    public DateTime DataTransacao { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public DateTime CriadoEm { get; set; }

    // Relacionamento com a conta
    public Conta? Conta { get; set; }

    // Relacionamento com a categoria
    public Categoria? Categoria { get; set; }
}
