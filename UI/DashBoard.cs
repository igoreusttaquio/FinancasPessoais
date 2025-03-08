using System.Globalization;
using Core.Dados;
using Microsoft.EntityFrameworkCore;
using UI.Utils;
using static UI.Utils.TabelaExtencoes;

namespace EmbeddedForms
{
    public partial class DashBoard : Form
    {
        BancoDadosContexto _bancoDadosContexto { get; set; }
        public DashBoard(BancoDadosContexto bancoDadosContexto)
        {
            InitializeComponent();
            TabelaAtividadesRecentes.DesabilitarGeracaoAutomaticaColunas();
            _bancoDadosContexto = bancoDadosContexto;

            AdicionarDadosFicticios();
            PreencherCards();
        }

        private async void AdicionarDadosFicticios()
        {
            var transacoes = await _bancoDadosContexto.Transacoes
                .Include(t => t.Conta)
                .Include(t => t.Categoria)
                .OrderByDescending(t => t.DataTransacao)
                .Take(100)
                .ToListAsync();


            TabelaAtividadesRecentes.DataSource = transacoes
                .ConvertAll(t => new
                {
                    Data = t.DataTransacao,
                    Conta = t.Conta?.NomeConta,
                    Categoria = t.Categoria?.NomeCategoria,
                    Valor = t.Receita ? t.Valor.FormatarParaMoeda() : $"-{t.Valor.FormatarParaMoeda()}",
                    t.Descricao
                })
                .ToList();
        }

        private async void PreencherCards()
        {
            int totalTransacoes = await _bancoDadosContexto.Transacoes.CountAsync();
            decimal totalContas = await _bancoDadosContexto.Contas.SumAsync(c => c.Saldo);
            decimal saldoDespesas = await _bancoDadosContexto.Transacoes.Where(t => !t.Receita).SumAsync(t => t.Valor);

            CardTotalTransacoes.DetralheCard = totalTransacoes > 1 ? $"{totalTransacoes} Transações" : $"{totalTransacoes} Transação";
            CardTotalContas.DetralheCard = totalContas.FormatarParaMoeda();
            CardSaldoTotal.DetralheCard = saldoDespesas.FormatarParaMoeda();
        }

        private void CardSaldoTotal_Load(object sender, EventArgs e)
        {

        }
    }
}
