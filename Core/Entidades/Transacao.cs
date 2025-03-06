namespace Core.Entidades;

public class Transacao
{
    public int TransacaoId { get; set; }
    public int ContaId { get; set; }
    public int? CategoriaId { get; set; }
    public decimal Valor { get; set; }
    public DateTime DataTransacao { get; set; }
    public string Descricao { get; set; }
    public DateTime CriadoEm { get; set; }

    // Relacionamento com a conta
    public Conta Conta { get; set; }

    // Relacionamento com a categoria
    public Categoria Categoria { get; set; }
}
