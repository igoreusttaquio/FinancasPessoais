using Core.Modelos;

namespace UI.Modais;

public partial class ContaModal : Form
{
    public ContaModal()
    {
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

        ComboTipoContas.DefinirValores(tiposContas);
    }
}
