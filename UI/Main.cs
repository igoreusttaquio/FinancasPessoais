using UI;
using UI.Services;

namespace EmbeddedForms
{
    public partial class Main : Form
    {
        private readonly INavigationService navigationService;
        public Main(INavigationService navigationService)
        {
            this.navigationService = navigationService;
            InitializeComponent();
            AjustarAparenciaBotoes();

            navigationService.InitializeContainer(Layout.Panel2);
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            navigationService.NavigateTo<DashBoard>();
        }

        private void BtnContas_Click(object sender, EventArgs e)
        {
            navigationService.NavigateTo<Contas>();
        }

        private void BtnTransacoes_Click(object sender, EventArgs e)
        {
            navigationService.NavigateTo<Transacoes>();
        }

        private void AjustarAparenciaBotoes()
        {
            foreach (var botao in Sidebar.Controls.OfType<Button>())
            {
                botao.Cursor = Cursors.Hand;
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            navigationService.GoBack();
        }

        private void BrnCategoria_Click(object sender, EventArgs e)
        {
            navigationService.NavigateTo<Categorias>();
        }
    }
}
