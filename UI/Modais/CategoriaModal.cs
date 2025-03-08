using Core.Dados;
using UI.Services;

namespace UI.Modais
{
    public partial class CategoriaModal : Form
    {
        private readonly BancoDadosContexto _bancoDadosContexto;
        private readonly IDateTimeProvider _dateTimeProvider;
        public CategoriaModal(
            BancoDadosContexto bancoDadosContexto,
            IDateTimeProvider dateTimeProvider
            )
        {
            InitializeComponent();
            _bancoDadosContexto = bancoDadosContexto;
            _dateTimeProvider = dateTimeProvider;
        }


        private void botaoPrimario1_Click(object sender, EventArgs e)
        {
            var categoria = new Core.Entidades.Categoria
            {
                Id = Guid.NewGuid(),
                CriadoEm = _dateTimeProvider.UtcNow,
                NomeCategoria = NomeCategoria.Texto,
                Orcamento = decimal.Parse(Orcamento.Texto)
            };

            _bancoDadosContexto.Categorias.Add(categoria);
            _bancoDadosContexto.SaveChanges();
            Close();
        }
    }
}
