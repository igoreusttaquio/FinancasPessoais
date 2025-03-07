using Core.Dados;
using Microsoft.EntityFrameworkCore;
using UI.Modais;

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

        private async void PreencerTabelaTransacoes()
        {
            TabelaTransacoes.DataSource = null;
            var transacoes = await _bancoDadosContexto.Transacoes.ToListAsync();
            TabelaTransacoes.DataSource = transacoes
                .ConvertAll(t => new
                {
                    Data = t.DataTransacao,
                    Conta = t.Conta?.NomeConta,
                    Categoria = t.Categoria?.NomeCategoria,
                    t.Valor,
                    t.Descricao
                }).ToList();
        }
    }
}
