using Core.Dados;
using Microsoft.EntityFrameworkCore;
using UI.Modais;
using UI.Utils;

namespace UI
{
    public partial class Transacoes : Form
    {
        TransacaoModal _modal;
        BancoDadosContexto _bancoDadosContexto;
        public Transacoes(
            TransacaoModal modal,
            BancoDadosContexto bancoDadosContexto)
        {
            InitializeComponent();
            _modal = modal;
            _bancoDadosContexto = bancoDadosContexto;
            PreencerTabelaTransacoes();
        }

        private void BtnAdicionarTransacao_Click(object sender, EventArgs e)
        {
            _modal.ShowDialog();
            PreencerTabelaTransacoes();
        }

        private async void PreencerTabelaTransacoes(DateTime? data = null)
        {
            TabelaTransacoes.DataSource = null;
            var transacoes = await _bancoDadosContexto.Transacoes.ToListAsync();
            if (data != null)
            {
                transacoes = transacoes.Where(t => t.DataTransacao.Month == data.Value.Month
                    && t.DataTransacao.Year == data.Value.Year).ToList();
            }

            TabelaTransacoes.DataSource = transacoes
                .ConvertAll(t => new
                {
                    Data = t.DataTransacao,
                    Conta = t.Conta?.NomeConta,
                    Categoria = t.Categoria?.NomeCategoria,
                    Valor = t.Receita ? t.Valor.FormatarParaMoeda() : $"-{t.Valor.FormatarParaMoeda()}",
                    t.Descricao
                }).ToList();
        }

        private void DataFiltro_ValueChanged(object sender, EventArgs e)
        {
            PreencerTabelaTransacoes(DataFiltro.Value);
        }
    }
}
