using System.Linq;
using Core.Dados;
using UI.Modal;

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
            var categorias = _bancoDadosContexto.Categorias.ToList()?.Select(c => new { Nome = c.NomeCategoria, Tipo = Capitalize(c.TipoCategoria) });
            if (categorias is null) return;

            tabela1.DataSource = categorias.ToList();
        }

        public static string Capitalize(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            // Capitaliza a primeira letra e mantém o resto da string inalterado
            return input.Substring(0, 1).ToUpper() + input.Substring(1).ToLower();
        }

    }
}
