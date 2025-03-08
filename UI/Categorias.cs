using System.Globalization;
using Core.Dados;
using UI.Modais;
using UI.Utils;

namespace UI
{
    public partial class Categorias : Form
    {
        CategoriaModal _modalCategoria;
        BancoDadosContexto _bancoDadosContexto;
        public Categorias(
            CategoriaModal modal,
            BancoDadosContexto bancoDadosContexto)
        {
            InitializeComponent();

            _modalCategoria = modal;
            _bancoDadosContexto = bancoDadosContexto;
            PreencherTabelaCategorias();
        }

        private void botaoPrimario1_Click(object sender, EventArgs e)
        {
            _modalCategoria.ShowDialog();
            PreencherTabelaCategorias();
        }

        private void PreencherTabelaCategorias()
        {
            var categorias = _bancoDadosContexto.Categorias.ToList()?.Select(c => new { Nome = c.NomeCategoria, Orcamento = c.Orcamento.FormatarParaMoeda() });
            if (categorias is null) return;

            tabela1.DataSource = categorias.ToList();
        }

    }
}
