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
        ComboTipoConta.DefinirValores(Conta.TiposContas);
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
