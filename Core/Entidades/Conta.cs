using Core.Modelos;

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

    public static TipoConta[] TiposContas = [
             new TipoConta("corrente", "Conta Corrente"),
             new TipoConta("poupanca", "Conta Poupança"),
             new TipoConta("salario", "Conta Salário"),
             new TipoConta("pagamento", "Conta de Pagamento (Digital)"),
             new TipoConta("conjunta", "Conta Conjunta"),
             new TipoConta("empresarial", "Conta Empresarial (PJ)"),
             new TipoConta("universitaria", "Conta Universitária"),
             new TipoConta("remunerada", "Conta Remunerada"),
             new TipoConta("investimento", "Conta Investimento"),
             new TipoConta("internacional", "Conta Internacional")
        ];
}
