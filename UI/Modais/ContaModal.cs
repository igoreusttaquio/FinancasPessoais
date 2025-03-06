using Core.Dados;
using Core.Entidades;
using Core.Modelos;
using UI.Services;

namespace UI.Modais;

public partial class ContaModal : Form
{
    BancoDadosContexto _bancoDadosContexto;
    IDateTimeProvider _dateTimeProvider;
    public ContaModal(
        BancoDadosContexto bancoDadosContexto,
        IDateTimeProvider dateTimeProvider)
    {
        _bancoDadosContexto = bancoDadosContexto;
        _dateTimeProvider = dateTimeProvider;
        InitializeComponent();
        PreencherTipoContas();
    }

    private void PreencherTipoContas()
    {
        TipoConta[] tiposContas = [
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

        ComboTipoConta.DefinirValores(tiposContas);
    }

    private void botaoPrimario1_Click(object sender, EventArgs e)
    {
        var conta = new Conta
        {
            NomeConta = NomeConta.Texto,
            Saldo = decimal.Parse(Saldo.Texto),
            CriadoEm = _dateTimeProvider.UtcNow,
            TipoConta = (ComboTipoConta.Valor as TipoConta).Codigo
        };

        _bancoDadosContexto.Contas.Add(conta);
        _bancoDadosContexto.SaveChanges();

        Close();
    }
}
