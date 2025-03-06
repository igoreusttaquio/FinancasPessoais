namespace Core.Entidades;

public class Conta
{
    public int ContaId { get; set; }
    public int UsuarioId { get; set; }
    public string NomeConta { get; set; }
    public string TipoConta { get; set; }
    public decimal Saldo { get; set; }
    public DateTime CriadoEm { get; set; }

    // Relacionamento com o usuário
    //public Usuario Usuario { get; set; }

    // Relacionamento com as transações
    public ICollection<Transacao> Transacoes { get; set; }
}
