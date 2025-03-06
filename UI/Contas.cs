using Core.Dados;
using UI.Modais;

namespace UI;

public partial class Contas : Form
{
    ContaModal _conta;
    BancoDadosContexto _bancoDadosContexto;
    public Contas(
        ContaModal conta,
        BancoDadosContexto bancoDadosContexto)
    {
        InitializeComponent();
        _conta = conta;
        _bancoDadosContexto = bancoDadosContexto;

        tabela1.DataSource = _bancoDadosContexto.Contas
            .ToList().Select(c => 
            new { Nome = c.NomeConta, Tipo = c.TipoConta, Saldo = c.Saldo }).ToList();
    }

    private void botaoPrimario1_Click(object sender, EventArgs e)
    {
        _conta.ShowDialog();
    }
}
