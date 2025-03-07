using Core.Dados;
using Core.Entidades;
using Microsoft.EntityFrameworkCore;
using UI.Services;

namespace UI.Modais
{
    public partial class TransacaoModal : Form
    {
        BancoDadosContexto _bancoDados;
        IDateTimeProvider _dateTimeProvider;
        public TransacaoModal(
            BancoDadosContexto bancoDados,
            IDateTimeProvider dateTimeProvider)
        {
            InitializeComponent();
            _bancoDados = bancoDados;
            _dateTimeProvider = dateTimeProvider;
            PreencherComboConta();
            PrencherComboCategoria();
        }

        private async void PreencherComboConta()
        {
            var contas = await _bancoDados.Contas.ToArrayAsync();
            ComboContas.DefinirValores(contas);
        }

        private async void PrencherComboCategoria()
        {
            var categorias = await _bancoDados.Categorias.ToArrayAsync();
            ComboCategorias.DefinirValores(categorias);
        }

        private void BotaoSalvar_Click(object sender, EventArgs e)
        {
            var data = _dateTimeProvider.UtcNow;
            var transacao = new Transacao
            {
                Categoria = ComboCategorias.Valor as Categoria,
                Conta = ComboContas.Valor as Conta,
                Valor = decimal.Parse(Valor.Texto),
                CriadoEm = data,
                DataTransacao = data,
                Descricao = Descricao.Texto,
            };

            var conta = _bancoDados.Contas.First(c => c.Id == transacao.Conta.Id);

            if (transacao.Categoria?.TipoCategoria.ToLower() == "receita")
            {
                conta.Depositar(transacao.Valor);
            }

            if (transacao.Categoria?.TipoCategoria.ToLower() == "despesa")
            {
                conta.Sacar(transacao.Valor);
            }

            _bancoDados.Transacoes.Add(transacao);
            _bancoDados.SaveChanges();
            Close();
        }
    }
}
