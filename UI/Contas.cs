using Core.Dados;
using Core.Entidades;
using Microsoft.EntityFrameworkCore;
using UI.Modais;
using UI.Utils;

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
        CarrecarContas();
    }

    private void BotaoAdicionarConta_Click(object sender, EventArgs e)
    {
        _conta.ShowDialog();
        CarrecarContas();
    }

    async void CarrecarContas()
    {
        var contas = await _bancoDadosContexto.Contas
            .ToListAsync();


        TabelaContas.DataSource = contas.Any()
            ? contas.ConvertAll(c =>
                        new { Nome = c.NomeConta, Tipo = Conta.ObterDescricaoTipoConta(c.TipoConta), Saldo = c.Saldo.FormatarParaMoeda() })
            .ToList() : null;
    }
}
